namespace ThucTapChuyenMon
{
    partial class Form_ThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThemNhanVien));
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtten = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtmaktkhau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttendangnhap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtdiachi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtsdt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcmnd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbchucvu
            // 
            this.cbchucvu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbchucvu.ForeColor = System.Drawing.Color.IndianRed;
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(178, 334);
            this.cbchucvu.Margin = new System.Windows.Forms.Padding(4);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(388, 29);
            this.cbchucvu.TabIndex = 62;
            this.cbchucvu.SelectedIndexChanged += new System.EventHandler(this.cbchucvu_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(56, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Chức vụ :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(56, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "CMND :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(56, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sdt :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(56, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Địa chỉ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(56, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên nhân viên :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(56, 436);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Mật khẩu :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(56, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 65;
            this.label8.Text = "Tên đăng nhập :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtten
            // 
            this.txtten.BackColor = System.Drawing.Color.White;
            this.txtten.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txtten.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txtten.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txtten.BorderThickness = 3;
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtten.ForeColor = System.Drawing.Color.IndianRed;
            this.txtten.isPassword = false;
            this.txtten.Location = new System.Drawing.Point(178, 124);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(388, 34);
            this.txtten.TabIndex = 69;
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtten.OnValueChanged += new System.EventHandler(this.txtten_OnValueChanged);
            // 
            // txtmaktkhau
            // 
            this.txtmaktkhau.BackColor = System.Drawing.Color.White;
            this.txtmaktkhau.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txtmaktkhau.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txtmaktkhau.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txtmaktkhau.BorderThickness = 3;
            this.txtmaktkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmaktkhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmaktkhau.ForeColor = System.Drawing.Color.IndianRed;
            this.txtmaktkhau.isPassword = false;
            this.txtmaktkhau.Location = new System.Drawing.Point(178, 426);
            this.txtmaktkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaktkhau.Name = "txtmaktkhau";
            this.txtmaktkhau.Size = new System.Drawing.Size(388, 34);
            this.txtmaktkhau.TabIndex = 70;
            this.txtmaktkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmaktkhau.OnValueChanged += new System.EventHandler(this.txtmaktkhau_OnValueChanged);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.BackColor = System.Drawing.Color.White;
            this.txttendangnhap.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txttendangnhap.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txttendangnhap.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txttendangnhap.BorderThickness = 3;
            this.txttendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttendangnhap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txttendangnhap.ForeColor = System.Drawing.Color.IndianRed;
            this.txttendangnhap.isPassword = false;
            this.txttendangnhap.Location = new System.Drawing.Point(178, 374);
            this.txttendangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(388, 34);
            this.txttendangnhap.TabIndex = 71;
            this.txttendangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttendangnhap.OnValueChanged += new System.EventHandler(this.txttendangnhap_OnValueChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.BackColor = System.Drawing.Color.White;
            this.txtdiachi.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txtdiachi.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txtdiachi.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txtdiachi.BorderThickness = 3;
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdiachi.ForeColor = System.Drawing.Color.IndianRed;
            this.txtdiachi.isPassword = false;
            this.txtdiachi.Location = new System.Drawing.Point(178, 176);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(388, 34);
            this.txtdiachi.TabIndex = 72;
            this.txtdiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdiachi.OnValueChanged += new System.EventHandler(this.txtdiachi_OnValueChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txtsdt.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txtsdt.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txtsdt.BorderThickness = 3;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsdt.ForeColor = System.Drawing.Color.IndianRed;
            this.txtsdt.isPassword = false;
            this.txtsdt.Location = new System.Drawing.Point(178, 226);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(388, 34);
            this.txtsdt.TabIndex = 73;
            this.txtsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsdt.OnValueChanged += new System.EventHandler(this.txtsdt_OnValueChanged);
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtcmnd
            // 
            this.txtcmnd.BackColor = System.Drawing.Color.White;
            this.txtcmnd.BorderColorFocused = System.Drawing.Color.DarkSalmon;
            this.txtcmnd.BorderColorIdle = System.Drawing.Color.IndianRed;
            this.txtcmnd.BorderColorMouseHover = System.Drawing.Color.DarkSalmon;
            this.txtcmnd.BorderThickness = 3;
            this.txtcmnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcmnd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcmnd.ForeColor = System.Drawing.Color.IndianRed;
            this.txtcmnd.isPassword = false;
            this.txtcmnd.Location = new System.Drawing.Point(178, 278);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(388, 34);
            this.txtcmnd.TabIndex = 74;
            this.txtcmnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcmnd.OnValueChanged += new System.EventHandler(this.txtcmnd_OnValueChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.ActiveBorderThickness = 1;
            this.btnthoat.ActiveCornerRadius = 20;
            this.btnthoat.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.btnthoat.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnthoat.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnthoat.BackColor = System.Drawing.Color.PeachPuff;
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.ButtonText = "Thoát";
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnthoat.IdleBorderThickness = 1;
            this.btnthoat.IdleCornerRadius = 20;
            this.btnthoat.IdleFillColor = System.Drawing.Color.White;
            this.btnthoat.IdleForecolor = System.Drawing.Color.IndianRed;
            this.btnthoat.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnthoat.Location = new System.Drawing.Point(335, 494);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(132, 50);
            this.btnthoat.TabIndex = 76;
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ActiveBorderThickness = 1;
            this.btnDangNhap.ActiveCornerRadius = 20;
            this.btnDangNhap.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.ButtonText = "Thêm";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.IdleBorderThickness = 1;
            this.btnDangNhap.IdleCornerRadius = 20;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.White;
            this.btnDangNhap.IdleForecolor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Location = new System.Drawing.Point(189, 494);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 50);
            this.btnDangNhap.TabIndex = 75;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThucTapChuyenMon.Properties.Resources.waitress;
            this.pictureBox1.Location = new System.Drawing.Point(296, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(642, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttendangnhap);
            this.Controls.Add(this.txtmaktkhau);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_ThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtten;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmaktkhau;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttendangnhap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtdiachi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsdt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcmnd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangNhap;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}