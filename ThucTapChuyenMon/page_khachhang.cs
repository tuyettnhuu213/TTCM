using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuyenMon
{
    public partial class page_khachhang : UserControl
    {
        public page_khachhang()
        {
            InitializeComponent();
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
           From_ThemKhachHang them = new From_ThemKhachHang();
            them.ShowDialog();
        }
        private void loadkhachhang()
        {
            using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
            {
                dgvkhachhang.DataSource = db.xuatdskhachhang(0);
            }

        }

        private void page_khachhang_Load(object sender, EventArgs e)
        {
            loadkhachhang();
            loadloaithe();
            loadsukien();
            btnHuy.IconVisible = true;
            btnSua.IconVisible = true;
            btnView.IconVisible = true;
            btnThemKH.IconVisible = true;

        }

        private void loadloaithe()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("IdLoai");
            table.Columns.Add("DiemToiThieu");
            table.Columns.Add("TenLoai");
            table.Columns.Add("GiamGia");

            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<LoaiKhachHang> ds_nguyenlieu = quanli.LoaiKhachHangs.ToList();
                foreach (var item in ds_nguyenlieu)
                {
                    table.Rows.Add(item.IdLoai, item.DiemToiThieu, item.TenLoai, item.GiamGia);
                }
                dgvloaithetv.DataSource = table;
            }
        }

        private void Clicksua(object sender, EventArgs e)
        {
            loadkhachhang();
        }
        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string makh = dgvkhachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                string tenkh = dgvkhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                string diachi = dgvkhachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sdt = dgvkhachhang.Rows[e.RowIndex].Cells[4].Value.ToString();
                string loai = dgvkhachhang.Rows[e.RowIndex].Cells[5].Value.ToString();
                string dtl = dgvkhachhang.Rows[e.RowIndex].Cells[6].Value.ToString();

               Form_SuaKhachHang suachua = new Form_SuaKhachHang(makh, tenkh, diachi, sdt);
             //   suachua.getsuachua.Click += Clicksua;
                suachua.ShowDialog();

                suachua.ShowDialog();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
            {
                if (rdVang.Checked)

                {
                    dgvkhachhang.DataSource = db.xuatdskhachhang(4);
                }
                if (rdBac.Checked)
                {
                    dgvkhachhang.DataSource = db.xuatdskhachhang(3);
                }
                if (rdDong.Checked)
                {
                    dgvkhachhang.DataSource = db.xuatdskhachhang(2);
                }
                if (rdThanhVien.Checked)
                {
                    dgvkhachhang.DataSource = db.xuatdskhachhang(1);
                }
                if (rdNone.Checked)
                {
                    dgvkhachhang.DataSource = db.xuatdskhachhang(0);
                }
            }
        }
        int k;
        private void dgvloaithetv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String manl = dgvloaithetv.Rows[e.RowIndex].Cells["IdLoai"].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                k = 0;
                txtMa.Text = manl;
                txtLoaithe.Text = dgvloaithetv.Rows[e.RowIndex].Cells["TenLoai"].Value.ToString();
                txtGiamGia.Text = dgvloaithetv.Rows[e.RowIndex].Cells["GiamGia"].Value.ToString();
                txtDTT.Text = Convert.ToString(dgvloaithetv.Rows[e.RowIndex].Cells["DiemToiThieu"].Value);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")

            {
                try
                {
                    float.Parse(txtgiamud.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mục giảm giá nhập sai kiểu dữ liệu. Hãy nhập số thực (Vd:0.1)");
                    return;
                }
                if (txtDTT.Text == "" || txtGiamGia.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
                    {

                        LoaiKhachHang lt = db.LoaiKhachHangs.Where(p => p.IdLoai == Convert.ToInt32(txtMa.Text)).FirstOrDefault();
                        lt.GiamGia = int.Parse(txtGiamGia.Text);
                        lt.DiemToiThieu = int.Parse(txtDTT.Text);
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công");
                        loadloaithe();
                    }
                }
            }
            else
            {
                MessageBox.Show("An vao nut sua");
            }
        }
        public string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                           "đ","é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ","í","ì","ỉ","ĩ","ị",
                                           "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                           "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự","ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                           "d","e","e","e","e","e","e","e","e","e","e","e","i","i","i","i","i",
                                           "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                           "u","u","u","u","u","u","u","u","u","u","u","y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        public void timkiem()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdKhachHang");
            table.Columns.Add("TenKhachHang");
            table.Columns.Add("DiaChi");
            table.Columns.Add("SDT");
            table.Columns.Add("TenLoai");
            table.Columns.Add("DiemTichLuy");
            using(THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<KhachHang> ds_px = quanli.KhachHangs.ToList();
                foreach (var item in ds_px)
                {
                    string tenloai = "";
  
                    LoaiKhachHang nv = quanli.LoaiKhachHangs.FirstOrDefault(p => p.IdLoai == item.IdLoai);
                    if (nv != null)
                    {
                        tenloai= nv.TenLoai;
                    }
                    if (RemoveUnicode(item.TenKhachHang.ToLower()).Contains(RemoveUnicode(txtsearch.Text.ToLower())))
                    {
                        table.Rows.Add(item.IdKhachHang, item.TenKhachHang, item.DIACHI, item.SDT, tenloai, item.DiemTichLuy);
                    }
                        
                    }
             }
                dgvkhachhang.DataSource = table;
           
        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
                loadkhachhang();
            timkiem();
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtsearch.Text == "")
                loadkhachhang();
            timkiem();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDTT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void loadsukien()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdUuDai");
            table.Columns.Add("TenUuDai");
            table.Columns.Add("NgayBatDau");
            table.Columns.Add("NgayKetThuc");
            table.Columns.Add("GiamGia");
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<Uudai> ds_uudai = quanli.Uudais.ToList();
               foreach( var item in ds_uudai)
                {
                    table.Rows.Add(item.IdUuDai, item.TenUuDai, item.NgayBatDau, item.NgayKetThuc, item.GiamGia);
                }    
            }
            dgvuudai.DataSource = table;

        }
        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvuudai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String mauudai = dgvuudai.Rows[e.RowIndex].Cells["IdUuDai"].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                txttenud.Enabled = true;
                dtngaykt.Enabled = true;
                dtngaybd.Enabled = true;
                txtgiamud.Enabled = true;
                txtidud.Text = mauudai;
                txttenud.Text = dgvuudai.Rows[e.RowIndex].Cells["TenUuDai"].Value.ToString();
                dtngaybd.Value = Convert.ToDateTime( dgvuudai.Rows[e.RowIndex].Cells["NgayBatDau"].Value.ToString());
                dtngaykt.Value = Convert.ToDateTime(dgvuudai.Rows[e.RowIndex].Cells["NgayKetThuc"].Value.ToString());
                txtgiamud.Text = dgvuudai.Rows[e.RowIndex].Cells["Giam"].Value.ToString();
                btnthemud.Text = "Làm mới";
            }
            if (e.ColumnIndex == 1)
            {
               if(MessageBox.Show("Bạn có muốn xóa sự kiện này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                    {
                        Uudai uudai = quanli.Uudais.FirstOrDefault(p => p.IdUuDai.ToString() == mauudai);
                        quanli.Uudais.Remove(uudai);
                        quanli.SaveChanges();
                        loadsukien();
                    }    
                }    
            }    
        }
      public void resetud()
        {
            txttenud.Enabled = false;
            dtngaykt.Enabled = false;
            dtngaybd.Enabled = false;
            txtgiamud.Enabled = false;
            txtidud.Text = "";
            txttenud.Text = "";
            txtgiamud.Text = "";

        }
        private void btnLuuud_Click(object sender, EventArgs e)
        {
            if (txttenud.Text == "" || txtgiamud.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ mục");
                return;
            }
            if (dtngaybd.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu sự kiện phải lớn hơn ngày hiện tại");
                return;
            }
            if (dtngaykt.Value < dtngaybd.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                return;
            }
            try
            {
                float.Parse(txtgiamud.Text);
            } catch(Exception)
            {
                MessageBox.Show("Mục giảm giá nhập sai kiểu dữ liệu. Hãy nhập số thực (Vd:0.1)");
                return;
            }
            if (btnthemud.Text == "Làm mới")
            {
               
                using(THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {
                    Uudai uudai = quanli.Uudais.FirstOrDefault(p => p.IdUuDai.ToString() == txtidud.Text.Trim());
                    uudai.TenUuDai = txttenud.Text;
                    uudai.NgayBatDau = dtngaybd.Value;
                    uudai.NgayKetThuc = dtngaykt.Value;
                    uudai.GiamGia = float.Parse(txtgiamud.Text);
                    quanli.SaveChanges();                 
                    loadsukien();
                    btnthemud.Text = "Thêm";
                    resetud();
                }    
            }
            else
            {
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {
                    quanli.themsukien(txttenud.Text, dtngaybd.Value, dtngaykt.Value, float.Parse(txtgiamud.Text));
                    quanli.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    loadsukien();
                    resetud();
                }
            }    
        }

        private void btnthemud_Click(object sender, EventArgs e)
        {
            if(btnthemud.Text == "Làm mới")
            {
                resetud();
            } 
            if(btnthemud.Text == "Thêm")
            {
                txtgiamud.Enabled = true;
                txttenud.Enabled = true;
                dtngaybd.Enabled = true;
                dtngaykt.Enabled = true;
            }    
        }

        private void btnbackud_Click(object sender, EventArgs e)
        {
            
        }

        private void txtgiamud_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
