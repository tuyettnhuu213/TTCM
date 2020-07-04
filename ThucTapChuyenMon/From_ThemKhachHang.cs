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
        
        private void From_ThemKhachHang_Load(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
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
                using (THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
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
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {

                    quanli.ThemKhachHang(txtmakhachhang.Text, txttenkhachhang.Text, txtsdt.Text, txtsdt.Text, txtemail.Text);
                    quanli.SaveChanges();
                    MessageBox.Show("Thành công");
                    this.Close();

                }
            }    
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát? ","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
            
        }
    }
}
