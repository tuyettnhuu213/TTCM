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
    public partial class Form_CTLoaiDoUong : Form
    {
        public Form_CTLoaiDoUong()
        {
            InitializeComponent();
        }
        public void loadLoaiDU()
        {
            btluu.Enabled = true;
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                DataTable table = new DataTable();
                table.Columns.Add("maloai");
                table.Columns.Add("tenloai");
                foreach (var item in quanli.LoaiDoUongs.ToList())
                {
                    table.Rows.Add(item.IdLoai, item.TenLoai);
                }
                dgvloai.DataSource = table;
            }
        }
        int mloai = 0;
        private void Form_CTLoaiDoUong_Load(object sender, EventArgs e)
        {
            loadLoaiDU();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {         
                if (txtloai.Text == "")
                {
                    MessageBox.Show("yêu cầu nhập tên loại!");
                    return;
                } else
                {
                  using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                  {
                    quanli.themloaidouong(txtloai.Text);
                    quanli.SaveChanges();
                    MessageBox.Show(this, "Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoaiDU();

                  }
                }    
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtloai.Text == "")
            {
                MessageBox.Show("yêu cầu nhập tên loại!");
                return;
            } else
            {
                using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                {
                    LoaiDoUong loai = quanli.LoaiDoUongs.FirstOrDefault(p => p.IdLoai == mloai);
                    loai.TenLoai = txtloai.Text;
                    quanli.SaveChanges();
                    MessageBox.Show(this, "Đã Lưu !", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLoaiDU();
                }    
            }
        }

        private void txtloai_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtloai_Leave(object sender, EventArgs e)
        {
          
        }

        private void dgvloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btluu.Enabled = true;         
            txtloai.Text = dgvloai.Rows[e.RowIndex].Cells["tenloai"].Value.ToString();
            txtloai.ForeColor = Color.Black;
            mloai = int.Parse(dgvloai.Rows[e.RowIndex].Cells["maloai"].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa loại đồ uống này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
                    {
                        DoUong du = quanli.DoUongs.FirstOrDefault(p => p.IdLoai == mloai);
                        if (du != null)
                        {
                            MessageBox.Show(this, "Dữ liệu đang sử dụng không thể xóa !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        LoaiDoUong loai = quanli.LoaiDoUongs.FirstOrDefault(p => p.IdLoai == mloai);
                        quanli.LoaiDoUongs.Remove(loai);
                        quanli.SaveChanges();
                        loadLoaiDU();
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
