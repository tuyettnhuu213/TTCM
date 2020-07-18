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
    public partial class Form_ThemNhanVien : Form
    {
        public Form_ThemNhanVien()
        {
            InitializeComponent();
        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtcmnd.Text == "" || txttendangnhap.Text == "" || txtmaktkhau.Text == "")
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

        private void Form_ThemNhanVien_Load(object sender, EventArgs e)
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<ChucVu> ds_chucvu = quanli.ChucVus.ToList();
                foreach (ChucVu item in ds_chucvu)
                {
                    cbchucvu.Items.Add(item.TenChucVu);
                }
                cbchucvu.SelectedIndex = 0;
            }
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                int macv = quanli.ChucVus.FirstOrDefault(p => p.TenChucVu == cbchucvu.SelectedItem.ToString()).IdChucVu;
                NhanVien nv = new NhanVien();
                nv.IdChucVu = macv;
                nv.MatKhau = txtmaktkhau.Text;
                nv.SDT = txtsdt.Text;
                nv.TenDangNhap = txttendangnhap.Text;
                nv.TenNhanVien = txtten.Text;
                nv.CMND = txtcmnd.Text;
                nv.DiaChi = txtdiachi.Text;
                quanli.NhanViens.Add(nv);
                quanli.SaveChanges();
                MessageBox.Show("Thêm thành công!!!");
            }
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtten_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmaktkhau_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdiachi_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcmnd_OnValueChanged(object sender, EventArgs e)
        {

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
