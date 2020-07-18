using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Bunifu.Framework.UI;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace ThucTapChuyenMon
{
    public partial class page_banhang : UserControl
    {
        private string username;
        private string makh;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice video;

        public page_banhang()
        {
            InitializeComponent();
        }
        public page_banhang(string username, string makh)
        {
            this.username = username;
            this.makh = makh;
            InitializeComponent();
        }
        public void loadgiamgia()
        {
            DateTime now = DateTime.Now;
            using(DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<Uudai> ds_uudai = quanli.Uudais.ToList();
                foreach(var item in ds_uudai)
                {
                    if(now > item.NgayBatDau && now<item.NgayKetThuc)
                    {
                        txtgiamgia.Text = item.GiamGia.ToString();
                        lbsukien.Text = item.TenUuDai;
                        return;
                    }    
                }    
            }
        }
        public void loadhinh(int maloai)
        {
            panelhinhanh.Controls.Clear();
            int i = 0;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<DoUong> ds_douong = quanli.DoUongs.Where(p => p.IdLoai == maloai).ToList();
                int dem = ds_douong.Count % 5;
                int count = ds_douong.Count / 5;
                foreach (var item in ds_douong)
                {

                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.Id.ToString();
                    img.Size = new System.Drawing.Size(116, 116);
                    img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    Byte[] hinhanh = item.HinhAnh;
                    if (hinhanh != null)
                    {
                        using (MemoryStream stream = new MemoryStream(hinhanh))
                        {
                            Image returnImage = Image.FromStream(stream);
                            img.Image = returnImage;
                        }
                    }
                    img.BorderStyle = BorderStyle.FixedSingle;
                    img.TabIndex = i;
                    img.TabStop = false;
                    img.Zoom = 10;
                    panelhinhanh.Controls.Add(img);
                    img.Click += new EventHandler(chonhinhanh);
                    i++;
                    if (i % 5 == 0)
                    {
                        for (int j = i - 5; j < i; j++)
                        {
                            TextBox tb = new TextBox();
                            tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                            tb.Size = new System.Drawing.Size(116, 13);
                            tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                            tb.Text = ds_douong[j].TenDoUong;
                            tb.BackColor = Color.PeachPuff;
                            panelhinhanh.Controls.Add(tb);
                        }
                    }
                }
                if (dem < 5)
                {
                    for (int k = 0; k < 5 - dem; k++)
                    {
                        Label tb = new Label();
                        tb.Size = new System.Drawing.Size(116, 13);
                        tb.BackColor = Color.PeachPuff;
                        panelhinhanh.Controls.Add(tb);
                        tb.Enabled = false;
                    }
                    for (int j = 0; j < dem; j++)
                    {
                        TextBox tb = new TextBox();
                        tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        tb.Size = new System.Drawing.Size(116, 13);
                        tb.BackColor = Color.PeachPuff;
                        tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        tb.Text = ds_douong[5 * count + j].TenDoUong;                       
                        panelhinhanh.Controls.Add(tb);

                    }
                }
            }
        }
        int matd = 0;
        private void chonhinhanh(object sender, EventArgs e)
        {
            cbsoluong.Value = 1;
            BunifuImageButton img = sender as BunifuImageButton;
            matd = int.Parse(img.Name);
            loadsize(matd);
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<DoUong> ds_douong = quanli.DoUongs.ToList();
                for (int i = 0; i < ds_douong.Count; i++)
                {
                    if (ds_douong[i].Id == matd)
                    {

                        cbDoUong.Text = ds_douong[i].TenDoUong;
                        return;
                    }
                }
            }

        }
        public void loadsize(int matd)
        {
            cbsize.Items.Clear();
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<CTDoUong> ds_size = quanli.CTDoUongs.Where(p => p.IdDoUong == matd).ToList();
                foreach (var item in ds_size)
                {
                    cbsize.Items.Add(item.Size);
                }
                if (cbsize.Items.Count > 0)
                {
                    cbsize.SelectedIndex = 0;

                }
            }
        }
        public string Username { get => username; set => username = value; }
        public void getID(string a)
        {
            makh = a;
            if (makh != null)
            {
                using (DatabaseQLTSEntities db = new DatabaseQLTSEntities())
                {
                    KhachHang kh = db.KhachHangs.FirstOrDefault(p => p.IdKhachHang == makh);
                    if (kh != null)
                    {
                       txtkhachhang.Text = kh.SDT.ToString();
                        lbtenkhachhang.Text = kh.TenKhachHang.ToString();
                        lbdiemtichluy.Text = kh.DiemTichLuy.ToString();
                    }
                    else { MessageBox.Show("Không nhận diện được khách hàng"); }

                }
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            From_ThemKhachHang kh = new From_ThemKhachHang();
            kh.FormClosed += new FormClosedEventHandler(formclose);
            kh.ShowDialog();         
        }

        private void btnquetma_Click(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
            video = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            video.NewFrame += VideoCaptureDevice_NewFrame;
            video.Start();
            paneldanhmuc.Visible = false;
            panelhinhanh.Visible = false;
   
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                textBox1.Invoke(new MethodInvoker(delegate ()
                {
                    textBox1.Text = result.ToString();
                    if(textBox1.Text!=null)
                    {
                        using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                        {
                            KhachHang kh = quanli.KhachHangs.Where(p => p.IdKhachHang == textBox1.Text).FirstOrDefault();
                            {
                                if(kh != null)
                                {
                                    txtkhachhang.Text = kh.SDT;
                                    lbdiemtichluy.Text = kh.DiemTichLuy.ToString();
                                    lbidkh.Text = kh.IdKhachHang;
                                    lbtenkhachhang.Text = kh.TenKhachHang;
                                    LoaiKhachHang loai = quanli.LoaiKhachHangs.Where(p => p.IdLoai == kh.IdLoai).FirstOrDefault();
                                    txtgiamgia.Text = loai.GiamGia.ToString();
                                  //  video.Stop();
                                    panelhinhanh.Visible = true;
                                    paneldanhmuc.Visible = true;                                  
                                }    
                            }
                        }    
                    }    
                }));
            }
            picquetmabarcode.Image = bitmap;
        }

        private void formclose(object sender, FormClosedEventArgs e)
        {
            loaddanhmuc();
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<DoUong> doUongs = quanli.DoUongs.ToList();
                foreach (var item in doUongs)
                {
                    cbDoUong.Items.Add(item.TenDoUong);
                    cbDoUong.DisplayMember = item.TenDoUong;
                    cbDoUong.ValueMember = item.Id.ToString();
                }
                var r = from s in quanli.KhachHangs select s.IdKhachHang;
                string a = r.Max().ToString();
                KhachHang kh = quanli.KhachHangs.Where(p => p.IdKhachHang == a.Trim()).FirstOrDefault();
                if(kh!=null)
                {
                    lbidkh.Text = kh.IdKhachHang;
                    lbtenkhachhang.Text = kh.TenKhachHang;
                    lbdiemtichluy.Text = kh.DiemTichLuy.ToString();
                    LoaiKhachHang loai = quanli.LoaiKhachHangs.Where(p => p.IdLoai == kh.IdLoai).FirstOrDefault();
                    txtgiamgia.Text = loai.GiamGia.ToString();
                    txtkhachhang.Text = kh.SDT;
                }    

            }
       
        }
       

        private void page_banhang_Load(object sender, EventArgs e)
        {
            loaddanhmuc();
            txtuser.Text = username;
            lbidkh.Text = makh;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<DoUong> doUongs = quanli.DoUongs.ToList();
                foreach(var item in doUongs)
                {
                    cbDoUong.Items.Add(item.TenDoUong);
                    cbDoUong.DisplayMember =item.TenDoUong;
                    cbDoUong.ValueMember = item.Id.ToString();
                }
               
            }
            loadgiamgia();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        List<BunifuFlatButton> ds_douong = new List<BunifuFlatButton>();
        public void loaddanhmuc()
        {
            dgvhoadon.Controls.Clear();
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<LoaiDoUong> ds_loaidu = quanli.LoaiDoUongs.ToList();
                int a = dgvhoadon.Width / (ds_loaidu.Count + 1);
                int i = 0;
                foreach (var item in ds_loaidu)
                {
                    BunifuFlatButton bt = new BunifuFlatButton();
                    bt.Activecolor = System.Drawing.Color.LightPink;
                    bt.BackColor = System.Drawing.Color.IndianRed;
                    bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    bt.BorderRadius = 0;
                    bt.ButtonText = "    " + item.TenLoai;
                    bt.Cursor = System.Windows.Forms.Cursors.Hand;
                    bt.DisabledColor = System.Drawing.Color.Gray;
                    bt.Iconcolor = System.Drawing.Color.Transparent;
                    bt.Iconimage = null;
                    bt.Iconimage_right = null;
                    bt.Iconimage_right_Selected = null;
                    bt.Iconimage_Selected = null;
                    bt.IconMarginLeft = 0;
                    bt.IconMarginRight = 0;
                    bt.IconRightVisible = true;
                    bt.IconRightZoom = 0D;
                    bt.IconVisible = true;
                    bt.IconZoom = 90D;
                    bt.IsTab = false;
                    if (i == 0)
                    {
                        bt.Normalcolor = Color.IndianRed;
                        int madu = quanli.LoaiDoUongs.FirstOrDefault(p => p.TenLoai == item.TenLoai).IdLoai;
                        loadhinh(madu);
                    }
                    else
                        bt.Normalcolor = System.Drawing.Color.IndianRed;
                    bt.OnHovercolor = System.Drawing.Color.IndianRed;
                    bt.OnHoverTextColor = System.Drawing.Color.White;
                    bt.selected = false;
                    bt.Size = new System.Drawing.Size(80, 45);
                    bt.TabIndex = i;
                    bt.Text = item.TenLoai;
                    bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    bt.Textcolor = System.Drawing.Color.White;
                    bt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bt.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
                    paneldanhmuc.Controls.Add(bt);
                    ds_douong.Add(bt);
                    i++;
                }

            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            cbsize.Items.Clear();
            cbDoUong.SelectedIndex = -1;
            txtdongia.Text = "0";
            BunifuFlatButton bt = sender as BunifuFlatButton;
            foreach (var item in ds_douong)
            {
                item.Normalcolor = Color.IndianRed;
            }
            bt.Normalcolor = Color.Black;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                int madu = quanli.LoaiDoUongs.FirstOrDefault(p => p.TenLoai == bt.Text).IdLoai;
                loadhinh(madu);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void cbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsize.SelectedIndex == -1)
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                string size = cbsize.SelectedItem.ToString();
                txtdongia.Text = quanli.CTDoUongs.FirstOrDefault(p => p.IdDoUong == matd && p.Size == size).DonGia.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (!kiemtra())
                return;
            int dongia = int.Parse(txtdongia.Text);
            int soluong = int.Parse(cbsoluong.Value.ToString());
            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                string tendu = dgvhoadon.Rows[i].Cells["tendu"].Value.ToString();
                string size = dgvhoadon.Rows[i].Cells["size"].Value.ToString();
                if (tendu == cbDoUong.Text.ToString() && cbsize.Text == size)
                {
                    int sl = int.Parse(dgvhoadon.Rows[i].Cells["soluong"].Value.ToString()) + soluong;
                    dgvhoadon.Rows[i].Cells["soluong"].Value = sl;
                    dgvhoadon.Rows[i].Cells["thanhtien"].Value = sl * dongia;
                    return;
                }
            }
            int thanhtien = dongia * soluong;
            dgvhoadon.Rows.Add(new object[] { matd, cbDoUong.Text, cbsize.Text, cbsoluong.Value.ToString(), txtdongia.Text, thanhtien });
        }

        private bool kiemtra()
        {
            if (cbsize.Items.Count == 0)
            {
                MessageBox.Show("Yêu cầu chọn đồ uống!!");
                return false;
            }
            if (txtdongia.Text == "0")
            {
                MessageBox.Show("yêu cầu chọn size đồ uống!!");
                return false;
            }
            return true;
        }

        private void cbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoUong.SelectedIndex == -1)
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                string tendu = cbDoUong.SelectedItem.ToString();
                int madu = quanli.DoUongs.FirstOrDefault(p => p.TenDoUong == tendu).Id;
                matd = madu;
                loadsize(madu);
            }
        }
        private void dgvhoadon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string xoa = dgvhoadon.Columns[e.ColumnIndex].Name.ToString();
            if (xoa.Trim() == "xoa")
            {
                dgvhoadon.Rows.Remove(dgvhoadon.Rows[e.RowIndex]);
            }
        }
        public void reset()
        {
            dgvhoadon.Rows.Clear();
            cbDoUong.SelectedIndex = -1;
            txtdongia.Text = "0";
            cbsize.SelectedIndex = -1;
            txttien.Text = "0";
            cbsoluong.Value = 1;
            txtkhachhang.Text = "";
            txtsaugiam.Text = "0";
            txtgiamgia.Text = "0";
            lbtenkhachhang.Text = "";
            lbidkh.Text = "";
            lbdiemtichluy.Text = "";

        }
       
        private void dgvhoadon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                tongtien += int.Parse(dgvhoadon.Rows[i].Cells["thanhtien"].Value.ToString());
            }
            txttien.Text = tongtien.ToString();
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvhoadon.Rows.Count == 0)
            {
                return;
            }
            else
            {
                using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                {
                    HoaDon hd = new HoaDon();
                    quanli.HoaDons.Add(hd);
                    foreach (DataGridViewRow rows in dgvhoadon.Rows)
                    {
                        CTHoaDon ct = new CTHoaDon();
                        int madu = int.Parse(rows.Cells["madu"].Value.ToString());
                        string size = rows.Cells["size"].Value.ToString();
                        string sl = rows.Cells["soluong"].Value.ToString();
                        ct.IdHoaDon = hd.IdHoaDon;
                        ct.IdDoUong = madu;
                        ct.Size = size;
                        ct.SoLuong = sl;
                        quanli.CTHoaDons.Add(ct);
                        quanli.SaveChanges();
                    }
                    if(txtkhachhang!=null)
                    {
                        KhachHang kh = quanli.KhachHangs.FirstOrDefault(p => p.IdKhachHang == lbidkh.Text);
                        if(kh!=null)
                        {
                            hd.IdKhachHang = kh.IdKhachHang;
                            kh.DiemTichLuy += int.Parse(txtsaugiam.Text) / 1000;
                            LoaiKhachHang lt = quanli.LoaiKhachHangs.Where(p => p.IdLoai == kh.IdLoai).FirstOrDefault();                       
                            int n = quanli.LoaiKhachHangs.Count();
                            for (int k = 1; k <= n; k++)
                            {
                                if (k < n)
                                {
                                   LoaiKhachHang lt2 = quanli.LoaiKhachHangs.Where(ss => ss.IdLoai == k).FirstOrDefault();
                                    LoaiKhachHang lt3 = quanli.LoaiKhachHangs.Where(ss => ss.IdLoai == (k + 1)).FirstOrDefault();
                                    if (kh.DiemTichLuy >= lt2.DiemToiThieu && kh.DiemTichLuy < lt3.DiemToiThieu)
                                    {
                                        kh.IdLoai = k;
                                        quanli.SaveChanges();
                                    }
                                }
                                else if (k == n)
                                {
                                    LoaiKhachHang lt4 = quanli.LoaiKhachHangs.Where(ss => ss.IdLoai == k).FirstOrDefault();
                                    if (kh.DiemTichLuy >= lt4.DiemToiThieu)
                                    {
                                        kh.IdLoai = k;
                                        quanli.SaveChanges();
                                    }
                                }
                            }
                        }                       
                    }   
                    hd.TongTien = int.Parse(txtsaugiam.Text);
                    hd.TenDangNhap = txtuser.Text.Trim().ToLower();                  
                    hd.ThoiGianLap = DateTime.Now;
                    quanli.SaveChanges();
                    MessageBox.Show("Thanh toán thành công");
                   Form_ThanhToan form = new Form_ThanhToan(hd.IdHoaDon);
                  
                    form.FormClosed += new FormClosedEventHandler(closeform);
                    form.ShowDialog();                  
                }
            }
        }

        private void closeform(object sender, FormClosedEventArgs e)
        {
            reset();
        }

        private void dgvhoadon_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i < dgvhoadon.Rows.Count; i++)
            {
                tongtien += int.Parse(dgvhoadon.Rows[i].Cells["thanhtien"].Value.ToString());
            }
            txttien.Text = tongtien.ToString();
        }

        private void txtkhachhang_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtkhachhang!=null)
            {
                using(DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                {
                    KhachHang kh = quanli.KhachHangs.FirstOrDefault(p => p.SDT == txtkhachhang.Text);
                    if(kh!=null)
                    {
                        lbtenkhachhang.Text = kh.TenKhachHang;
                        lbdiemtichluy.Text = kh.DiemTichLuy.ToString();
                        lbidkh.Text = kh.IdKhachHang;
                        LoaiKhachHang lt = quanli.LoaiKhachHangs.Where(p => p.IdLoai == kh.IdLoai).FirstOrDefault();
                        txtgiamgia.Text = lt.GiamGia.ToString();
                    }    
                }    
            }    
        }

        private void txttien_OnValueChanged(object sender, EventArgs e)
        {
            if (txttien.Text != "0")
            {
                int tien = int.Parse(txttien.Text);
                if (txtgiamgia.Text != "0" || txtgiamgia.Text != "")
                {
                    float saugiam = tien - tien * int.Parse(txtgiamgia.Text)/100;
                    txtsaugiam.Text = saugiam.ToString();
                }
                else txtsaugiam.Text = txttien.Text;
        
            }
        }

        private void panelhinhanh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtkhachhang_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            if (video.IsRunning == true)
                    video.Stop();

            panelhinhanh.Visible = true;
            paneldanhmuc.Visible = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void panelhinhanh_VisibleChanged(object sender, EventArgs e)
        {
            if(panelhinhanh.Visible == true)
            {
                if(video!=null)
                {
                    if (video.IsRunning == true)
                    {
                        video.SignalToStop();
                        video.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                        video = null;
                    }
                }
               
            }
        }
    }
 }

