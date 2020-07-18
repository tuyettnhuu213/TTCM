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
    public partial class Form_SuaNguyenLieu : Form
    {

        private int manl;
        public Form_SuaNguyenLieu()
        {
            InitializeComponent();
        }

        public Form_SuaNguyenLieu(int manl)
        {
            this.manl = manl;
            InitializeComponent();
        }
        public int Manl { get => manl; set => manl = value; }
        public void loadnl()
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                txtTenNguyenLieu.Text = nl.TenNguyenLieu;
                txtsoluong.Text = nl.SoLuong.ToString();
                cbDonViTinh.SelectedItem = nl.DonViTinh;
             
            }
        }
        private void Form_SuaNguyenLieu_Load(object sender, EventArgs e)
        {
            loadnl();
        }
        public bool kiemtra()
        {
            if (string.IsNullOrEmpty(txtTenNguyenLieu.Text))
            {
                MessageBox.Show("Yêu cầu nhập tên sản phẩm !");
                return false;
            }
            if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Yêu cầu nhập số lượng !");
                return false;
            }
            if (cbDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn đơn vị tính !");
                return false;
            }
            return true;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                nl.TenNguyenLieu = txtTenNguyenLieu.Text;
                nl.SoLuong = double.Parse(txtsoluong.Text);
                nl.DonViTinh = cbDonViTinh.SelectedItem.ToString();
                quanli.SaveChanges();
                MessageBox.Show("Đã Lưu !");
                this.Close();
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
