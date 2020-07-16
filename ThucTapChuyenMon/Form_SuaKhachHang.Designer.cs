namespace ThucTapChuyenMon
{
    partial class Form_SuaKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SuaKhachHang));
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtemail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtten = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, -77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 38);
            this.label5.TabIndex = 25;
            this.label5.Text = "THÊM KHÁCH HÀNG";
            // 
            // txtdiachi
            // 
            this.txtdiachi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtdiachi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdiachi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtdiachi.BorderThickness = 3;
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdiachi.ForeColor = System.Drawing.Color.Black;
            this.txtdiachi.isPassword = false;
            this.txtdiachi.Location = new System.Drawing.Point(164, 290);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(370, 44);
            this.txtdiachi.TabIndex = 23;
            this.txtdiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtemail
            // 
            this.txtemail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtemail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtemail.BorderThickness = 3;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.isPassword = false;
            this.txtemail.Location = new System.Drawing.Point(164, 238);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(370, 44);
            this.txtemail.TabIndex = 20;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtten
            // 
            this.txtten.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtten.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtten.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtten.BorderThickness = 3;
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.isPassword = false;
            this.txtten.Location = new System.Drawing.Point(164, 187);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(370, 44);
            this.txtten.TabIndex = 19;
            this.txtten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên khách hàng";
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
            this.btnthoat.Location = new System.Drawing.Point(349, 416);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(132, 50);
            this.btnthoat.TabIndex = 96;
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
            this.btnDangNhap.ButtonText = "Lưu";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.IdleBorderThickness = 1;
            this.btnDangNhap.IdleCornerRadius = 20;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.White;
            this.btnDangNhap.IdleForecolor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Location = new System.Drawing.Point(203, 416);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(132, 50);
            this.btnDangNhap.TabIndex = 95;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "Số điện thoại";
            // 
            // txtsdt
            // 
            this.txtsdt.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtsdt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsdt.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtsdt.BorderThickness = 3;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsdt.ForeColor = System.Drawing.Color.Black;
            this.txtsdt.isPassword = false;
            this.txtsdt.Location = new System.Drawing.Point(164, 347);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(370, 44);
            this.txtsdt.TabIndex = 98;
            this.txtsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(269, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ThucTapChuyenMon.Properties.Resources.customer_service;
            this.pictureBox.Location = new System.Drawing.Point(134, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(115, 101);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 100;
            this.pictureBox.TabStop = false;
            // 
            // Form_SuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(655, 520);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SuaKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SuaKhachHang";
            this.Load += new System.EventHandler(this.Form_SuaKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtdiachi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtemail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnthoat;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangNhap;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsdt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}