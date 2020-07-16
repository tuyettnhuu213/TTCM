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
    public partial class Form_NhapNguyenLieuSapHet : Form
    {
        public Form_NhapNguyenLieuSapHet()
        {
            InitializeComponent();
        }
        public Form_NhapNguyenLieuSapHet(string username,int manl)
        {
            this.manl = manl;
            this.username = username.Trim();
            InitializeComponent();
        }
        public int Manl { get => manl; set => manl = value; }
        public string Username { get => username; set => username = value; }
        private int manl;
        private string username;
        public void loadnl()
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                txttennl.Text = nl.TenNguyenLieu;
                txtsoluong.Text = "";
                cbdvt.Text = nl.DonViTinh;
            }
        }
        private void Form_NhapNguyenLieuSapHet_Load(object sender, EventArgs e)
        {
            loadnl();
        }
        public bool kiemtra()
        {

            if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Yêu cầu nhập số lượng !");
                return false;
            }
            try
            {
                float sl = float.Parse(txtsoluong.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Kiểu dữ liệu số lượng !");
                return false;
            }
            return true;

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {

                PhieuNhap pn = new PhieuNhap();
                pn.TenDangNhap = username.Trim();
                pn.ThoiGianLap = DateTime.Now;
                quanli.PhieuNhaps.Add(pn);             
                NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                nl.SoLuong = nl.SoLuong + double.Parse(txtsoluong.Text.ToString());
                quanli.SaveChanges();
                CTPhieuNhap ct = new CTPhieuNhap();
                ct.IdPhieuNhap = pn.IdPhieuNhap;
                ct.IdNguyenLieu = manl;
                ct.SoLuong = double.Parse(txtsoluong.Text.ToString());
                ct.DonGia = int.Parse(txtgia.Text.ToString());
                quanli.CTPhieuNhaps.Add(ct);
                double tong = double.Parse(txtsoluong.Text.ToString()) * int.Parse(txtgia.Text.ToString());
                pn.TongTien = int.Parse(tong.ToString());
                quanli.SaveChanges();
            }
            MessageBox.Show("Đã Nhập !");
            this.Close();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
