namespace ThucTapChuyenMon
{
    partial class Form_ThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDon1 = new ThucTapChuyenMon.HoaDon1();
            this.RPhoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPhoadonTableAdapter = new ThucTapChuyenMon.HoaDon1TableAdapters.RPhoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPhoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HoaDon";
            reportDataSource1.Value = this.RPhoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThucTapChuyenMon.Report_HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-3, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(583, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDon1
            // 
            this.HoaDon1.DataSetName = "HoaDon1";
            this.HoaDon1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPhoadonBindingSource
            // 
            this.RPhoadonBindingSource.DataMember = "RPhoadon";
            this.RPhoadonBindingSource.DataSource = this.HoaDon1;
            // 
            // RPhoadonTableAdapter
            // 
            this.RPhoadonTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 764);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ThanhToan";
            this.Load += new System.EventHandler(this.Form_ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPhoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPhoadonBindingSource;
        private HoaDon1 HoaDon1;
        private HoaDon1TableAdapters.RPhoadonTableAdapter RPhoadonTableAdapter;
    }
}