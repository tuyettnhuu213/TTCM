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

namespace ThucTapChuyenMon
{
    public partial class page_banhang : UserControl
    {
        private string username;
        private string makh;
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
        public void loadhinh(int maloai)
        {
            panelhinhanh.Controls.Clear();

            int i = 0;
            using (THUCTAPCHUYENMONEntities  quanli = new THUCTAPCHUYENMONEntities())
            {
                List<DoUong> ds_douong = quanli.DoUongs.Where(p => p.IdLoai == maloai).ToList();
                int dem = ds_douong.Count % 5;
                int count = ds_douong.Count / 5;
                foreach (var item in ds_douong)
                {

                    BunifuImageButton img = new BunifuImageButton();
                    img.Name = item.Id.ToString();
                    img.Size = new System.Drawing.Size(100, 100);
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
                            tb.Size = new System.Drawing.Size(100, 13);
                            tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                            tb.Text = ds_douong[j].TenDoUong;
                            panelhinhanh.Controls.Add(tb);
                        }
                    }
                }
                if (dem < 5)
                {
                    for (int k = 0; k < 5 - dem; k++)
                    {
                        Label tb = new Label();
                        tb.Size = new System.Drawing.Size(100, 13);
                        tb.BackColor = Color.White;
                        panelhinhanh.Controls.Add(tb);
                        tb.Enabled = false;
                    }
                    for (int j = 0; j < dem; j++)
                    {
                        TextBox tb = new TextBox();
                        tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        tb.Size = new System.Drawing.Size(100, 13);
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
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<DoUong> ds_douong = quanli.DoUongs.ToList();
                for (int i = 0; i < ds_douong.Count; i++)
                {
                    if (ds_douong[i].Id == matd)
                    {
                        cbDoUong.SelectedIndex = i;
                        return;
                    }
                }
            }
        }
        public void loadsize(int matd)
        {
            cbsize.Items.Clear();
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
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
                using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
                {
                    KhachHang kh = db.KhachHangs.FirstOrDefault(p => p.IdKhachHang == makh);
                    if(kh!=null)
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
            kh.ShowDialog();
        }

        private void btnquetma_Click(object sender, EventArgs e)
        {
            Form_QuetMaBarCode qm = new Form_QuetMaBarCode();
            qm.ShowDialog();
        }

        private void page_banhang_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
