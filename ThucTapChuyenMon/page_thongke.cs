using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapChuyenMon
{
    public partial class page_thongke : UserControl
    {
        public page_thongke()
        {
            InitializeComponent();
        }

        private void page_thongke_Load(object sender, EventArgs e)
        {
            btnhoadon.IconVisible = true;
            viewluong.IconVisible = true;

            doanhso.ChartAreas["doanh số"].AxisX.Maximum = 12.5;
            doanhso.ChartAreas["doanh số"].AxisX.Minimum = 0;

            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                List<HoaDon> ds_hoadon = quanli.HoaDons.ToList();
                foreach (var item in ds_hoadon)
                {
                    if(item.ThoiGianLap != null)
                    {
                        int dem = 0;
                        foreach (var nam in cbnam.Items)
                        {

                            if (nam.ToString() == item.ThoiGianLap.Value.Year.ToString())
                            {
                                dem++;
                                break;
                            }
                        }
                        if (dem == 0)
                            cbnam.Items.Add(item.ThoiGianLap.Value.Year.ToString());
                    }
                    
                }
            }
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                if (rbngay.Checked)
                {
                    this.RPHoaDonNgayTableAdapter.Fill(this.HoaDonNgay1.RPHoaDonNgay, dtngay.Value);
                    this.reporthoadonngay.RefreshReport();
                    reporthoadonngay.Visible = true;
                    reporthoadonthang.Visible = false;
                    reportphieunhapngay.Visible = false;
                    reportphieunhapthang.Visible = false;
                    reportphieuxuatngay.Visible = false;
                    reportphieuxuatthang.Visible = false;         
                } 
                if(rbthang.Checked)
                {
                    this.RPHoaDonThangTableAdapter.Fill(this.HoaDonThang1.RPHoaDonThang, dtngay.Value.Month,dtngay.Value.Year);
                    this.reporthoadonthang.RefreshReport();
                    reporthoadonngay.Visible = false;
                    reporthoadonthang.Visible = true;
                    reportphieunhapngay.Visible = false;
                    reportphieunhapthang.Visible = false;
                    reportphieuxuatngay.Visible = false;
                    reportphieuxuatthang.Visible = false;
                }    
          
            } 
            if(comboBox1.SelectedIndex == 1)
            {
                if(rbthang.Checked)
                {
                    this.RPPhieuNhapThangTableAdapter.Fill(PhieuNhapThangDataSet.RPPhieuNhapThang, dtngay.Value.Month, dtngay.Value.Year);
                    this.reportphieunhapthang.RefreshReport();
                    reporthoadonngay.Visible = false;
                    reporthoadonthang.Visible = false;
                    reportphieunhapngay.Visible = false;
                    reportphieunhapthang.Visible = true;
                    reportphieuxuatngay.Visible = false;
                    reportphieuxuatthang.Visible = false;
                }   
                if(rbngay.Checked)
                {
                    this.RPPhieuNhapNgayTableAdapter.Fill(PhieuNhapNgay1.RPPhieuNhapNgay, dtngay.Value);
                    this.reportphieunhapngay.RefreshReport();
                    reporthoadonngay.Visible = false;
                    reporthoadonthang.Visible = false;
                    reportphieunhapngay.Visible = true;
                    reportphieunhapthang.Visible = false;
                    reportphieuxuatngay.Visible = false;
                    reportphieuxuatthang.Visible = false;

                }    
            }    

            if(comboBox1.SelectedIndex == 2)
            {
                if(rbthang.Checked)
                {
                    this.RPPhieuXuatMonthTableAdapter.Fill(this.PhieuXuatThang1.RPPhieuXuatMonth, dtngay.Value.Month, dtngay.Value.Year);
                    this.reportphieuxuatthang.RefreshReport();
                    reporthoadonngay.Visible = false;
                    reporthoadonthang.Visible = false;
                    reportphieunhapngay.Visible = false;
                    reportphieunhapthang.Visible = false;
                    reportphieuxuatngay.Visible = false;
                    reportphieuxuatthang.Visible = true;
                }
                if(rbngay.Checked)
                {
                    this.RPPhieuXuatNgayTableAdapter.Fill(this.PhieuXuatNgay1.RPPhieuXuatNgay, dtngay.Value);
                    this.reportphieuxuatngay.RefreshReport();
                    reporthoadonngay.Visible = false;
                    reporthoadonthang.Visible = false;
                    reportphieunhapngay.Visible = false;
                    reportphieunhapthang.Visible = false;
                    reportphieuxuatngay.Visible = true;
                    reportphieuxuatthang.Visible = false;
                }
            }
        }

        private void rbngay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbngay_Click(object sender, EventArgs e)
        {
            dtngay.CustomFormat = "dd/MM/yyyy";
        }

        private void rbthang_Click(object sender, EventArgs e)
        {
            dtngay.CustomFormat = "MM/yyyy";
        }

        private void viewluong_Click(object sender, EventArgs e)
        {
            if (cbnam.SelectedIndex == -1)
                return;
            int nam = int.Parse(cbnam.SelectedItem.ToString());
            using (DatabaseQLTSEntities quanli = new DatabaseQLTSEntities())
            {
                doanhso.Visible = true;
                List<doanhso_Result> ds_doanhso = quanli.doanhso(nam).ToList();
                foreach (var item in ds_doanhso)
                {
                    doanhso.Series["doanh số"].Points.AddXY(item.Thang, item.DoanhSo);
                }
            }
        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
    }
}
