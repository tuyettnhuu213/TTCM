﻿namespace ThucTapChuyenMon
{
    partial class Form_XuatKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvnguyenlieu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.manl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slnl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bthuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bttach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.cbnguyenlieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtnguyenlieu = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.dgvnguyenlieu);
            this.groupControl2.Location = new System.Drawing.Point(473, 91);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(516, 305);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Nguyên Liệu Xuất";
            // 
            // dgvnguyenlieu
            // 
            this.dgvnguyenlieu.AllowUserToAddRows = false;
            this.dgvnguyenlieu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvnguyenlieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnguyenlieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvnguyenlieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvnguyenlieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnguyenlieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manl,
            this.tennl,
            this.dvt,
            this.slnl,
            this.xoa});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnguyenlieu.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvnguyenlieu.DoubleBuffered = true;
            this.dgvnguyenlieu.EnableHeadersVisualStyles = false;
            this.dgvnguyenlieu.GridColor = System.Drawing.Color.Black;
            this.dgvnguyenlieu.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.dgvnguyenlieu.HeaderForeColor = System.Drawing.Color.White;
            this.dgvnguyenlieu.Location = new System.Drawing.Point(14, 37);
            this.dgvnguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvnguyenlieu.Name = "dgvnguyenlieu";
            this.dgvnguyenlieu.ReadOnly = true;
            this.dgvnguyenlieu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnguyenlieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvnguyenlieu.RowHeadersWidth = 51;
            this.dgvnguyenlieu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvnguyenlieu.RowTemplate.Height = 30;
            this.dgvnguyenlieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnguyenlieu.ShowCellErrors = false;
            this.dgvnguyenlieu.ShowRowErrors = false;
            this.dgvnguyenlieu.Size = new System.Drawing.Size(485, 262);
            this.dgvnguyenlieu.TabIndex = 46;
            // 
            // manl
            // 
            this.manl.DataPropertyName = "Manl";
            this.manl.HeaderText = "Mã NL";
            this.manl.MinimumWidth = 6;
            this.manl.Name = "manl";
            this.manl.ReadOnly = true;
            this.manl.Visible = false;
            this.manl.Width = 125;
            // 
            // tennl
            // 
            this.tennl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennl.DataPropertyName = "tennl";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tennl.DefaultCellStyle = dataGridViewCellStyle3;
            this.tennl.HeaderText = "Tên NL";
            this.tennl.MinimumWidth = 6;
            this.tennl.Name = "tennl";
            this.tennl.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvt.HeaderText = "DVT";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            // 
            // slnl
            // 
            this.slnl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slnl.DataPropertyName = "soluong";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.slnl.DefaultCellStyle = dataGridViewCellStyle5;
            this.slnl.HeaderText = "S.Lượng";
            this.slnl.MinimumWidth = 6;
            this.slnl.Name = "slnl";
            this.slnl.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle6;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.HeaderText = "Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Visible = false;
            // 
            // bthuy
            // 
            this.bthuy.Activecolor = System.Drawing.Color.LightPink;
            this.bthuy.BackColor = System.Drawing.Color.IndianRed;
            this.bthuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthuy.BorderRadius = 0;
            this.bthuy.ButtonText = "Hủy Bỏ";
            this.bthuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthuy.DisabledColor = System.Drawing.Color.Gray;
            this.bthuy.Iconcolor = System.Drawing.Color.Transparent;
            this.bthuy.Iconimage = global::ThucTapChuyenMon.Properties.Resources._return;
            this.bthuy.Iconimage_right = null;
            this.bthuy.Iconimage_right_Selected = null;
            this.bthuy.Iconimage_Selected = null;
            this.bthuy.IconMarginLeft = 0;
            this.bthuy.IconMarginRight = 0;
            this.bthuy.IconRightVisible = true;
            this.bthuy.IconRightZoom = 0D;
            this.bthuy.IconVisible = true;
            this.bthuy.IconZoom = 60D;
            this.bthuy.IsTab = false;
            this.bthuy.Location = new System.Drawing.Point(518, 419);
            this.bthuy.Margin = new System.Windows.Forms.Padding(5);
            this.bthuy.Name = "bthuy";
            this.bthuy.Normalcolor = System.Drawing.Color.IndianRed;
            this.bthuy.OnHovercolor = System.Drawing.Color.LightPink;
            this.bthuy.OnHoverTextColor = System.Drawing.Color.White;
            this.bthuy.selected = false;
            this.bthuy.Size = new System.Drawing.Size(195, 42);
            this.bthuy.TabIndex = 24;
            this.bthuy.Text = "Hủy Bỏ";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bthuy.Textcolor = System.Drawing.Color.White;
            this.bthuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // bttach
            // 
            this.bttach.Activecolor = System.Drawing.Color.LightPink;
            this.bttach.BackColor = System.Drawing.Color.IndianRed;
            this.bttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttach.BorderRadius = 0;
            this.bttach.ButtonText = "Xuất";
            this.bttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttach.DisabledColor = System.Drawing.Color.Gray;
            this.bttach.Iconcolor = System.Drawing.Color.Transparent;
            this.bttach.Iconimage = global::ThucTapChuyenMon.Properties.Resources.save__1_;
            this.bttach.Iconimage_right = null;
            this.bttach.Iconimage_right_Selected = null;
            this.bttach.Iconimage_Selected = null;
            this.bttach.IconMarginLeft = 0;
            this.bttach.IconMarginRight = 0;
            this.bttach.IconRightVisible = true;
            this.bttach.IconRightZoom = 0D;
            this.bttach.IconVisible = true;
            this.bttach.IconZoom = 60D;
            this.bttach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttach.IsTab = false;
            this.bttach.Location = new System.Drawing.Point(268, 419);
            this.bttach.Margin = new System.Windows.Forms.Padding(5);
            this.bttach.Name = "bttach";
            this.bttach.Normalcolor = System.Drawing.Color.IndianRed;
            this.bttach.OnHovercolor = System.Drawing.Color.LightPink;
            this.bttach.OnHoverTextColor = System.Drawing.Color.White;
            this.bttach.selected = false;
            this.bttach.Size = new System.Drawing.Size(132, 42);
            this.bttach.TabIndex = 23;
            this.bttach.Text = "Xuất";
            this.bttach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttach.Textcolor = System.Drawing.Color.White;
            this.bttach.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttach.Click += new System.EventHandler(this.bttach_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Số Lượng Muốn Xuất:";
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(241, 135);
            this.txttonkho.Margin = new System.Windows.Forms.Padding(4);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.Size = new System.Drawing.Size(160, 23);
            this.txttonkho.TabIndex = 42;
            // 
            // txtdvt
            // 
            this.txtdvt.Location = new System.Drawing.Point(241, 98);
            this.txtdvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(160, 23);
            this.txtdvt.TabIndex = 41;
            // 
            // cbnguyenlieu
            // 
            this.cbnguyenlieu.FormattingEnabled = true;
            this.cbnguyenlieu.Location = new System.Drawing.Point(241, 56);
            this.cbnguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbnguyenlieu.Name = "cbnguyenlieu";
            this.cbnguyenlieu.Size = new System.Drawing.Size(160, 24);
            this.cbnguyenlieu.TabIndex = 0;
            this.cbnguyenlieu.SelectedIndexChanged += new System.EventHandler(this.cbnguyenlieu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng Trong Kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn Vị Tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nguyên Liệu :";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(241, 175);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(160, 23);
            this.txtsoluong.TabIndex = 2;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txttonkho);
            this.groupControl1.Controls.Add(this.txtdvt);
            this.groupControl1.Controls.Add(this.cbnguyenlieu);
            this.groupControl1.Controls.Add(this.txtnguyenlieu);
            this.groupControl1.Controls.Add(this.bunifuFlatButton1);
            this.groupControl1.Controls.Add(this.bthem);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtsoluong);
            this.groupControl1.Location = new System.Drawing.Point(-8, 91);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 305);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Chọn Nguyên liệu";
            // 
            // txtnguyenlieu
            // 
            this.txtnguyenlieu.Location = new System.Drawing.Point(241, 55);
            this.txtnguyenlieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtnguyenlieu.Name = "txtnguyenlieu";
            this.txtnguyenlieu.Size = new System.Drawing.Size(160, 23);
            this.txtnguyenlieu.TabIndex = 40;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Reset";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::ThucTapChuyenMon.Properties.Resources.reset;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(270, 249);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(132, 42);
            this.bunifuFlatButton1.TabIndex = 39;
            this.bunifuFlatButton1.Text = "Reset";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bthem
            // 
            this.bthem.Activecolor = System.Drawing.Color.LightPink;
            this.bthem.BackColor = System.Drawing.Color.IndianRed;
            this.bthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthem.BorderRadius = 0;
            this.bthem.ButtonText = "Thêm";
            this.bthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bthem.DisabledColor = System.Drawing.Color.Gray;
            this.bthem.Iconcolor = System.Drawing.Color.Transparent;
            this.bthem.Iconimage = global::ThucTapChuyenMon.Properties.Resources.plus;
            this.bthem.Iconimage_right = null;
            this.bthem.Iconimage_right_Selected = null;
            this.bthem.Iconimage_Selected = null;
            this.bthem.IconMarginLeft = 0;
            this.bthem.IconMarginRight = 0;
            this.bthem.IconRightVisible = true;
            this.bthem.IconRightZoom = 0D;
            this.bthem.IconVisible = true;
            this.bthem.IconZoom = 60D;
            this.bthem.IsTab = false;
            this.bthem.Location = new System.Drawing.Point(66, 249);
            this.bthem.Margin = new System.Windows.Forms.Padding(5);
            this.bthem.Name = "bthem";
            this.bthem.Normalcolor = System.Drawing.Color.IndianRed;
            this.bthem.OnHovercolor = System.Drawing.Color.LightPink;
            this.bthem.OnHoverTextColor = System.Drawing.Color.White;
            this.bthem.selected = false;
            this.bthem.Size = new System.Drawing.Size(132, 42);
            this.bthem.TabIndex = 15;
            this.bthem.Text = "Thêm";
            this.bthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bthem.Textcolor = System.Drawing.Color.White;
            this.bthem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthem.Click += new System.EventHandler(this.bthem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThucTapChuyenMon.Properties.Resources.mover_truck;
            this.pictureBox1.Location = new System.Drawing.Point(428, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(988, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.bttach);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_XuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_XuatKho";
            this.Load += new System.EventHandler(this.Form_XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnguyenlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvnguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn manl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn slnl;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bthem;
        private Bunifu.Framework.UI.BunifuFlatButton bthuy;
        private Bunifu.Framework.UI.BunifuFlatButton bttach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.ComboBox cbnguyenlieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoluong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtnguyenlieu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}