using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuyenMon
{
    public partial class Form_GuiMail : Form
    {
        private string sukien;
        private string bd;
        private string kt;
       private string giam;
        public Form_GuiMail()
        {
            InitializeComponent();
        }
        public Form_GuiMail(string sukien, string bd, string kt, string giam)
        {
            this.Sukien = sukien;
            this.Bd = bd;
            this.Kt = kt;
            this.Giam = giam;        
            InitializeComponent();
        }

        public string Bd { get => bd; set => bd = value; }
        public string Sukien { get => sukien; set => sukien = value; }
        public string Kt { get => kt; set => kt = value; }
        public string Giam { get => giam; set => giam = value; }


        private void Form_GuiMail_Load(object sender, EventArgs e)
        {
           
            txttieude.Text = "BUBBLEMILKTEA Chào mừng sự kiện " + sukien;
            txtnoidung.Text = "Bắt đầu từ " + bd+ " đến " + kt + "\n Shenzen Milk Tea diễn ra sự kiện " +sukien + "\n Giảm giá " + giam + "% trên toàn menu. \n Hãy đến tham gia ngay";
            progressBar1.Minimum = 0;
            int sl = 0;
            using(THUCTAPCHUYENMONEntities db = new THUCTAPCHUYENMONEntities())
            {
                sl = db.KhachHangs.Count();
            }    
            progressBar1.Maximum = sl;
            label16.Text = sl.ToString();
            
        }
        string img = "";
        private void btngui_Click(object sender, EventArgs e)
        {
            if (txtnoidung.Text == "" || txttieude.Text == "" || label13.Text == "")
            {
                MessageBox.Show("cần nhập đủ tiêu đề, nội dung và hình ảnh");
            }
            else
            {
                int dem = 0;
                string ds_email = "";
                FileInfo file = new FileInfo(label13.Text);
                attachment = new Attachment(img);
                using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                {
                    List<KhachHang> kh = quanli.KhachHangs.ToList();
                    foreach (var item in kh)
                    {

                        ds_email = item.Email;
                        GuiMail(txttendangnhap, ds_email, txttieude.Text, txtnoidung.Text, attachment);
                        dem++;
                        label14.Text = dem.ToString();
                        progressBar1.Value = dem;
                    }
                }
                MessageBox.Show("Đã gửi thành công " + dem + " khách hàng!");
                btngui.Enabled = false;
            }

        }
        Attachment attachment = null;
        string txttendangnhap = "quantrasuatest@gmail.com";
        string txtmatkhau = "123456cuahang";
        void GuiMail(String from, String to, String subject, String message, Attachment attachment = null)
        {
            try
            {

                MailMessage mess = new MailMessage(from, to, subject, message);
                if (attachment != null)
                {
                    mess.Attachments.Add(attachment);
                }
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(txttendangnhap, txtmatkhau);
                client.Send(mess);

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi");
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mofile.ShowDialog(this) == DialogResult.OK)
            {
                img = mofile.FileName.ToString();
            }
            if (img == "")
                return;
            Image image = Image.FromFile(img);
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label13.Visible = false;
            label13.Text = img;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
