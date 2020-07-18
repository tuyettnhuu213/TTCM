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
    public partial class From_ThemKhachHang : Form
    {
        public From_ThemKhachHang()
        {
            InitializeComponent();
        }
        private string username;
        public string Username { get => username; set => username = value; }
        public From_ThemKhachHang(string username)
        {
            InitializeComponent();
            Username = username;
        }

        private void From_ThemKhachHang_Load(object sender, EventArgs e)
        {
            using (DatabaseQLTSEntities db = new DatabaseQLTSEntities())
            {
                List <Function_Result> khachhang = db.Function().ToList();
                txtmakhachhang.Text = khachhang[0].MAKH;
            }
            string barcode = txtmakhachhang.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = brCode.Draw(barcode, 60);
            } catch (Exception)
            {

            }
        }
        public bool kiemtra()
        {
            if( txttenkhachhang.Text == "" || txtsdt.Text == "" || txtdiachi.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập đầy đủ thông tin");
                return false;
            } 
            else
            {
                using (DatabaseQLTSEntities db = new DatabaseQLTSEntities())
                {
                    KhachHang kh = db.KhachHangs.FirstOrDefault(p => p.SDT == txtsdt.Text.Trim());
                    if (kh != null)
                    {
                        MessageBox.Show(" Số điện thoại đã tồn tại");
                        return false;
                    }
                }
                return true;
            }
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(kiemtra() == true)
            {
                using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                {

                    KhachHang kh = new KhachHang();
                    kh.DIACHI = txtdiachi.Text;
                    kh.IdKhachHang = txtmakhachhang.Text;
                    kh.TenKhachHang = txttenkhachhang.Text;
                    kh.NgayLapThe = DateTime.Now;
                    kh.SDT = txtsdt.Text;
                    kh.Email = txtemail.Text;
                    kh.DiemTichLuy = 0;
                    kh.IdLoai = 1;
                    quanli.KhachHangs.Add(kh);
                    quanli.SaveChanges();
                    MessageBox.Show("Thành công");
                    page_banhang bh = new page_banhang(username, txtmakhachhang.Text);
                    bh.Show();
                    this.Close();

                }
            }    
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
          
                page_banhang bh = new page_banhang(username, txtmakhachhang.Text);  
                bh.Show();
                this.Close();
            }
           

        }
    }
}
