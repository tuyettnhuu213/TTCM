using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuyenMon
{
    public partial class Form_SuaNhanVien : Form
    {
        public Form_SuaNhanVien()
        {
            InitializeComponent();
        }

        private string tennv;
        private string diachi;
        private string sdt;
        private string cmnd;
        private string chucvu;
        private string tendangnhap;

        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public string TenDangNhap { get => tendangnhap; set => tendangnhap = value; } 

        public Form_SuaNhanVien(string tendangnhap, string tennv, string diachi, string sdt, string cmnd, string chucvu )
        {

            this.tennv = tennv;
            this.diachi = diachi;
            this.sdt = sdt;
            this.cmnd = cmnd;
            this.chucvu = chucvu;
            this.tendangnhap = tendangnhap;
            InitializeComponent();

        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtcmnd.Text == "" || txttendangnhap.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!!!");
                return false;
            }
            return true;
        }
        public Bunifu.Framework.UI.BunifuThinButton2 getthem()
        {
            return btnDangNhap;
        }
        private void Form_SuaNhanVien_Load(object sender, EventArgs e)
        {
            txtten.Text = tennv;
            txtdiachi.Text = diachi;
            txtsdt.Text = sdt;
            txtcmnd.Text = cmnd;
            txttendangnhap.Text = tendangnhap;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<ChucVu> ds_chucvu = quanli.ChucVus.ToList();
                foreach (ChucVu item in ds_chucvu)
                {
                    cbchucvu.Items.Add(item.TenChucVu);
                }
                cbchucvu.SelectedItem = chucvu;
            }
            txtten.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == tendangnhap);
                int macv = quanli.ChucVus.FirstOrDefault(p => p.TenChucVu == cbchucvu.SelectedItem.ToString()).IdChucVu;
                nv.TenNhanVien = txtten.Text;
                nv.SDT = txtsdt.Text;
                nv.DiaChi = txtdiachi.Text;
                nv.CMND = txtcmnd.Text;
                nv.IdChucVu = macv;
                quanli.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công!!");
            }
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
