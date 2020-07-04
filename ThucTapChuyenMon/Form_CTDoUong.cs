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
    public partial class Form_CTDoUong : Form
    {
        private int masp;
        public Form_CTDoUong()
        {
            InitializeComponent();
        }
        public int Masp { get => masp; set => masp = value; }
        public Form_CTDoUong(int masp)
        {
   
            Masp = masp;
            InitializeComponent();
        }
        public void loadchitiet()
        {
            btluu.Enabled = false;
           
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("size");
                table.Columns.Add("gia");
                foreach (var item in quanli.CTDoUongs.Where(p => p.IdDoUong == masp).ToList())
                {
                    table.Rows.Add(item.Size, item.DonGia);
                }
                dgvloai.DataSource = table;
            }
        }
        private void Form_CTDoUong_Load(object sender, EventArgs e)
        {
            loadchitiet();
            txtsize.Focus();
        }
        void reset()
        {
            btluu.Enabled = false;
            txtgia.Text = "";
            txtsize.Text = "";
        }
        private void txtgia_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtgia_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtsize_Enter(object sender, EventArgs e)
        {          
        }

        private void txtsize_Leave(object sender, EventArgs e)
        {
           
        }
        public void Them()
        {
            if (txtgia.Text.Trim() == "")
            {
                MessageBox.Show("yêu cầu nhập giá sản phẩm!");
                return;
            }
            if (txtsize.Text.Trim() == "")
            {
                MessageBox.Show("yêu cầu nhập size!");
                return;
            }
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                CTDoUong ct = new CTDoUong();
                ct.IdDoUong = masp;
                ct.Size = txtsize.Text;
                int gia = int.Parse(txtgia.Text);
                ct.DonGia = gia;
                quanli.CTDoUongs.Add(ct);
                quanli.SaveChanges();
                MessageBox.Show("Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadchitiet();
                reset();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them();     
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                if (txtgia.Text.Trim() == "")
                {
                    MessageBox.Show("yêu cầu nhập giá sản phầm !");
                    return;
                }            
                CTDoUong loai = quanli.CTDoUongs.FirstOrDefault(p => p.IdDoUong == masp && p.Size == txtsize.Text);
                int dongia = int.Parse(txtgia.Text);
                loai.DonGia = dongia;
                quanli.SaveChanges();
                MessageBox.Show("Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadchitiet();
                reset();
            }
        }

        private void dgvloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btluu.Enabled = true;
            lbsize.Visible = false;
            txtsize.Visible = false;
            btnthem.Text = "Làm Mới";
            txtgia.Text = dgvloai.Rows[e.RowIndex].Cells["gia"].Value.ToString();
            txtgia.ForeColor = Color.Black;
            string size = dgvloai.Rows[e.RowIndex].Cells["size"].Value.ToString();
            txtsize.Text = size;
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa đồ uống này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
                    {
                        CTHoaDon ct_hd = quanli.CTHoaDons.FirstOrDefault(p => p.IdDoUong == masp && p.Size == size);
                        if (ct_hd != null)
                        {
                            MessageBox.Show(this, "Dữ liệu đang sử dụng không thể xóa !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        CTDoUong ct_du = quanli.CTDoUongs.FirstOrDefault(p => p.IdDoUong == masp && p.Size == size);
                        quanli.CTDoUongs.Remove(ct_du);
                        quanli.SaveChanges();
                        loadchitiet();
                        reset();
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgia_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
