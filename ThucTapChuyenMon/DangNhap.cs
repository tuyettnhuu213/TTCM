using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ThucTapChuyenMon
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
      
        private void DangNhap_Load(object sender, EventArgs e)
        {
           
          

        }

        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider1.Clear();
                string username = txtname.Text.Trim();
                string pass = txtpass.Text.Trim();

                if (string.IsNullOrEmpty(username) || txtname.ForeColor == Color.Gray)
                {
                    errorProvider1.SetError(txtname, "Bạn cần nhập tên tài khoản !");
                    txtname.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(pass) || txtpass.ForeColor == Color.Gray)
                {
                    errorProvider1.SetError(txtpass, "Bạn cần nhập mật khẩu ! ");
                    txtpass.Focus();
                    return;
                }
                else
                    Dang_Nhap();
            }
        }

        private void Dang_Nhap()
        {
           
                errorProvider1.Clear();
                if (txtname.Text == "")
                {
                    errorProvider1.SetError(txtname, "Bạn cần nhập tên tài khoản !");
                    txtname.Focus();
                    return;
                }
                else if (txtpass.Text == "")
                {
                    errorProvider1.SetError(txtpass, "Bạn cần nhập mật khẩu ! ");
                    txtpass.Focus();
                    return;
                }
            using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
            {
                NhanVien lg = db.NhanViens.Where(p => p.TenDangNhap == txtname.Text && p.MatKhau == txtpass.Text.Trim()).FirstOrDefault();
                if (lg == null)
                {
                    MessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu! \n Vui lòng kiểm tra lại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                   
                }
                if(lg!=null)             
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Page_Main pg = new Page_Main();
                    pg.getID("Xin Chào : " + txtname.Text);
                    pg.Show();
                    this.Hide();
                }
            }
         }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (txtpass.isPassword == false)
            {
                txtpass.isPassword = true;
            }
            else
            {
                txtpass.isPassword = false;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            };
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            txtpass.isPassword = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
            {
                NhanVien lg = db.NhanViens.Where(p => p.TenDangNhap == txtname.Text && p.MatKhau == txtpass.Text.Trim()).FirstOrDefault();
                if (lg == null)
                {
                    MessageBox.Show(this, "Sai tên đăng nhập hoặc mật khẩu! \n Vui lòng kiểm tra lại !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                    return;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Page_Main pg = new Page_Main();
                    pg.getID("Xin Chào : " + txtname.Text);
                    pg.Show();
                    this.Hide();
                }
            }
        }
    }
}
