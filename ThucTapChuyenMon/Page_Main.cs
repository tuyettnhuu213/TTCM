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
        public void getID(string a)
        {
            label1.Text = a;
        }
        private void Page_Main_Load(object sender, EventArgs e)
        {
            phanquyen();
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
            page_banhang trangchu = new page_banhang();
            panel2.Controls.Add(trangchu);

        }

        private void btntrangchu_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_banhang trangchu = new page_banhang();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.SeaGreen;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
           
        }

        private void btnthucdon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_douong trangchu = new page_douong();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.SeaGreen;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_nhanvien trangchu = new page_nhanvien();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.SeaGreen;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
        }

        private void btnhethong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_hethong trangchu = new page_hethong();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.SeaGreen;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_thongke trangchu = new page_thongke();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.SeaGreen;
            btnkhachhang.BackColor = Color.Transparent;
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_khachhang trangchu = new page_khachhang();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.Transparent;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.SeaGreen;
        }

        private void btnquanlikho_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            page_quanlikho trangchu = new page_quanlikho();
            panel2.Controls.Add(trangchu);
            btntrangchu.BackColor = Color.Transparent;
            btnhethong.BackColor = Color.Transparent;
            btnthucdon.BackColor = Color.Transparent;
            btnquanlikho.BackColor = Color.SeaGreen;
            btnnhanvien.BackColor = Color.Transparent;
            btnthongke.BackColor = Color.Transparent;
            btnkhachhang.BackColor = Color.Transparent;
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
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
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
                if (cv.HeThong == false)
                    btnhethong.Visible = false;
                else
                {
                    if (dem == 0)
                    {
                        page_hethong hethong = new page_hethong();
                       
                        panel2.Controls.Add(hethong);
                        dem++;
                    }
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
                        //   page_nguyenlieu nguyenlieu = new page_nguyenlieu(username[1], erro());

                        // panel2.Controls.Add(nguyenlieu);
                        // dem++;
                        page_quanlikho nhanvien = new page_quanlikho();

                        panel2.Controls.Add(nhanvien);
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
    }
}
