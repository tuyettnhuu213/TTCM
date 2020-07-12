namespace ThucTapChuyenMon
{
    partial class page_khachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_khachhang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rdThanhVien = new System.Windows.Forms.RadioButton();
            this.rdNone = new System.Windows.Forms.RadioButton();
            this.rdDong = new System.Windows.Forms.RadioButton();
            this.rdBac = new System.Windows.Forms.RadioButton();
            this.rdVang = new System.Windows.Forms.RadioButton();
            this.btnThemKH = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.dgvkhachhang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTichLuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dgvloaithetv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IdLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTOITHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtDTT = new System.Windows.Forms.TextBox();
            this.txtLoaithe = new System.Windows.Forms.TextBox();
            this.btnHuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaithetv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1442, 720);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1442, 720);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Quản lí khách hàng";
            this.tabPane1.Click += new System.EventHandler(this.tabPane1_Click);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Quản lí khách hàng";
            this.tabNavigationPage1.Controls.Add(this.bunifuImageButton4);
            this.tabNavigationPage1.Controls.Add(this.txtsearch);
            this.tabNavigationPage1.Controls.Add(this.rdThanhVien);
            this.tabNavigationPage1.Controls.Add(this.rdNone);
            this.tabNavigationPage1.Controls.Add(this.rdDong);
            this.tabNavigationPage1.Controls.Add(this.rdBac);
            this.tabNavigationPage1.Controls.Add(this.rdVang);
            this.tabNavigationPage1.Controls.Add(this.btnThemKH);
            this.tabNavigationPage1.Controls.Add(this.btnView);
            this.tabNavigationPage1.Controls.Add(this.radioGroup1);
            this.tabNavigationPage1.Controls.Add(this.dgvkhachhang);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tabNavigationPage1.ImageOptions.SvgImage")));
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(1442, 655);
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = global::ThucTapChuyenMon.Properties.Resources.search__1_;
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(761, 127);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(61, 36);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 22;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 15;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BorderColorFocused = System.Drawing.Color.CornflowerBlue;
            this.txtsearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtsearch.BorderThickness = 3;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsearch.ForeColor = System.Drawing.Color.Gray;
            this.txtsearch.isPassword = false;
            this.txtsearch.Location = new System.Drawing.Point(110, 130);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(642, 32);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // rdThanhVien
            // 
            this.rdThanhVien.AutoSize = true;
            this.rdThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.rdThanhVien.Location = new System.Drawing.Point(1008, 46);
            this.rdThanhVien.Name = "rdThanhVien";
            this.rdThanhVien.Size = new System.Drawing.Size(131, 29);
            this.rdThanhVien.TabIndex = 15;
            this.rdThanhVien.TabStop = true;
            this.rdThanhVien.Text = "Thành viên";
            this.rdThanhVien.UseVisualStyleBackColor = false;
            // 
            // rdNone
            // 
            this.rdNone.AutoSize = true;
            this.rdNone.BackColor = System.Drawing.Color.Transparent;
            this.rdNone.Location = new System.Drawing.Point(854, 46);
            this.rdNone.Name = "rdNone";
            this.rdNone.Size = new System.Drawing.Size(88, 29);
            this.rdNone.TabIndex = 14;
            this.rdNone.TabStop = true;
            this.rdNone.Text = "Tất cả";
            this.rdNone.UseVisualStyleBackColor = false;
            // 
            // rdDong
            // 
            this.rdDong.AutoSize = true;
            this.rdDong.BackColor = System.Drawing.Color.Transparent;
            this.rdDong.Location = new System.Drawing.Point(711, 46);
            this.rdDong.Name = "rdDong";
            this.rdDong.Size = new System.Drawing.Size(80, 29);
            this.rdDong.TabIndex = 13;
            this.rdDong.TabStop = true;
            this.rdDong.Text = "Đồng";
            this.rdDong.UseVisualStyleBackColor = false;
            // 
            // rdBac
            // 
            this.rdBac.AutoSize = true;
            this.rdBac.BackColor = System.Drawing.Color.Transparent;
            this.rdBac.Location = new System.Drawing.Point(576, 46);
            this.rdBac.Name = "rdBac";
            this.rdBac.Size = new System.Drawing.Size(67, 29);
            this.rdBac.TabIndex = 12;
            this.rdBac.TabStop = true;
            this.rdBac.Text = "Bạc";
            this.rdBac.UseVisualStyleBackColor = false;
            // 
            // rdVang
            // 
            this.rdVang.AutoSize = true;
            this.rdVang.BackColor = System.Drawing.Color.Transparent;
            this.rdVang.Location = new System.Drawing.Point(448, 46);
            this.rdVang.Name = "rdVang";
            this.rdVang.Size = new System.Drawing.Size(80, 29);
            this.rdVang.TabIndex = 11;
            this.rdVang.TabStop = true;
            this.rdVang.Text = "Vàng";
            this.rdVang.UseVisualStyleBackColor = false;
            // 
            // btnThemKH
            // 
            this.btnThemKH.Activecolor = System.Drawing.Color.LightPink;
            this.btnThemKH.BackColor = System.Drawing.Color.IndianRed;
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKH.BorderRadius = 0;
            this.btnThemKH.ButtonText = "Thêm";
            this.btnThemKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKH.DisabledColor = System.Drawing.Color.Gray;
            this.btnThemKH.ForeColor = System.Drawing.Color.White;
            this.btnThemKH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThemKH.Iconimage = global::ThucTapChuyenMon.Properties.Resources.plus;
            this.btnThemKH.Iconimage_right = null;
            this.btnThemKH.Iconimage_right_Selected = null;
            this.btnThemKH.Iconimage_Selected = null;
            this.btnThemKH.IconMarginLeft = 0;
            this.btnThemKH.IconMarginRight = 0;
            this.btnThemKH.IconRightVisible = false;
            this.btnThemKH.IconRightZoom = 0D;
            this.btnThemKH.IconVisible = false;
            this.btnThemKH.IconZoom = 52D;
            this.btnThemKH.IsTab = false;
            this.btnThemKH.Location = new System.Drawing.Point(51, 25);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(8);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnThemKH.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnThemKH.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThemKH.selected = false;
            this.btnThemKH.Size = new System.Drawing.Size(178, 63);
            this.btnThemKH.TabIndex = 7;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemKH.Textcolor = System.Drawing.Color.White;
            this.btnThemKH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnView
            // 
            this.btnView.Activecolor = System.Drawing.Color.LightPink;
            this.btnView.BackColor = System.Drawing.Color.IndianRed;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.BorderRadius = 0;
            this.btnView.ButtonText = "Xem";
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DisabledColor = System.Drawing.Color.Gray;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnView.Iconimage = global::ThucTapChuyenMon.Properties.Resources.eye;
            this.btnView.Iconimage_right = null;
            this.btnView.Iconimage_right_Selected = null;
            this.btnView.Iconimage_Selected = null;
            this.btnView.IconMarginLeft = 0;
            this.btnView.IconMarginRight = 0;
            this.btnView.IconRightVisible = false;
            this.btnView.IconRightZoom = 0D;
            this.btnView.IconVisible = false;
            this.btnView.IconZoom = 50D;
            this.btnView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnView.IsTab = false;
            this.btnView.Location = new System.Drawing.Point(1177, 34);
            this.btnView.Margin = new System.Windows.Forms.Padding(9);
            this.btnView.Name = "btnView";
            this.btnView.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnView.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnView.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnView.selected = false;
            this.btnView.Size = new System.Drawing.Size(172, 54);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Xem";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView.Textcolor = System.Drawing.Color.Transparent;
            this.btnView.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(428, 34);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.radioGroup1.Size = new System.Drawing.Size(728, 54);
            this.radioGroup1.TabIndex = 10;
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvkhachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvkhachhang.BackgroundColor = System.Drawing.Color.White;
            this.dgvkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvkhachhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvkhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKhachHang,
            this.TenKhachHang,
            this.DiaChi,
            this.SDT,
            this.TenLoai,
            this.DiemTichLuy,
            this.sua});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkhachhang.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvkhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvkhachhang.DoubleBuffered = true;
            this.dgvkhachhang.EnableHeadersVisualStyles = false;
            this.dgvkhachhang.GridColor = System.Drawing.Color.Black;
            this.dgvkhachhang.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.dgvkhachhang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvkhachhang.Location = new System.Drawing.Point(0, 190);
            this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.ReadOnly = true;
            this.dgvkhachhang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvkhachhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dgvkhachhang.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvkhachhang.RowTemplate.Height = 30;
            this.dgvkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkhachhang.ShowCellErrors = false;
            this.dgvkhachhang.ShowRowErrors = false;
            this.dgvkhachhang.Size = new System.Drawing.Size(1442, 465);
            this.dgvkhachhang.TabIndex = 9;
            this.dgvkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellContentClick);
            // 
            // IdKhachHang
            // 
            this.IdKhachHang.DataPropertyName = "IdKhachHang";
            this.IdKhachHang.HeaderText = "Id Khách Hàng";
            this.IdKhachHang.MinimumWidth = 6;
            this.IdKhachHang.Name = "IdKhachHang";
            this.IdKhachHang.ReadOnly = true;
            this.IdKhachHang.Width = 125;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên KH";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Loại thẻ";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // DiemTichLuy
            // 
            this.DiemTichLuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTichLuy.DataPropertyName = "DiemTichLuy";
            this.DiemTichLuy.HeaderText = "Điểm tích lũy";
            this.DiemTichLuy.MinimumWidth = 6;
            this.DiemTichLuy.Name = "DiemTichLuy";
            this.DiemTichLuy.ReadOnly = true;
            // 
            // sua
            // 
            this.sua.DataPropertyName = "sua";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Red;
            this.sua.DefaultCellStyle = dataGridViewCellStyle14;
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sua.HeaderText = "  Sửa";
            this.sua.MinimumWidth = 6;
            this.sua.Name = "sua";
            this.sua.ReadOnly = true;
            this.sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sua.Text = "Sửa";
            this.sua.UseColumnTextForButtonValue = true;
            this.sua.Width = 60;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Quản lí loại khách hàng";
            this.tabNavigationPage2.Controls.Add(this.label10);
            this.tabNavigationPage2.Controls.Add(this.txtMa);
            this.tabNavigationPage2.Controls.Add(this.dgvloaithetv);
            this.tabNavigationPage2.Controls.Add(this.label9);
            this.tabNavigationPage2.Controls.Add(this.label8);
            this.tabNavigationPage2.Controls.Add(this.label7);
            this.tabNavigationPage2.Controls.Add(this.txtGiamGia);
            this.tabNavigationPage2.Controls.Add(this.txtDTT);
            this.tabNavigationPage2.Controls.Add(this.txtLoaithe);
            this.tabNavigationPage2.Controls.Add(this.btnHuy);
            this.tabNavigationPage2.Controls.Add(this.btnSua);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.ImageOptions.Image = global::ThucTapChuyenMon.Properties.Resources.pay;
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(1442, 655);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(876, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 25);
            this.label10.TabIndex = 85;
            this.label10.Text = "Mã";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(1042, 77);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(177, 30);
            this.txtMa.TabIndex = 84;
            // 
            // dgvloaithetv
            // 
            this.dgvloaithetv.AllowUserToAddRows = false;
            this.dgvloaithetv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvloaithetv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvloaithetv.BackgroundColor = System.Drawing.Color.White;
            this.dgvloaithetv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvloaithetv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloaithetv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvloaithetv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaithetv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLoai,
            this.DIEMTOITHIEU,
            this.GIAMGIA,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloaithetv.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvloaithetv.DoubleBuffered = true;
            this.dgvloaithetv.EnableHeadersVisualStyles = false;
            this.dgvloaithetv.GridColor = System.Drawing.Color.Black;
            this.dgvloaithetv.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.dgvloaithetv.HeaderForeColor = System.Drawing.Color.White;
            this.dgvloaithetv.Location = new System.Drawing.Point(53, 82);
            this.dgvloaithetv.Margin = new System.Windows.Forms.Padding(4);
            this.dgvloaithetv.Name = "dgvloaithetv";
            this.dgvloaithetv.ReadOnly = true;
            this.dgvloaithetv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloaithetv.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvloaithetv.RowHeadersWidth = 51;
            this.dgvloaithetv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvloaithetv.RowTemplate.Height = 30;
            this.dgvloaithetv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloaithetv.ShowCellErrors = false;
            this.dgvloaithetv.ShowRowErrors = false;
            this.dgvloaithetv.Size = new System.Drawing.Size(766, 310);
            this.dgvloaithetv.TabIndex = 83;
            this.dgvloaithetv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaithetv_CellContentClick);
            // 
            // IdLoai
            // 
            this.IdLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdLoai.DataPropertyName = "IdLoai";
            this.IdLoai.HeaderText = "Id Loại";
            this.IdLoai.MinimumWidth = 6;
            this.IdLoai.Name = "IdLoai";
            this.IdLoai.ReadOnly = true;
            // 
            // DIEMTOITHIEU
            // 
            this.DIEMTOITHIEU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIEMTOITHIEU.DataPropertyName = "DiemToiThieu";
            this.DIEMTOITHIEU.HeaderText = "Điểm tối thiểu";
            this.DIEMTOITHIEU.MinimumWidth = 6;
            this.DIEMTOITHIEU.Name = "DIEMTOITHIEU";
            this.DIEMTOITHIEU.ReadOnly = true;
            // 
            // GIAMGIA
            // 
            this.GIAMGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIAMGIA.DataPropertyName = "GiamGia";
            this.GIAMGIA.HeaderText = "Giảm giá";
            this.GIAMGIA.MinimumWidth = 6;
            this.GIAMGIA.Name = "GIAMGIA";
            this.GIAMGIA.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.DataPropertyName = "sua";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Sửa";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "Sửa";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Loại thẻ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Điểm tối thiểu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(876, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(1042, 201);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(177, 30);
            this.txtGiamGia.TabIndex = 77;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // txtDTT
            // 
            this.txtDTT.Location = new System.Drawing.Point(1042, 160);
            this.txtDTT.Name = "txtDTT";
            this.txtDTT.Size = new System.Drawing.Size(177, 30);
            this.txtDTT.TabIndex = 76;
            this.txtDTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDTT_KeyPress);
            // 
            // txtLoaithe
            // 
            this.txtLoaithe.Enabled = false;
            this.txtLoaithe.Location = new System.Drawing.Point(1042, 119);
            this.txtLoaithe.Name = "txtLoaithe";
            this.txtLoaithe.Size = new System.Drawing.Size(177, 30);
            this.txtLoaithe.TabIndex = 75;
            // 
            // btnHuy
            // 
            this.btnHuy.Activecolor = System.Drawing.Color.LightPink;
            this.btnHuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.ButtonText = "Trở về";
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuy.Iconimage = global::ThucTapChuyenMon.Properties.Resources._return;
            this.btnHuy.Iconimage_right = null;
            this.btnHuy.Iconimage_right_Selected = null;
            this.btnHuy.Iconimage_Selected = null;
            this.btnHuy.IconMarginLeft = 0;
            this.btnHuy.IconMarginRight = 0;
            this.btnHuy.IconRightVisible = false;
            this.btnHuy.IconRightZoom = 0D;
            this.btnHuy.IconVisible = false;
            this.btnHuy.IconZoom = 50D;
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnHuy.IsTab = false;
            this.btnHuy.Location = new System.Drawing.Point(1104, 312);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnHuy.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnHuy.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHuy.selected = false;
            this.btnHuy.Size = new System.Drawing.Size(212, 75);
            this.btnHuy.TabIndex = 82;
            this.btnHuy.Text = "Trở về";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuy.Textcolor = System.Drawing.Color.White;
            this.btnHuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.LightPink;
            this.btnSua.BackColor = System.Drawing.Color.IndianRed;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Lưu";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Black;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::ThucTapChuyenMon.Properties.Resources.save__1_;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = false;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = false;
            this.btnSua.IconZoom = 50D;
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(858, 312);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnSua.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(216, 75);
            this.btnSua.TabIndex = 81;
            this.btnSua.Text = "Lưu";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // page_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "page_khachhang";
            this.Size = new System.Drawing.Size(1442, 720);
            this.Load += new System.EventHandler(this.page_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaithetv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.RadioButton rdNone;
        private System.Windows.Forms.RadioButton rdDong;
        private System.Windows.Forms.RadioButton rdBac;
        private System.Windows.Forms.RadioButton rdVang;
        private Bunifu.Framework.UI.BunifuFlatButton btnThemKH;
        private Bunifu.Framework.UI.BunifuFlatButton btnView;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvkhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvloaithetv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtDTT;
        private System.Windows.Forms.TextBox txtLoaithe;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuy;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTOITHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIA;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.RadioButton rdThanhVien;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTichLuy;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
    }
}
