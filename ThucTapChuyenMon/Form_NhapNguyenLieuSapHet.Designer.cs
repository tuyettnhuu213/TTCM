namespace ThucTapChuyenMon
{
    partial class Form_NhapNguyenLieuSapHet
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.bthuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btluu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbdvt = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttennl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giá Nhập :";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(209, 190);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(163, 22);
            this.txtgia.TabIndex = 39;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
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
            this.bthuy.Location = new System.Drawing.Point(208, 267);
            this.bthuy.Margin = new System.Windows.Forms.Padding(5);
            this.bthuy.Name = "bthuy";
            this.bthuy.Normalcolor = System.Drawing.Color.IndianRed;
            this.bthuy.OnHovercolor = System.Drawing.Color.Pink;
            this.bthuy.OnHoverTextColor = System.Drawing.Color.White;
            this.bthuy.selected = false;
            this.bthuy.Size = new System.Drawing.Size(164, 47);
            this.bthuy.TabIndex = 38;
            this.bthuy.Text = "Hủy Bỏ";
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
            this.btluu.IconZoom = 60D;
            this.btluu.IsTab = false;
            this.btluu.Location = new System.Drawing.Point(14, 267);
            this.btluu.Margin = new System.Windows.Forms.Padding(5);
            this.btluu.Name = "btluu";
            this.btluu.Normalcolor = System.Drawing.Color.IndianRed;
            this.btluu.OnHovercolor = System.Drawing.Color.Pink;
            this.btluu.OnHoverTextColor = System.Drawing.Color.White;
            this.btluu.selected = false;
            this.btluu.Size = new System.Drawing.Size(132, 47);
            this.btluu.TabIndex = 37;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btluu.Textcolor = System.Drawing.Color.White;
            this.btluu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Đơn Vị Tính :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên Nguyên Liệu :";
            // 
            // cbdvt
            // 
            this.cbdvt.Enabled = false;
            this.cbdvt.FormattingEnabled = true;
            this.cbdvt.Items.AddRange(new object[] {
            "hộp",
            "lon",
            "thùng",
            "gói",
            "kg",
            "chai"});
            this.cbdvt.Location = new System.Drawing.Point(209, 102);
            this.cbdvt.Name = "cbdvt";
            this.cbdvt.Size = new System.Drawing.Size(163, 24);
            this.cbdvt.TabIndex = 33;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(209, 147);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(163, 22);
            this.txtsoluong.TabIndex = 32;
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // txttennl
            // 
            this.txttennl.Location = new System.Drawing.Point(209, 65);
            this.txttennl.Name = "txttennl";
            this.txttennl.Size = new System.Drawing.Size(163, 22);
            this.txttennl.TabIndex = 31;
            // 
            // Form_NhapNguyenLieuSapHet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(413, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbdvt);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttennl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_NhapNguyenLieuSapHet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NhapNguyenLieuSapHet";
            this.Load += new System.EventHandler(this.Form_NhapNguyenLieuSapHet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
        private Bunifu.Framework.UI.BunifuFlatButton bthuy;
        private Bunifu.Framework.UI.BunifuFlatButton btluu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdvt;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttennl;
    }
}