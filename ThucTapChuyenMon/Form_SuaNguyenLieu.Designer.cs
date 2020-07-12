namespace ThucTapChuyenMon
{
    partial class Form_SuaNguyenLieu
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
            this.bthuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btluu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bthuy
            // 
            this.bthuy.Activecolor = System.Drawing.Color.LightPink;
            this.bthuy.BackColor = System.Drawing.Color.IndianRed;
            this.bthuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bthuy.BorderRadius = 0;
            this.bthuy.ButtonText = "Hủy";
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
            this.bthuy.IconZoom = 52D;
            this.bthuy.IsTab = false;
            this.bthuy.Location = new System.Drawing.Point(244, 354);
            this.bthuy.Margin = new System.Windows.Forms.Padding(5);
            this.bthuy.Name = "bthuy";
            this.bthuy.Normalcolor = System.Drawing.Color.IndianRed;
            this.bthuy.OnHovercolor = System.Drawing.Color.LightPink;
            this.bthuy.OnHoverTextColor = System.Drawing.Color.White;
            this.bthuy.selected = false;
            this.bthuy.Size = new System.Drawing.Size(163, 55);
            this.bthuy.TabIndex = 27;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bthuy.Textcolor = System.Drawing.Color.White;
            this.bthuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btluu
            // 
            this.btluu.Activecolor = System.Drawing.Color.LightPink;
            this.btluu.BackColor = System.Drawing.Color.IndianRed;
            this.btluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btluu.BorderRadius = 0;
            this.btluu.ButtonText = "Lưu";
            this.btluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btluu.DisabledColor = System.Drawing.Color.Gray;
            this.btluu.Iconcolor = System.Drawing.Color.Transparent;
            this.btluu.Iconimage = global::ThucTapChuyenMon.Properties.Resources.save__1_;
            this.btluu.Iconimage_right = null;
            this.btluu.Iconimage_right_Selected = null;
            this.btluu.Iconimage_Selected = null;
            this.btluu.IconMarginLeft = 0;
            this.btluu.IconMarginRight = 0;
            this.btluu.IconRightVisible = true;
            this.btluu.IconRightZoom = 0D;
            this.btluu.IconVisible = true;
            this.btluu.IconZoom = 52D;
            this.btluu.IsTab = false;
            this.btluu.Location = new System.Drawing.Point(43, 354);
            this.btluu.Margin = new System.Windows.Forms.Padding(5);
            this.btluu.Name = "btluu";
            this.btluu.Normalcolor = System.Drawing.Color.IndianRed;
            this.btluu.OnHovercolor = System.Drawing.Color.LightPink;
            this.btluu.OnHoverTextColor = System.Drawing.Color.White;
            this.btluu.selected = false;
            this.btluu.Size = new System.Drawing.Size(174, 55);
            this.btluu.TabIndex = 26;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btluu.Textcolor = System.Drawing.Color.White;
            this.btluu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Đơn Vị Tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Nguyên Liệu :";
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Items.AddRange(new object[] {
            "hộp",
            "lon",
            "thùng",
            "gói",
            "kg",
            "chai"});
            this.cbDonViTinh.Location = new System.Drawing.Point(244, 220);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(163, 24);
            this.cbDonViTinh.TabIndex = 22;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(244, 279);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(163, 22);
            this.txtsoluong.TabIndex = 21;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(244, 171);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(163, 22);
            this.txtTenNguyenLieu.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThucTapChuyenMon.Properties.Resources._49196578_282219809106898_2525188264625700864_n__Custom_;
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form_SuaNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDonViTinh);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtTenNguyenLieu);
            this.Name = "Form_SuaNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_SuaNguyenLieu";
            this.Load += new System.EventHandler(this.Form_SuaNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bthuy;
        private Bunifu.Framework.UI.BunifuFlatButton btluu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}