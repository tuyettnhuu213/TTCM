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
            this.RPhoadonTableAdapter.Fill(this.DataSetHoaDon.RPhoadon,mahd);
            this.reportViewer1.RefreshReport();
        }
        
    }
}
