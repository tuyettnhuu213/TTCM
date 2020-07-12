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

            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
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
                    this.RPHoaDonNgayTableAdapter.Fill(this.HoaDonNgayDataSet.RPHoaDonNgay, dtngay.Value);
                    this.reportViewer1.RefreshReport();
                    reportViewer1.Visible = true;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = false;
                    reportPhieuNhapNgay.Visible = false;
                    reportHoaDonThang.Visible = false;
                    reportPhieuNhapThang.Visible = false;
                } 
                if(rbthang.Checked)
                {
                    this.RPHoaDonThangTableAdapter.Fill(this.HoaDonThangDataSet.RPHoaDonThang, dtngay.Value.Month,dtngay.Value.Year);
                    this.reportHoaDonThang.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = false;
                    reportPhieuNhapNgay.Visible = false;
                    reportHoaDonThang.Visible = true;
                    reportPhieuNhapThang.Visible = false;
                }    
          
            } 
            if(comboBox1.SelectedIndex == 1)
            {
                if(rbthang.Checked)
                {
                    this.RPPhieuNhapThangTableAdapter.Fill(PhieuNhapThangDataSet.RPPhieuNhapThang, dtngay.Value.Month, dtngay.Value.Year);
                    this.reportPhieuNhapNgay.RefreshReport();                 
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = false;
                    reportPhieuNhapNgay.Visible = true;
                    reportHoaDonThang.Visible = false;
                    reportPhieuNhapThang.Visible = false;
                }   
                if(rbngay.Checked)
                {
                    this.RPPhieuNhapNgayTableAdapter.Fill(PhieuNhapNgayDataSet.RPPhieuNhapNgay, dtngay.Value);
                    this.reportPhieuNhapThang.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = false;
                    reportPhieuNhapNgay.Visible = false;
                    reportHoaDonThang.Visible = false;
                    reportPhieuNhapThang.Visible = true;

                }    
            }    

            if(comboBox1.SelectedIndex == 2)
            {
                if(rbthang.Checked)
                {
                    this.RPPhieuXuatMonthTableAdapter.Fill(this.PhieuXuatThangDataSet.RPPhieuXuatMonth, dtngay.Value.Month, dtngay.Value.Year);
                    this.reportViewer2.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = true;
                    reportViewer3.Visible = false;
                    reportPhieuNhapNgay.Visible = false;
                    reportHoaDonThang.Visible = false;
                    reportPhieuNhapThang.Visible = false;
                }
                if(rbngay.Checked)
                {
                    this.RPPhieuXuatNgayTableAdapter.Fill(this.PhieuXuatNgayDataSet.RPPhieuXuatNgay, dtngay.Value);
                    this.reportViewer3.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = true;
                    reportPhieuNhapNgay.Visible = false;
                    reportHoaDonThang.Visible = false;
                    reportPhieuNhapThang.Visible = false;
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
            using (THUCTAPCHUYENMONEntities quanli = new THUCTAPCHUYENMONEntities())
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
    }
}
