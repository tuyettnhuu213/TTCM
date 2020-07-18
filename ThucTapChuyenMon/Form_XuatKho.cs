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
    public partial class Form_XuatKho : Form
    {
        private string username;
        public Form_XuatKho()
        {
            InitializeComponent();
        }
        public Form_XuatKho(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public void loadNL()
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<NguyenLieu> ds_nl = quanli.NguyenLieux.ToList();
                foreach (var item in ds_nl)
                {
                    cbnguyenlieu.Items.Add(item.TenNguyenLieu);
                }
            }

        }
        private void Form_XuatKho_Load(object sender, EventArgs e)
        {
            loadNL();
            table.Columns.Add("Manl");
            table.Columns.Add("tennl");
            table.Columns.Add("DVT");
            table.Columns.Add("soluong");

        }

        private void bthem_Click(object sender, EventArgs e)
        {
            if(txtnguyenlieu.Text == "" || txtsoluong.Text == "" )
            {
                MessageBox.Show("Chọn đầy đủ thông tin");
                return;
            }    
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {

                if (cbnguyenlieu.Visible == true)
                {
                    int manl = quanli.NguyenLieux.FirstOrDefault(p => p.TenNguyenLieu == cbnguyenlieu.SelectedItem.ToString()).IdNguyenLieu;
                    foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                    {
                        if (item.Cells["manl"].Value.ToString() == manl.ToString())
                        {
                            item.Cells["slnl"].Value = float.Parse(item.Cells["slnl"].Value.ToString()) + float.Parse(txtsoluong.Text);
                            return;
                        }
                    }
                    table.Rows.Add(manl, cbnguyenlieu.SelectedItem.ToString(), txtdvt.Text, txtsoluong.Text);
                }
                else
                {
                    foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                    {
                        if (item.Cells["tennl"].Value.ToString() == txtnguyenlieu.Text)
                        {
                            item.Cells["slnl"].Value = float.Parse(item.Cells["slnl"].Value.ToString()) + float.Parse(txtsoluong.Text);
                            return;
                        }
                    }
                    int manl = quanli.NguyenLieux.Max(p => p.IdNguyenLieu) + 1;
                    table.Rows.Add(manl, txtnguyenlieu.Text, txtdvt.Text, txtsoluong.Text);
                }
            }
            dgvnguyenlieu.DataSource = table;
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            cbnguyenlieu.Visible = true;
            cbnguyenlieu.SelectedIndex = -1;
            txtsoluong.Text = "";
            txtdvt.Text = "";
        }

        private void cbnguyenlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbnguyenlieu.SelectedIndex == -1)
                return;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                txtdvt.Enabled = false;
                txtdvt.Text = quanli.NguyenLieux.FirstOrDefault(p => p.TenNguyenLieu == cbnguyenlieu.SelectedItem.ToString()).DonViTinh;
                txttonkho.Text = quanli.NguyenLieux.FirstOrDefault(p => p.TenNguyenLieu == cbnguyenlieu.SelectedItem.ToString()).SoLuong.ToString();
            }
        }

        private void bttach_Click(object sender, EventArgs e)
        {
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                PhieuXuat px = new PhieuXuat();
                px.TenDangNhap = username.Trim();
                px.ThoiGianLap = DateTime.Now;
                quanli.PhieuXuats.Add(px);
                quanli.SaveChanges();
                foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                {
                    int manl = int.Parse(item.Cells["manl"].Value.ToString());
                    NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                    if (nl != null)
                    {
                        nl.SoLuong = nl.SoLuong - float.Parse(item.Cells["slnl"].Value.ToString());
                        quanli.SaveChanges();
                    }

                    CTPhieuXuat ct = new CTPhieuXuat();
                    ct.IdPhieuXuat = px.IdPhieuXuat;
                    ct.IdNguyenLieu = manl;
                    ct.SoLuong = float.Parse(item.Cells["slnl"].Value.ToString());
                    quanli.CTPhieuXuats.Add(ct);
                    quanli.SaveChanges();
                }
                MessageBox.Show("Đã Xuất !");
                this.Close();

            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
