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
    public partial class Form_CaNhan : Form
    {
        private string username;
        public Form_CaNhan()
        {
            InitializeComponent();
        }
        public Form_CaNhan(string username)
        {
            this.Username = username;
            InitializeComponent();
        }
        public string Username { get => username; set => username = value; }

        private void Form_CaNhan_Load(object sender, EventArgs e)
        {
            using (DatabaseQLTSEntities ql = new DatabaseQLTSEntities())
            {
                NhanVien nv = ql.NhanViens.FirstOrDefault(p => p.TenDangNhap.Trim() == username.Trim().ToLower());
              txtten.Text = nv.TenNhanVien;
             txtcmnd.Text = nv.CMND;
               txtdiachi.Text = nv.DiaChi;
                 txtsdt.Text= nv.SDT;
                string cv = ql.ChucVus.FirstOrDefault(p => p.IdChucVu == nv.IdChucVu).TenChucVu;
                txtchucvu.Text = cv;
            }    
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
