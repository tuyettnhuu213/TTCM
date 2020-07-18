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
    public partial class page_nhanvien : UserControl
    {
        public page_nhanvien()
        {
            InitializeComponent();
        }
        public page_nhanvien(string user)
        {
            username = user;
            InitializeComponent();
        }
        private string username;
        private void page_nhanvien_Load(object sender, EventArgs e)
        {
            loadnhanvien();
            loadchucvu();
            btnluucv.IconVisible = true;
            btnthemcv.IconVisible = true;
            btnxoacv.IconVisible = true;
            bunifuFlatButton1.IconVisible = true;
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadnhanvien()
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<NhanVien> ds_nhanvien = quanli.NhanViens.ToList();
                DataTable table = new DataTable();
                table.Columns.Add("TenDangNhap");
                table.Columns.Add("TenNhanVien");
                table.Columns.Add("DiaChi");
                table.Columns.Add("CMND");
                table.Columns.Add("SDT");
                table.Columns.Add("TenChucVu");
                foreach (NhanVien item in ds_nhanvien)
                {
                    string chucvu = "";
                    if (item.IdChucVu == null)
                        chucvu = "rỗng";
                    else
                        chucvu = quanli.ChucVus.FirstOrDefault(p => p.IdChucVu == item.IdChucVu).TenChucVu;
                    table.Rows.Add(item.TenDangNhap, item.TenNhanVien, item.DiaChi, item.CMND, item.SDT, chucvu);
                }
                dgvnhanvien.DataSource = table;
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form_ThemNhanVien nv = new Form_ThemNhanVien();

            nv.getthem().Click += clickthem;
            nv.ShowDialog();
        }

        private void clickthem(object sender, EventArgs e)
        {
            loadnhanvien();
        }
        public void loadchucvu()
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<ChucVu> ds_chucvu = quanli.ChucVus.ToList();
                DataTable table = new DataTable();
                table.Columns.Add("IdChucVu");
                table.Columns.Add("TenChucVu");
                table.Columns.Add("luong");
                table.Columns.Add("BanHang");
                table.Columns.Add("PhaChe");
                table.Columns.Add("QuanLy");
                table.Columns.Add("HeThong");
                table.Columns.Add("ThongKe");
                table.Columns.Add("Kho");
                table.Columns.Add("KhachHang");
                foreach (ChucVu item in ds_chucvu)
                {
                    table.Rows.Add(item.IdChucVu, item.TenChucVu, item.LuongCoBan, item.BanHang, item.PhaChe, item.QuanLy, item.HeThong, item.ThongKe, item.Kho, item.KhachHang);
                }

                dgvchucvu.DataSource = table;
            }
        }
        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string tendangnhap = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                string tennv = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                string diachi = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                string cmnd = dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                string sdt = dgvnhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                string chucvu = dgvnhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();

                Form_SuaNhanVien suachua = new Form_SuaNhanVien(tendangnhap, tennv, diachi, sdt, cmnd, chucvu);
                suachua.getthem().Click += clickthem;

                suachua.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                {
                    string tendangnhap = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();

                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NhanVien nv = quanli.NhanViens.Where(p => p.TenDangNhap == tendangnhap).FirstOrDefault();
                        quanli.NhanViens.Remove(nv);
                        quanli.SaveChanges();
                        loadnhanvien();
                        MessageBox.Show("Xóa thành công!!");

                    }



                }
            }
        }
        int machucvu = 0;
        private void dgvchucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnthemcv_Click(object sender, EventArgs e)
        {
            try
            {
                btnthemcv.Text = btnthemcv.Text == "Thêm" ? btnthemcv.Text = "Làm mới" : btnthemcv.Text = "Thêm";
                if (btnthemcv.Text == "Thêm")
                {
                    btnluucv.Enabled = false;
                    btnxoacv.Enabled = false;
                    lammoi();
                }
                else if (btnthemcv.Text == "Làm mới")
                {
                    btnluucv.Enabled = true;
                    btnxoacv.Enabled = true;
                    errorMessage.Clear();
                    string ten = txttencv.Text.Trim();
                    string luong = txtluong.Text.Trim();
                    if (string.IsNullOrEmpty(ten))
                    {
                        errorMessage.SetError(txttencv, "Bạn cần nhập tên chức vụ !");
                        txttencv.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(luong))
                    {
                        errorMessage.SetError(txtluong, "Bạn cần nhập lương ! ");
                        txtluong.Focus();
                        return;
                    }

                    using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                    {
                        ChucVu cv = new ChucVu();
                        cv.TenChucVu = txttencv.Text;
                        cv.LuongCoBan = int.Parse(txtluong.Text);
                        cv.BanHang = ckbanhang.Checked;
                        cv.QuanLy = cknhanvien.Checked;
                        cv.PhaChe = ckphache.Checked;
                        cv.ThongKe = ckthongke.Checked;
                        cv.KhachHang = ckkhachhang.Checked;
                        cv.Kho = ckqlkho.Checked;
                        quanli.ChucVus.Add(cv);
                        quanli.SaveChanges();
                        MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        loadchucvu();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được! Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lammoi()
        {
            txtluong.Text = "";
            txttencv.Text = "";
            ckbanhang.Checked = false;
            cknhanvien.Checked = false;
            ckphache.Checked = false;
            ckthongke.Checked = false;
            ckqlkho.Checked = false;
            ckkhachhang.Checked = false;
            btnluucv.Enabled = false;
            btnxoacv.Enabled = false;
            btnthemcv.Text = "Thêm";
        }

        private void dgvchucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnthemcv.Text = "Làm mới";
            btnluucv.Enabled = true;
            btnxoacv.Enabled = true;
            int r = e.RowIndex;
            if (r >= 0)
            {
                machucvu = int.Parse(dgvchucvu.Rows[r].Cells["IdChucVu"].Value.ToString());
                txttencv.Text = dgvchucvu.Rows[r].Cells["TenChucVu"].Value.ToString();
                txtluong.Text = dgvchucvu.Rows[r].Cells["luong"].Value.ToString();
                ckbanhang.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["BanHang"].Value);
                cknhanvien.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["QuanLy"].Value);
                ckphache.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["PhaChe"].Value);
                ckthongke.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["ThongKe"].Value);
                ckkhachhang.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["KhachHang"].Value);
                ckqlkho.Checked = Convert.ToBoolean(dgvchucvu.Rows[r].Cells["Kho"].Value);
            }
        }

        private void btnluucv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttencv.Text))
            {
                MessageBox.Show("yêu cầu nhập tên chức vụ !");
                return;
            }
            if (string.IsNullOrEmpty(txtluong.Text))
            {
                MessageBox.Show("yêu cầu nhập lương chức vụ !");
                return;
            }              
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                ChucVu cv = quanli.ChucVus.FirstOrDefault(p => p.IdChucVu == machucvu);
                cv.TenChucVu = txttencv.Text;
                cv.ThongKe = ckthongke.Checked;
                cv.QuanLy = cknhanvien.Checked;
                cv.Kho = ckqlkho.Checked;
                cv.PhaChe = ckphache.Checked;
                cv.BanHang = ckbanhang.Checked;
                cv.KhachHang = ckkhachhang.Checked;
                int luong = int.Parse(txtluong.Text);
                cv.LuongCoBan = luong;
                quanli.SaveChanges();
                MessageBox.Show(this, "Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadchucvu();
                lammoi();

            }
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
