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
    public partial class Form_ThanhToan : Form
    {
        private int mahd;
        public Form_ThanhToan()
        {
            InitializeComponent();
        }
        public Form_ThanhToan(int mahd)
        {
            this.mahd = mahd;
            InitializeComponent();
        }
        public int Mahd { get => mahd; set => mahd = value; }

        private void Form_ThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDon1.RPhoadon' table. You can move, or remove it, as needed.
            this.RPhoadonTableAdapter.Fill(this.HoaDon1.RPhoadon, mahd);

            this.reportViewer1.RefreshReport();
        }

    }
}
