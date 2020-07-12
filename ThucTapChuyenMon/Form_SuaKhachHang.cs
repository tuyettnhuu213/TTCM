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
    public partial class Form_SuaKhachHang : Form
    {
        public Form_SuaKhachHang()
        {
            InitializeComponent();
        }
        private string makh;
        private string tenkh;
        private string diachi;
        private string sdt;

        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }


        public string Makh { get => makh; set => makh = value; }
        public Form_SuaKhachHang(string makh, string tenkh, string diachi, string sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
       
            InitializeComponent();

        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!!!");
                return false;
            }
            return true;
        }
        public Bunifu.Framework.UI.BunifuThinButton2 getsuachua()
        {
            return btnDangNhap;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
                return;
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
               KhachHang kh = quanli.KhachHangs.FirstOrDefault(p => p.IdKhachHang == makh);

                kh.TenKhachHang = txtten.Text;
                kh.SDT = txtsdt.Text;
                kh.DIACHI = txtdiachi.Text;

                quanli.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công!!");
            }
            this.Close();
        }

        internal object getsua()
        {
            throw new NotImplementedException();
        }

        private void Form_SuaKhachHang_Load(object sender, EventArgs e)
        {
            txtten.Text = tenkh;
            txtdiachi.Text = diachi;
            txtsdt.Text = sdt;
            txtten.Focus();
    
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
