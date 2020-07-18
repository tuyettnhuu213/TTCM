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
    public partial class Form_DoiMatKhau : Form
    {
        public Form_DoiMatKhau()
        {
            InitializeComponent();
        }
        private string username;
        public Form_DoiMatKhau(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            txtmkcu.isPassword = true;
        }
        public bool kiemtra()
        {
            loi.Clear();
            if (txtmkmoi.Text != txtnhaplai.Text)
            {
                loi.SetError(txtnhaplai, "Mật khẩu không khớp !");
                return false;
            }
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                string mkcu = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == username.Trim()).MatKhau.Trim();
                if (mkcu != txtmkcu.Text)
                {
                    loi.SetError(txtmkcu, "Mật khẩu không đúng !");
                    return false;
                }
            }
            return true;
        }
        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            txtmkmoi.isPassword = true;
        }
        public string Username { get => username; set => username = value; }
        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            txtnhaplai.isPassword = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                NhanVien lg = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == username.Trim());
                lg.MatKhau = txtmkmoi.Text;
                quanli.SaveChanges();
                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
