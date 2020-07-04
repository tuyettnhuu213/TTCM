namespace ThucTapChuyenMon
{
    partial class page_douong
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
            this.components = new System.ComponentModel.Container();
            this.lvthucdon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Madu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtten = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtgia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.cbsize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btxoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btsua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hinhanh = new System.Windows.Forms.PictureBox();
            this.errorMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.mofile = new System.Windows.Forms.OpenFileDialog();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // lvthucdon
            // 
            this.lvthucdon.AllowColumnReorder = true;
            this.lvthucdon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvthucdon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.stt,
            this.ten,
            this.Madu});
            this.lvthucdon.FullRowSelect = true;
            this.lvthucdon.GridLines = true;
            this.lvthucdon.HideSelection = false;
            this.lvthucdon.Location = new System.Drawing.Point(632, 12);
            this.lvthucdon.Name = "lvthucdon";
            this.lvthucdon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvthucdon.Size = new System.Drawing.Size(730, 614);
            this.lvthucdon.TabIndex = 0;
            this.lvthucdon.UseCompatibleStateImageBehavior = false;
            this.lvthucdon.View = System.Windows.Forms.View.Details;
            this.lvthucdon.SelectedIndexChanged += new System.EventHandler(this.lvthucdon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "maloai";
            this.columnHeader1.Width = 5;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 120;
            // 
            // ten
            // 
            this.ten.Text = "Tên";
            this.ten.Width = 300;
            // 
            // Madu
            // 
            this.Madu.Text = "Mã đồ uống";
            this.Madu.Width = 100;
            // 
            // txtten
            // 
            this.txtten.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtten.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtten.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtten.BorderThickness = 3;
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtten.isPassword = false;
            this.txtten.Location = new System.Drawing.Point(116, 290);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(289, 33);
            this.txtten.TabIndex = 2;
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtgia
            // 
            this.txtgia.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtgia.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgia.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtgia.BorderThickness = 3;
            this.txtgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtgia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtgia.isPassword = false;
            this.txtgia.Location = new System.Drawing.Point(116, 440);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(289, 33);
            this.txtgia.TabIndex = 4;
            this.txtgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtgia.OnValueChanged += new System.EventHandler(this.txtgia_OnValueChanged);
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // cbloai
            // 
            this.cbloai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(116, 343);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(289, 29);
            this.cbloai.TabIndex = 5;
            this.cbloai.SelectedIndexChanged += new System.EventHandler(this.cbloai_SelectedIndexChanged);
            this.cbloai.TextChanged += new System.EventHandler(this.cbloai_TextChanged);
            // 
            // cbsize
            // 
            this.cbsize.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbsize.FormattingEnabled = true;
            this.cbsize.Location = new System.Drawing.Point(116, 393);
            this.cbsize.Name = "cbsize";
            this.cbsize.Size = new System.Drawing.Size(289, 29);
            this.cbsize.TabIndex = 6;
            this.cbsize.SelectedIndexChanged += new System.EventHandler(this.cbsize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.Image = global::ThucTapChuyenMon.Properties.Resources.mathematics;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(421, 383);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(44, 39);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 17;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = global::ThucTapChuyenMon.Properties.Resources.mathematics;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(421, 338);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btxoa
            // 
            this.btxoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btxoa.BorderRadius = 0;
            this.btxoa.ButtonText = "Xóa";
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.DisabledColor = System.Drawing.Color.Gray;
            this.btxoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btxoa.Iconimage = global::ThucTapChuyenMon.Properties.Resources.trash__1_;
            this.btxoa.Iconimage_right = null;
            this.btxoa.Iconimage_right_Selected = null;
            this.btxoa.Iconimage_Selected = null;
            this.btxoa.IconMarginLeft = 0;
            this.btxoa.IconMarginRight = 0;
            this.btxoa.IconRightVisible = true;
            this.btxoa.IconRightZoom = 0D;
            this.btxoa.IconVisible = true;
            this.btxoa.IconZoom = 87D;
            this.btxoa.IsTab = false;
            this.btxoa.Location = new System.Drawing.Point(155, 629);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btxoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btxoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btxoa.selected = false;
            this.btxoa.Size = new System.Drawing.Size(209, 52);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btxoa.Textcolor = System.Drawing.Color.White;
            this.btxoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btsua.BorderRadius = 0;
            this.btsua.ButtonText = "Sửa";
            this.btsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsua.DisabledColor = System.Drawing.Color.Gray;
            this.btsua.Iconcolor = System.Drawing.Color.Transparent;
            this.btsua.Iconimage = global::ThucTapChuyenMon.Properties.Resources.marker__1_;
            this.btsua.Iconimage_right = null;
            this.btsua.Iconimage_right_Selected = null;
            this.btsua.Iconimage_Selected = null;
            this.btsua.IconMarginLeft = 0;
            this.btsua.IconMarginRight = 0;
            this.btsua.IconRightVisible = true;
            this.btsua.IconRightZoom = 0D;
            this.btsua.IconVisible = true;
            this.btsua.IconZoom = 90D;
            this.btsua.IsTab = false;
            this.btsua.Location = new System.Drawing.Point(155, 562);
            this.btsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btsua.Name = "btsua";
            this.btsua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btsua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btsua.OnHoverTextColor = System.Drawing.Color.White;
            this.btsua.selected = false;
            this.btsua.Size = new System.Drawing.Size(209, 59);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btsua.Textcolor = System.Drawing.Color.White;
            this.btsua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthem.BorderRadius = 0;
            this.btthem.ButtonText = "Thêm";
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.DisabledColor = System.Drawing.Color.Gray;
            this.btthem.Iconcolor = System.Drawing.Color.Transparent;
            this.btthem.Iconimage = global::ThucTapChuyenMon.Properties.Resources.add__1_1;
            this.btthem.Iconimage_right = null;
            this.btthem.Iconimage_right_Selected = null;
            this.btthem.Iconimage_Selected = null;
            this.btthem.IconMarginLeft = 0;
            this.btthem.IconMarginRight = 0;
            this.btthem.IconRightVisible = true;
            this.btthem.IconRightZoom = 0D;
            this.btthem.IconVisible = true;
            this.btthem.IconZoom = 90D;
            this.btthem.IsTab = false;
            this.btthem.Location = new System.Drawing.Point(155, 495);
            this.btthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btthem.Name = "btthem";
            this.btthem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btthem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btthem.OnHoverTextColor = System.Drawing.Color.White;
            this.btthem.selected = false;
            this.btthem.Size = new System.Drawing.Size(209, 59);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthem.Textcolor = System.Drawing.Color.White;
            this.btthem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // hinhanh
            // 
            this.hinhanh.BackColor = System.Drawing.Color.SeaGreen;
            this.hinhanh.Location = new System.Drawing.Point(135, 12);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(258, 233);
            this.hinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanh.TabIndex = 1;
            this.hinhanh.TabStop = false;
            this.hinhanh.Click += new System.EventHandler(this.hinhanh_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.ContainerControl = this;
            // 
            // mofile
            // 
            this.mofile.FileName = "Hình ảnh";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton3.Image = global::ThucTapChuyenMon.Properties.Resources.no;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(421, 290);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(44, 39);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 18;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ảnh minh họa";
            // 
            // page_douong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbsize);
            this.Controls.Add(this.cbloai);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.lvthucdon);
            this.Name = "page_douong";
            this.Size = new System.Drawing.Size(1383, 725);
            this.Load += new System.EventHandler(this.page_douong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvthucdon;
        private System.Windows.Forms.PictureBox hinhanh;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtten;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtgia;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.ComboBox cbsize;
        private Bunifu.Framework.UI.BunifuFlatButton btthem;
        private Bunifu.Framework.UI.BunifuFlatButton btsua;
        private Bunifu.Framework.UI.BunifuFlatButton btxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader Madu;
        private System.Windows.Forms.ErrorProvider errorMessage;
        private System.Windows.Forms.OpenFileDialog mofile;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label5;
    }
}
