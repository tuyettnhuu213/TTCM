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
    public partial class page_nguyenlieu : UserControl
    {
        public page_nguyenlieu()
        {
            InitializeComponent();
        }
        public page_nguyenlieu(string username, ErrorProvider error)
        {
            this.username = username;
            this.error = error;
            InitializeComponent();
        }
        private string username;
        private ErrorProvider error;
        public Page_Main form;
        public string Username { get => username; set => username = value; }
        private void page_nguyenlieu_Load(object sender, EventArgs e)
        {
            loadnguyenlieu();
            loadphieunhap();
            loadphieuxuat();
            loadnguyenlieusaphet();
            btnPhieuXuat.IconVisible = true;
            bunifuFlatButton1.IconVisible = true;
      
        }
        public void loadnguyenlieu()
        {

            DataTable table = new DataTable();
            table.Columns.Add("IdNguyenLieu");
            table.Columns.Add("TenNguyenLieu");
            table.Columns.Add("DonViTinh");
            table.Columns.Add("SoLuong");
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<NguyenLieu> ds_nguyenlieu = quanli.NguyenLieux.ToList();
                foreach (var item in ds_nguyenlieu)
                {

                    table.Rows.Add(item.IdNguyenLieu, item.TenNguyenLieu, item.DonViTinh, item.SoLuong);

                }
                dgvnguyenlieu.DataSource = table;

            }
        }
        public void loadphieunhap()
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("IdPhieuNhap");
                table.Columns.Add("tennl");
                table.Columns.Add("dvt");
                table.Columns.Add("SoLuong");
                table.Columns.Add("DonGia");              
                table.Columns.Add("ThoiGianLap");
                table.Columns.Add("tennv");
                List<PhieuNhap> ds_pn = quanli.PhieuNhaps.ToList();
                foreach (var item in ds_pn)
                {
                    string tennv = "";
                    NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == item.TenDangNhap);
                    if (nv != null)
                    {
                        tennv = nv.TenNhanVien;
                    }
                    List<CTPhieuNhap> ds_chitiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                    foreach (var ct in ds_chitiet)
                    {
                        string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                        string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                        table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, item.ThoiGianLap, tennv);
                    }
                }
                dgvphieunhap.DataSource = table;
            }
        }
        private void loadnguyenlieusaphet()
        {
            DataTable table = new DataTable();
            table.Columns.Add("IdNguyenLieu");
            table.Columns.Add("TenNguyenLieu");
            table.Columns.Add("DonViTinh");
            table.Columns.Add("SoLuong");
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<NguyenLieu> ds_nguyenlieu = quanli.NguyenLieux.Where(p => p.SoLuong <= 5).ToList();
                foreach (var item in ds_nguyenlieu)
                {
                    table.Rows.Add(item.IdNguyenLieu, item.TenNguyenLieu, item.DonViTinh, item.SoLuong);
                }

            }
            dgvsaphet.DataSource = table;

        }
        private void CloseFormCapNhat(object sender, FormClosedEventArgs e)
        {
            loadnguyenlieu();
            loadphieunhap();
            loadphieuxuat();
            loadnguyenlieusaphet();
            loadcanhbao();
        }
        private void dgvnguyenlieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int manl = int.Parse(dgvnguyenlieu.Rows[e.RowIndex].Cells["IdNguyenLieu"].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                Form_SuaNguyenLieu capnhat = new Form_SuaNguyenLieu(manl);
                capnhat.FormClosed += new FormClosedEventHandler(CloseFormCapNhat);
                capnhat.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Bạn có muốn xóa nguyên liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                    {
                        NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                        CTPhieuNhap ds_pn = quanli.CTPhieuNhaps.FirstOrDefault(p => p.IdNguyenLieu == manl);
                        if (ds_pn != null)
                        {
                            MessageBox.Show(this, "Không thể xóa !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        quanli.NguyenLieux.Remove(nl);
                        quanli.SaveChanges();
                        loadnguyenlieu();
                        MessageBox.Show("Xóa thành công!!");
                    }
                }
            }
        }
        private int loadcanhbao()
        {
            int dem = 0;
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<NguyenLieu> ds_nguyenlieu = quanli.NguyenLieux.ToList();
                foreach (var item in ds_nguyenlieu)
                {

                    if (item.SoLuong <= 5)
                    {
                        dem++;

                    }
                }
            }
            return dem;
        }
        public void loadphieuxuat()
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("TenNL");
                table.Columns.Add("dvt");
                table.Columns.Add("SoLuong");
                table.Columns.Add("tennv");
                table.Columns.Add("ThoiGianLap");
                List<PhieuXuat> ds_px = quanli.PhieuXuats.ToList();
                foreach (var item in ds_px)
                {
                    string tennv = "";
                    NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == item.TenDangNhap);
                    if (nv != null)
                    {
                        tennv = nv.TenNhanVien;
                    }
                    List<CTPhieuXuat> ds_chitiet = quanli.CTPhieuXuats.Where(p => p.IdPhieuXuat == item.IdPhieuXuat).ToList();
                    foreach (var ct in ds_chitiet)
                    {
                        string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                        string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                        table.Rows.Add(item.IdPhieuXuat, tennl, dvt, ct.SoLuong, tennv, item.ThoiGianLap);
                    }
                }
                dgvphieuxuat.DataSource = table;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {         
            Form_NhapNguyenLieu nhap_nl = new Form_NhapNguyenLieu(username);
            nhap_nl.FormClosed += new FormClosedEventHandler(CloseFormCapNhat);
            nhap_nl.ShowDialog();
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            Form_XuatKho xk = new Form_XuatKho(username.Trim());
            xk.FormClosed += new FormClosedEventHandler(CloseFormCapNhat);
            xk.ShowDialog();
            form.getNguyenLieu();
            
        }

        private void dgvphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsaphet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int manl = int.Parse(dgvsaphet.Rows[e.RowIndex].Cells["manl"].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                Form_NhapNguyenLieuSapHet capnhat = new Form_NhapNguyenLieuSapHet(username,manl);
                capnhat.FormClosed += new FormClosedEventHandler(CloseFormCapNhat);
                capnhat.ShowDialog();

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
        public void timkiemnguyenlieu()
        {
            if (txtsearch.Text == "")
                loadnguyenlieu();
            DataTable table = new DataTable();
            table.Columns.Add("IdNguyenLieu");
            table.Columns.Add("TenNguyenLieu");
            table.Columns.Add("DonViTinh");
            table.Columns.Add("SoLuong");
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<NguyenLieu> ds_nguyenlieu = quanli.NguyenLieux.ToList();
                foreach (var item in ds_nguyenlieu)
                {
                    int dem = 0;
                    if (item.TenNguyenLieu.ToLower().Contains(txtsearch.Text.ToLower()))
                    {
                        dem++;
                        table.Rows.Add(item.IdNguyenLieu, item.TenNguyenLieu, item.DonViTinh, item.SoLuong);
                    }
                    if (dem == 0)
                    {
                        if (RemoveUnicode(item.TenNguyenLieu.ToLower()).Contains(RemoveUnicode(txtsearch.Text.ToLower())))
                        {
                            table.Rows.Add(item.IdNguyenLieu, item.TenNguyenLieu, item.DonViTinh, item.SoLuong);
                        }
                    }
                }
                dgvnguyenlieu.DataSource = table;
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timkiemnguyenlieu();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            timkiemphieunhap();
        }
        public void timkiemphieunhap()
        {
            if (txtphieunhap.Text == "")
                loadphieunhap();
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("IdPhieuNhap");
                table.Columns.Add("tennl");
                table.Columns.Add("dvt");
                table.Columns.Add("SoLuong");
                table.Columns.Add("DonGia");
                table.Columns.Add("ThoiGianLap");
                table.Columns.Add("tennv");
                try
                {
                    string[] ngay = txtphieunhap.Text.Split('/');
                    string txttim = ngay[1] + "/" + ngay[0] + "/" + ngay[2];
                    DateTime date = DateTime.Parse(txttim);
                    Console.WriteLine(date);
                    List<PhieuNhap> ds_pn1 = quanli.PhieuNhaps.ToList();
                    foreach (var item in ds_pn1)
                    {
                        DateTime tglap = (DateTime)item.ThoiGianLap;
                        Console.WriteLine(tglap.Year + " " + date.Year);
                        Console.WriteLine(tglap.Month + " " + date.Month);
                        Console.WriteLine(tglap.Day + " " + date.Day);
                        if (tglap.Year == date.Year && tglap.Month == date.Month && tglap.Day == date.Day)
                        {
                            Console.WriteLine("aa");
                            string tennv = "";
                            NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == item.TenDangNhap.Trim());
                            if (nv != null)
                            {
                                tennv = nv.TenNhanVien;
                            }
                            List<CTPhieuNhap> ds_chitiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                            foreach (var ct in ds_chitiet)
                            {
                                string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                                string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                                table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, item.ThoiGianLap, tennv);
                            }
                        }
                    }
                    dgvphieunhap.DataSource = table;
                    return;
                }
                catch (Exception)
                {
                }
                List<PhieuNhap> ds_pn = quanli.PhieuNhaps.Where(p => p.IdPhieuNhap.ToString().ToUpper() == txtphieunhap.Text.ToUpper()).ToList();
                if (ds_pn.Count == 0)
                {
                    ds_pn = quanli.PhieuNhaps.ToList();
                    foreach (var item in ds_pn)
                    {
                        string tennv = "";
                        NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == item.TenDangNhap);
                        if (nv != null)
                        {
                            tennv = nv.TenNhanVien;
                            int dem = 0;
                            if (tennv.ToLower().Contains(txtphieunhap.Text.ToLower()))
                            {
                                List<CTPhieuNhap> ds_ctiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                                foreach (var ct in ds_ctiet)
                                {
                                    string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                                    string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                                    table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, item.ThoiGianLap, tennv);
                                }
                                dem++;
                            }
                            if (dem == 0)
                            {
                                if (RemoveUnicode(tennv.ToLower()).Contains(RemoveUnicode(txtphieunhap.Text.ToLower())))
                                {
                                    List<CTPhieuNhap> ds_ctiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                                    foreach (var ct in ds_ctiet)
                                    {
                                        string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                                        string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                                        table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, tennv, item.ThoiGianLap);
                                    }
                                }
                                else
                                {
                                    List<CTPhieuNhap> ds_ctiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                                    foreach (var ct in ds_ctiet)
                                    {
                                        string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                                        string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                                        int count = 0;
                                        if (tennl.ToLower().Contains(txtphieunhap.Text.ToLower()))
                                        {
                                            table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, tennv, item.ThoiGianLap);
                                            count++;
                                        }
                                        if (count == 0)
                                        {
                                            if (RemoveUnicode(tennl.ToLower()).Contains(RemoveUnicode(txtphieunhap.Text.ToLower())))
                                                table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, tennv, item.ThoiGianLap);
                                        }

                                    }
                                }
                            }
                        }
                    }
                    dgvphieunhap.DataSource = table;
                    return;
                }
                foreach (var item in ds_pn)
                {
                    string tennv = "";
                    NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == item.TenDangNhap);
                    if (nv != null)
                    {
                        tennv = nv.TenNhanVien;
                    }
                    List<CTPhieuNhap> ds_chitiet = quanli.CTPhieuNhaps.Where(p => p.IdPhieuNhap == item.IdPhieuNhap).ToList();
                    foreach (var ct in ds_chitiet)
                    {
                        string tennl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).TenNguyenLieu;
                        string dvt = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == ct.IdNguyenLieu).DonViTinh;
                        table.Rows.Add(item.IdPhieuNhap, tennl, dvt, ct.SoLuong, ct.DonGia, tennv, item.ThoiGianLap);
                    }
                }
                dgvphieunhap.DataSource = table;
            }
        }
        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtsearch.Text == "")
                return;
            timkiemnguyenlieu();
        }

        private void txtphieunhap_KeyDown(object sender, KeyEventArgs e)
        {
            timkiemphieunhap();
        }
    }
}
