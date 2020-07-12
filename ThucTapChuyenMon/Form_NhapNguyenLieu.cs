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
    public partial class Form_NhapNguyenLieu : Form
    {
        private string username;
        public Form_NhapNguyenLieu()
        {
            InitializeComponent();
        }
        public string Username { get => username; set => username = value; }
        public Form_NhapNguyenLieu(string username)
        {
            this.username = username;
            InitializeComponent();
        }
        public void loadNL()
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                List<NguyenLieu> ds_nl = quanli.NguyenLieux.ToList();
                foreach (var item in ds_nl)
                {
                    cbnguyenlieu.Items.Add(item.TenNguyenLieu);
                }
            }

        }
        DataTable table = new DataTable();
        private void Form_NhapNguyenLieu_Load(object sender, EventArgs e)
        {         
            loadNL();
            table.Columns.Add("Manl");
            table.Columns.Add("tennl");
            table.Columns.Add("DVT");
            table.Columns.Add("soluong");
            table.Columns.Add("gianhap");
         
        }

        private void bthem_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {

                if (cbnguyenlieu.Visible == true)
                {
                    int manl = quanli.NguyenLieux.FirstOrDefault(p => p.TenNguyenLieu == cbnguyenlieu.SelectedItem.ToString()).IdNguyenLieu;
                    foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                    {
                        if (item.Cells["manl"].Value.ToString() == manl.ToString())
                        {
                            item.Cells["slnl"].Value = double.Parse(item.Cells["slnl"].Value.ToString()) + double.Parse(txtsoluong.Text);
                            return;
                        }
                    }
                    table.Rows.Add(manl, cbnguyenlieu.SelectedItem.ToString(), txtdvt.Text, txtsoluong.Text, txtgia.Text);
                }
                else
                {
                    foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                    {
                        if (item.Cells["tennl"].Value.ToString() == txtnguyenlieu.Text)
                        {
                            item.Cells["slnl"].Value = double.Parse(item.Cells["slnl"].Value.ToString()) + double.Parse(txtsoluong.Text);
                            return;
                        }
                    }
                    int manl = quanli.NguyenLieux.Max(p => p.IdNguyenLieu) + 1;
                    table.Rows.Add(manl, txtnguyenlieu.Text, txtdvt.Text, txtsoluong.Text, txtgia.Text);
                }
            }
            dgvnguyenlieu.DataSource = table;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            cbnguyenlieu.Visible = true;
            cbnguyenlieu.SelectedIndex = -1;
            txtsoluong.Text = "";
            txtgia.Text = "";
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtdvt.Enabled = true;
            txtdvt.Text = "";
            cbnguyenlieu.Visible = false;
            txtsoluong.Text = "";
            txtgia.Text = "";
        }

        private void bttach_Click(object sender, EventArgs e)
        {
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                PhieuNhap pn = new PhieuNhap();
                quanli.PhieuNhaps.Add(pn);
                foreach (DataGridViewRow item in dgvnguyenlieu.Rows)
                {
                    int manl = int.Parse(item.Cells["manl"].Value.ToString());
                    NguyenLieu nl = quanli.NguyenLieux.FirstOrDefault(p => p.IdNguyenLieu == manl);
                    if (nl != null)
                    {
                        nl.SoLuong = nl.SoLuong + float.Parse(item.Cells["slnl"].Value.ToString());
                        quanli.SaveChanges();
                    }
                    else
                    {
                        nl = new NguyenLieu();
                        nl.IdNguyenLieu = manl;
                        nl.TenNguyenLieu = item.Cells["tennl"].Value.ToString();
                        nl.SoLuong = double.Parse(item.Cells["slnl"].Value.ToString());
                        nl.DonViTinh = item.Cells["dvt"].Value.ToString();
                        quanli.NguyenLieux.Add(nl);
                        quanli.SaveChanges();
                    }

                    CTPhieuNhap ct = new CTPhieuNhap();
                    ct.IdPhieuNhap = pn.IdPhieuNhap;
                    ct.IdNguyenLieu = manl;
                    ct.SoLuong = double.Parse(item.Cells["slnl"].Value.ToString());
                    ct.DonGia = int.Parse(item.Cells["gianhap"].Value.ToString());
                    quanli.CTPhieuNhaps.Add(ct);
                    quanli.SaveChanges();
                }
                int tongtien = 0;
                for (int i = 0; i < dgvnguyenlieu.Rows.Count; i++)
                {
                    tongtien += (int.Parse(dgvnguyenlieu.Rows[i].Cells["slnl"].Value.ToString()) * int.Parse(dgvnguyenlieu.Rows[i].Cells["gianhap"].Value.ToString()));
                }
                PhieuNhap phieunhap = quanli.PhieuNhaps.Where(p => p.IdPhieuNhap == pn.IdPhieuNhap).FirstOrDefault();
                phieunhap.ThoiGianLap = DateTime.Now;
                phieunhap.TenDangNhap = username.Trim();
                phieunhap.TongTien = tongtien;
                quanli.SaveChanges();   
                MessageBox.Show("Đã Nhập !");
                this.Close();
            }
        }

        private void cbnguyenlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbnguyenlieu.SelectedIndex == -1)
                return;
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
            {
                txtdvt.Enabled = false;
                txtdvt.Text = quanli.NguyenLieux.FirstOrDefault(p => p.TenNguyenLieu == cbnguyenlieu.SelectedItem.ToString()).DonViTinh;
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
