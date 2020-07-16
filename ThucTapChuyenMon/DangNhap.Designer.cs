namespace ThucTapChuyenMon
{
    partial class DangNhap
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
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnthoat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkpass = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HintForeColor = System.Drawing.Color.Black;
            this.txtname.HintText = "Tên đăng nhập";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.Black;
            this.txtname.LineIdleColor = System.Drawing.Color.Black;
            this.txtname.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(140, 250);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(267, 33);
            this.txtname.TabIndex = 0;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpass
            // 
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HintForeColor = System.Drawing.Color.Black;
            this.txtpass.HintText = "Mật khẩu";
            this.txtpass.isPassword = false;
            this.txtpass.LineFocusedColor = System.Drawing.Color.Black;
            this.txtpass.LineIdleColor = System.Drawing.Color.Black;
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtpass.LineThickness = 3;
            this.txtpass.Location = new System.Drawing.Point(140, 304);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(267, 33);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.OnValueChanged += new System.EventHandler(this.txtpass_OnValueChanged);
            this.txtpass.Click += new System.EventHandler(this.txtpass_Click);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnthoat
            // 
            this.btnthoat.Activecolor = System.Drawing.Color.Transparent;
            this.btnthoat.BackColor = System.Drawing.Color.Transparent;
            this.btnthoat.BackgroundImage = global::ThucTapChuyenMon.Properties.Resources.Untitled;
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.BorderRadius = 0;
            this.btnthoat.ButtonText = "Thoát";
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.DisabledColor = System.Drawing.Color.Gray;
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthoat.Iconimage = global::ThucTapChuyenMon.Properties.Resources._return;
            this.btnthoat.Iconimage_right = null;
            this.btnthoat.Iconimage_right_Selected = null;
            this.btnthoat.Iconimage_Selected = null;
            this.btnthoat.IconMarginLeft = 0;
            this.btnthoat.IconMarginRight = 0;
            this.btnthoat.IconRightVisible = true;
            this.btnthoat.IconRightZoom = 0D;
            this.btnthoat.IconVisible = true;
            this.btnthoat.IconZoom = 55D;
            this.btnthoat.IsTab = false;
            this.btnthoat.Location = new System.Drawing.Point(286, 360);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnthoat.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnthoat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnthoat.selected = false;
            this.btnthoat.Size = new System.Drawing.Size(189, 63);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Textcolor = System.Drawing.Color.Black;
            this.btnthoat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Activecolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BackgroundImage = global::ThucTapChuyenMon.Properties.Resources.Untitled;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.BorderRadius = 0;
            this.btnDangNhap.ButtonText = "Đăng nhập";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Iconimage = global::ThucTapChuyenMon.Properties.Resources.yesss;
            this.btnDangNhap.Iconimage_right = null;
            this.btnDangNhap.Iconimage_right_Selected = null;
            this.btnDangNhap.Iconimage_Selected = null;
            this.btnDangNhap.IconMarginLeft = 0;
            this.btnDangNhap.IconMarginRight = 0;
            this.btnDangNhap.IconRightVisible = false;
            this.btnDangNhap.IconRightZoom = 0D;
            this.btnDangNhap.IconVisible = true;
            this.btnDangNhap.IconZoom = 60D;
            this.btnDangNhap.IsTab = false;
            this.btnDangNhap.Location = new System.Drawing.Point(44, 360);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangNhap.selected = false;
            this.btnDangNhap.Size = new System.Drawing.Size(218, 63);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.Textcolor = System.Drawing.Color.Black;
            this.btnDangNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ThucTapChuyenMon.Properties.Resources.milktea_mania_fb;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(540, 256);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ThucTapChuyenMon.Properties.Resources.logo_thuc_uong_3;
            this.pictureBox3.Location = new System.Drawing.Point(131, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(287, 255);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // chkpass
            // 
            this.chkpass.BackColor = System.Drawing.Color.Transparent;
            this.chkpass.Image = global::ThucTapChuyenMon.Properties.Resources.eye;
            this.chkpass.ImageActive = null;
            this.chkpass.Location = new System.Drawing.Point(430, 304);
            this.chkpass.Name = "chkpass";
            this.chkpass.Size = new System.Drawing.Size(35, 34);
            this.chkpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chkpass.TabIndex = 7;
            this.chkpass.TabStop = false;
            this.chkpass.Zoom = 10;
            this.chkpass.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ThucTapChuyenMon.Properties.Resources.lock__1_;
            this.pictureBox2.Location = new System.Drawing.Point(77, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThucTapChuyenMon.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(77, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 622);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.chkpass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangNhap;
        private Bunifu.Framework.UI.BunifuFlatButton btnthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton chkpass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

