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
    public partial class Page_Main : Form
    {
        public Page_Main()
        {
            InitializeComponent();
        }
        public Bunifu.Framework.UI.BunifuFlatButton getNguyenLieu()
        {
            return btnquanlikho;
        }
        public void getID(string a)
        {
            label1.Text = a;
        }
        private void Page_Main_Load(object sender, EventArgs e)
        {
            phanquyen();
            loadcanhbao();
            btntrangchu.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
            page_banhang trangchu = new page_banhang();
            panel2.Controls.Add(trangchu);

        }

        private void loadcanhbao()
        {
            int dem = 0;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
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
            if (dem == 0)
            {
                error.Clear();

            }
            else
            {

                error.SetError(btnquanlikho, "Co" + dem + " nguyen lieu sap het");


            }
        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_banhang trangchu = new page_banhang();
            panel2.Controls.Add(trangchu);
            btntrangchu.Normalcolor = Color.IndianRed;
            btnthucdon.Normalcolor = Color.Transparent;
            btnnhanvien.Normalcolor = Color.Transparent;
            btnquanlikho.Normalcolor = Color.Transparent;
            btnkhachhang.Normalcolor = Color.Transparent;
            btnthongke.Normalcolor = Color.Transparent;

           
        }

        private void btnthucdon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_douong trangchu = new page_douong();
            panel2.Controls.Add(trangchu);
            btntrangchu.Normalcolor = Color.Transparent;
            btnthucdon.Normalcolor = Color.IndianRed;
            btnnhanvien.Normalcolor = Color.Transparent;
            btnquanlikho.Normalcolor = Color.Transparent;
            btnkhachhang.Normalcolor = Color.Transparent;
            btnthongke.Normalcolor = Color.Transparent;

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_nhanvien trangchu = new page_nhanvien();
            panel2.Controls.Add(trangchu);
            btntrangchu.Normalcolor = Color.Transparent;
            btnthucdon.Normalcolor = Color.Transparent;
            btnnhanvien.Normalcolor = Color.IndianRed;
            btnquanlikho.Normalcolor = Color.Transparent;
            btnkhachhang.Normalcolor = Color.Transparent;
            btnthongke.Normalcolor = Color.Transparent;
        }

       

        private void btnthongke_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_thongke trangchu = new page_thongke();
            panel2.Controls.Add(trangchu);
            btntrangchu.Normalcolor = Color.Transparent;
            btnthucdon.Normalcolor = Color.Transparent;
            btnnhanvien.Normalcolor = Color.Transparent;
            btnquanlikho.Normalcolor = Color.Transparent;
            btnkhachhang.Normalcolor = Color.Transparent;
            btnthongke.Normalcolor = Color.IndianRed;
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_khachhang trangchu = new page_khachhang();
            panel2.Controls.Add(trangchu);
            btntrangchu.Normalcolor = Color.Transparent;
            btnthucdon.Normalcolor = Color.Transparent;
            btnnhanvien.Normalcolor = Color.Transparent;
            btnquanlikho.Normalcolor = Color.Transparent;
            btnkhachhang.Normalcolor = Color.IndianRed;
            btnthongke.Normalcolor = Color.Transparent;
        }

        private void btnquanlikho_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            string[] username = label1.Text.Split(':');
            page_nguyenlieu trangchu = new page_nguyenlieu(username[1],error);
            trangchu.form = this;
            panel2.Controls.Add(trangchu);
            //btntrangchu.BackColor = Color.Transparent;
            btntrangchu.Normalcolor = Color.Transparent;
            btnthucdon.Normalcolor = Color.Transparent;
            btnnhanvien.Normalcolor = Color.Transparent;
            btnquanlikho.Normalcolor = Color.IndianRed;
            btnkhachhang.Normalcolor = Color.Transparent;
            btnthongke.Normalcolor = Color.Transparent;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlbutton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int dem = 0;
        public void phanquyen()
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                string[] username = label1.Text.Split(':');
                string user = username[1].ToString();
                Console.WriteLine(user);
                NhanVien nv = quanli.NhanViens.FirstOrDefault(p => p.TenDangNhap == user.Trim());
                int macv = (int)nv.IdChucVu;
                ChucVu cv = quanli.ChucVus.FirstOrDefault(p => p.IdChucVu == macv);
                if (cv.BanHang == false)
                    btntrangchu.Visible = false;
                else
                {
                    page_banhang trangchu = new page_banhang(username[1],null);
                    panel2.Controls.Add(trangchu);
                    dem++;
                }

                if (cv.QuanLy == false)
                    btnnhanvien.Visible = false;
                else
                {
                    if (dem == 0)
                    {
                        page_nhanvien nhanvien = new page_nhanvien();                     
                        panel2.Controls.Add(nhanvien);                 
                        dem++;
                    }
                }
                if (cv.ThongKe == false)
                    btnthongke.Visible = false;
                else
                {
                    if (dem == 0)
                    {
                       page_thongke nhanvien = new page_thongke();

                        panel2.Controls.Add(nhanvien);
                        dem++;
                    }
                }
                if (cv.Kho == false)
                {
                    btnquanlikho.Visible = false;

                }    
              
                else
                {
                    if (dem == 0)
                    {
                        page_nguyenlieu nguyenlieu = new page_nguyenlieu(username[1], erro());

                        panel2.Controls.Add(nguyenlieu);
                        dem++;                      
                    }
                }
                if (cv.KhachHang == false)
                    btnkhachhang.Visible = false;
                else
                {
                    if (dem == 0)
                    {
                        page_khachhang nhanvien = new page_khachhang();

                        panel2.Controls.Add(nhanvien);
                        dem++;
                    }
                }
            }
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {

            string[] username = label1.Text.Split(':');
            Form_DoiMatKhau doimk = new Form_DoiMatKhau(username[1]);
            doimk.ShowDialog();
        }
        public ErrorProvider erro()
        {
            return error;
        }
    

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] username = label1.Text.Split(':');

            Form_CaNhan cn = new Form_CaNhan(username[1]);
            cn.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] username = label1.Text.Split(':');
            Form_DoiMatKhau doimk = new Form_DoiMatKhau(username[1]);
            doimk.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có thật sự muốn đăng xuất !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(10);
                label1.Text = "";
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
