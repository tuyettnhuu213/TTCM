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

namespace ThucTapChuyenMon
{
    public partial class page_douong : UserControl
    {
        public page_douong()
        {
            InitializeComponent();
        }
        public void Napdatalist()
        {
            lvthucdon.Groups.Clear();
            lvthucdon.Items.Clear();
            lvthucdon.Groups.Clear();
            List<LoaiDoUong> ds_Loaidouong = new List<LoaiDoUong>();
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                ds_Loaidouong = quanli.LoaiDoUongs.ToList();
                foreach (LoaiDoUong item in ds_Loaidouong)
                {
                    ListViewGroup lvl = new ListViewGroup(item.TenLoai);
                    lvl.Tag = item.IdLoai.ToString();
                    lvthucdon.Groups.Add(lvl);
                }
                foreach (ListViewGroup lvl in lvthucdon.Groups)
                {
                    int stt = 1;
                    int maloai = Int32.Parse(lvl.Tag.ToString());
                    List<DoUong> ds_douong = quanli.DoUongs.Where(p => p.IdLoai == maloai).ToList();
                    foreach (DoUong item in ds_douong)
                    {
                        ListViewItem lvi = new ListViewItem(item.IdLoai.ToString());
                        lvi.SubItems.Add(stt + "");
                        lvi.SubItems.Add(item.TenDoUong);
                        lvi.SubItems.Add(item.Id.ToString());
                        lvthucdon.Items.Add(lvi);
                        lvi.Group = lvl;
                        stt++;
                    }
                }
            }
        }
        public void Load_Loai()
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                cbloai.DataSource = quanli.LoaiDoUongs.ToList();
                cbloai.DisplayMember = "TenLoai";
                cbloai.ValueMember = "IdLoai";
            }
        }
         public void LoadSize(int id)
        {
            cbsize.Items.Clear();
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<CTDoUong> ds_douong = quanli.CTDoUongs.Where(p => p.IdDoUong == id).ToList();
                if(ds_douong!=null)
                {
                    foreach (CTDoUong item in ds_douong)
                    {
                        cbsize.Items.Add(item.Size);
                    }
                }    
                
            }
            if(cbsize.Items.Count!=0)
                cbsize.SelectedIndex = 0;
        }
        public void load_gia(int id, string size)
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<CTDoUong> ds_douong = quanli.CTDoUongs.Where(p => p.IdDoUong == id).ToList();
                foreach (CTDoUong item in ds_douong)
                {
                    if (item.Size == size)
                        txtgia.Text = item.DonGia.ToString();
                }
            }
        }
        List<DoUong> ds_douong = new List<DoUong>();
        int madouong = 0;
        private void page_douong_Load(object sender, EventArgs e)
        {         
            Napdatalist();
            Load_Loai();
            txtgia.Enabled = false;
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                ds_douong = quanli.DoUongs.ToList();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lvthucdon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btsua.Enabled = true;
            btxoa.Enabled = true;
            cbsize.Visible = true;
            txtgia.Enabled = true;
            if (lvthucdon.SelectedItems.Count > 0)
            {
                ListViewItem item = lvthucdon.SelectedItems[0];
                int i = int.Parse(item.SubItems[0].Text);
                cbloai.SelectedIndex = i - 1;
                txtten.Text = item.SubItems[2].Text;
                foreach (DoUong du in ds_douong)
                {
                    if (du.TenDoUong.Equals(txtten.Text))
                    {
                        madouong = du.Id;
                        Byte[] img = du.HinhAnh;
                        if (img != null)
                        {
                            using (MemoryStream stream = new MemoryStream(img))
                            {
                                Image returnImage = Image.FromStream(stream);
                                hinhanh.Image = returnImage;
                            }
                        }
                        LoadSize(du.Id);
                        if (cbsize.Items.Count != 0)
                            load_gia(du.Id, cbsize.SelectedItem.ToString());
                        else
                            txtgia.Text = "";
                    }
                }
            }
        }

        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsize.Items.Count == 0)
                return;
            int matd = 0;
            foreach (DoUong du in ds_douong)
            {
                if (du.TenDoUong.Equals(txtten.Text))
                {
                    matd = du.Id;
                }
            }
            load_gia(matd, cbsize.Text);
        }
        string img = "";

        private void hinhanh_Click(object sender, EventArgs e)
        {
            if (mofile.ShowDialog(this) == DialogResult.OK)
            {
                img = mofile.FileName.ToString();
            }
            if (img == "")
                return;
            Image image = Image.FromFile(img);
            hinhanh.Image = image;
            hinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (madouong == 0)
            {
                MessageBox.Show("Yêu cầu chọn đồ uống cần xem chi tiết !");
                return;
            }
            Form_CTDoUong ct = new Form_CTDoUong(madouong);
            ct.FormClosed += new FormClosedEventHandler(formcloseloai);
            ct.ShowDialog();
        }
        public void reset()
        {
            cbsize.Items.Clear();
            txtten.Text = "";
            txtgia.Text = "";
            hinhanh.Image = null;
            madouong = 0;
            btsua.Enabled = false;
            btxoa.Enabled = false;
            txtgia.Enabled = true;
        }
        public void ThemDoUong()
        {
            try
            {
                if (img.Equals(""))
                {
                    MessageBox.Show("Yêu cầu click vô image chọn ảnh!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {

                    int maloai = quanli.LoaiDoUongs.FirstOrDefault(p => p.TenLoai == cbloai.Text).IdLoai;
                    DoUong du = new DoUong();
                    du.IdLoai = maloai;
                    du.TenDoUong = txtten.Text;
                    du.HinhAnh = images;
                    quanli.DoUongs.Add(du);
                    quanli.SaveChanges();
                }
                MessageBox.Show(this, "Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Napdatalist();
                ds_douong.Clear();
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {
                    ds_douong = quanli.DoUongs.ToList();
                }
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể thêm , vui lòng kiểm tra lại!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form_CTLoaiDoUong loai = new Form_CTLoaiDoUong();
            loai.FormClosed += new FormClosedEventHandler(formcloseloai);
            loai.ShowDialog();


         
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            
                errorMessage.Clear();
                string ten = txtten.Text.Trim();
                if (string.IsNullOrEmpty(ten))
                {
                    errorMessage.SetError(txtten, "Bạn cần nhập tên đồ uống !");
                    txtten.Focus();
                    return;
                }
                else
                {
                    ThemDoUong();
                }
         
            
        }

        private void txtgia_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                if (hinhanh.Image == null)
                {
                    MessageBox.Show("Yêu cầu click vô image chọn ảnh!!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int maloai = quanli.LoaiDoUongs.FirstOrDefault(p => p.TenLoai == cbloai.Text).IdLoai;
                DoUong du = quanli.DoUongs.FirstOrDefault(p => p.Id == madouong);
                du.IdLoai = maloai;
                du.TenDoUong = txtten.Text;
                MemoryStream me = new MemoryStream();
                byte[] images = null;
                if (img != "")
                {
                    FileStream stream = new FileStream(img, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    images = brs.ReadBytes((int)stream.Length);
                    du.HinhAnh = images;
                }
                if(cbsize.Text != "" )
                {
                    quanli.updateCTdu(du.Id, cbsize.SelectedItem.ToString(), int.Parse(txtgia.Text));
                }                
                quanli.SaveChanges();
                Napdatalist();
                MessageBox.Show(this, "Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void formcloseloai(object sender, FormClosedEventArgs e)
        {
            Napdatalist();
            Load_Loai();
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (madouong == 0)
            {
                MessageBox.Show("Yêu cầu chọn đồ uống cần xóa !");
                return;
            }
            if (MessageBox.Show(this, "Bạn có muốn xóa đồ uống này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {
                    CTHoaDon ct_hd = quanli.CTHoaDons.FirstOrDefault(p => p.IdDoUong == madouong);
                    if (ct_hd != null)
                    {
                        MessageBox.Show(this, "Dữ liệu đang sử dụng không thể xóa !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    List<CTDoUong> ds_chitiet = quanli.CTDoUongs.Where(p => p.IdDoUong == madouong).ToList();
                    foreach (var item in ds_chitiet)
                    {
                        quanli.CTDoUongs.Remove(item);
                        quanli.SaveChanges();
                    }
                    DoUong du = quanli.DoUongs.FirstOrDefault(p => p.Id == madouong);
                    quanli.DoUongs.Remove(du);
                    quanli.SaveChanges();
                    reset();
                    Napdatalist();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void cbloai_TextChanged(object sender, EventArgs e)
        {

            load_gia(madouong, cbsize.Text);
        }

        private void cbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_gia(madouong, cbsize.Text);
        }
    }
}
