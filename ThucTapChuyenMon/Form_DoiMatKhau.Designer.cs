namespace ThucTapChuyenMon
{
    partial class Form_DoiMatKhau
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
            this.txtmkcu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtmkmoi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtnhaplai = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmkcu
            // 
            this.txtmkcu.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmkcu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkcu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmkcu.BorderThickness = 3;
            this.txtmkcu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmkcu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmkcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkcu.isPassword = false;
            this.txtmkcu.Location = new System.Drawing.Point(264, 210);
            this.txtmkcu.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(321, 38);
            this.txtmkcu.TabIndex = 0;
            this.txtmkcu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmkcu.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmkmoi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkmoi.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmkmoi.BorderThickness = 3;
            this.txtmkmoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmkmoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmkmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmkmoi.isPassword = false;
            this.txtmkmoi.Location = new System.Drawing.Point(264, 269);
            this.txtmkmoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(321, 38);
            this.txtmkmoi.TabIndex = 1;
            this.txtmkmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmkmoi.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox2_OnValueChanged);
            // 
            // txtnhaplai
            // 
            this.txtnhaplai.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtnhaplai.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnhaplai.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtnhaplai.BorderThickness = 3;
            this.txtnhaplai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnhaplai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnhaplai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnhaplai.isPassword = false;
            this.txtnhaplai.Location = new System.Drawing.Point(264, 332);
            this.txtnhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhaplai.Name = "txtnhaplai";
            this.txtnhaplai.Size = new System.Drawing.Size(321, 38);
            this.txtnhaplai.TabIndex = 2;
            this.txtnhaplai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnhaplai.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox3_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThucTapChuyenMon.Properties.Resources.user_experience;
            this.pictureBox1.Location = new System.Drawing.Point(275, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Hủy Bỏ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::ThucTapChuyenMon.Properties.Resources._return;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 52D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(363, 431);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(166, 50);
            this.bunifuFlatButton1.TabIndex = 54;
            this.bunifuFlatButton1.Text = "Hủy Bỏ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btthem
            // 
            this.btthem.Activecolor = System.Drawing.Color.Green;
            this.btthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btthem.BackColor = System.Drawing.Color.IndianRed;
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btthem.BorderRadius = 0;
            this.btthem.ButtonText = "Lưu";
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.DisabledColor = System.Drawing.Color.Gray;
            this.btthem.Iconcolor = System.Drawing.Color.Transparent;
            this.btthem.Iconimage = global::ThucTapChuyenMon.Properties.Resources.save__1_;
            this.btthem.Iconimage_right = null;
            this.btthem.Iconimage_right_Selected = null;
            this.btthem.Iconimage_Selected = null;
            this.btthem.IconMarginLeft = 0;
            this.btthem.IconMarginRight = 0;
            this.btthem.IconRightVisible = true;
            this.btthem.IconRightZoom = 0D;
            this.btthem.IconVisible = true;
            this.btthem.IconZoom = 52D;
            this.btthem.IsTab = false;
            this.btthem.Location = new System.Drawing.Point(163, 431);
            this.btthem.Margin = new System.Windows.Forms.Padding(5);
            this.btthem.Name = "btthem";
            this.btthem.Normalcolor = System.Drawing.Color.IndianRed;
            this.btthem.OnHovercolor = System.Drawing.Color.LightPink;
            this.btthem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btthem.selected = false;
            this.btthem.Size = new System.Drawing.Size(166, 50);
            this.btthem.TabIndex = 53;
            this.btthem.Text = "Lưu";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btthem.Textcolor = System.Drawing.Color.White;
            this.btthem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // Form_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(665, 523);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnhaplai);
            this.Controls.Add(this.txtmkmoi);
            this.Controls.Add(this.txtmkcu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_DoiMatKhau";
            this.Load += new System.EventHandler(this.Form_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtmkcu;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmkmoi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnhaplai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btthem;
        private System.Windows.Forms.ErrorProvider loi;
    }
}