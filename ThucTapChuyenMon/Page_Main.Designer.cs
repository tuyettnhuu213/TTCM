namespace ThucTapChuyenMon
{
    partial class Page_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlbutton = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnquanlikho = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnkhachhang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnthongke = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnhanvien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnthucdon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btntrangchu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlbutton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào:";
            // 
            // pnlbutton
            // 
            this.pnlbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlbutton.Controls.Add(this.btnquanlikho);
            this.pnlbutton.Controls.Add(this.btnkhachhang);
            this.pnlbutton.Controls.Add(this.btnthongke);
            this.pnlbutton.Controls.Add(this.btnnhanvien);
            this.pnlbutton.Controls.Add(this.btnthucdon);
            this.pnlbutton.Controls.Add(this.btntrangchu);
            this.pnlbutton.Location = new System.Drawing.Point(1, 798);
            this.pnlbutton.Name = "pnlbutton";
            this.pnlbutton.Size = new System.Drawing.Size(1364, 101);
            this.pnlbutton.TabIndex = 1;
            this.pnlbutton.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbutton_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Location = new System.Drawing.Point(1, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1442, 720);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightPink;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(1309, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(133, 80);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "Tài khoản";
            // 
            // btnquanlikho
            // 
            this.btnquanlikho.Activecolor = System.Drawing.Color.Transparent;
            this.btnquanlikho.BackColor = System.Drawing.Color.Transparent;
            this.btnquanlikho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnquanlikho.BorderRadius = 0;
            this.btnquanlikho.ButtonText = "";
            this.btnquanlikho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquanlikho.DisabledColor = System.Drawing.Color.Gray;
            this.btnquanlikho.Iconcolor = System.Drawing.Color.Transparent;
            this.btnquanlikho.Iconimage = global::ThucTapChuyenMon.Properties.Resources.factory;
            this.btnquanlikho.Iconimage_right = null;
            this.btnquanlikho.Iconimage_right_Selected = null;
            this.btnquanlikho.Iconimage_Selected = null;
            this.btnquanlikho.IconMarginLeft = 0;
            this.btnquanlikho.IconMarginRight = 0;
            this.btnquanlikho.IconRightVisible = true;
            this.btnquanlikho.IconRightZoom = 0D;
            this.btnquanlikho.IconVisible = true;
            this.btnquanlikho.IconZoom = 90D;
            this.btnquanlikho.IsTab = false;
            this.btnquanlikho.Location = new System.Drawing.Point(849, 7);
            this.btnquanlikho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnquanlikho.Name = "btnquanlikho";
            this.btnquanlikho.Normalcolor = System.Drawing.Color.Transparent;
            this.btnquanlikho.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnquanlikho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnquanlikho.selected = false;
            this.btnquanlikho.Size = new System.Drawing.Size(71, 59);
            this.btnquanlikho.TabIndex = 6;
            this.btnquanlikho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnquanlikho.Textcolor = System.Drawing.Color.White;
            this.btnquanlikho.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnquanlikho, "Quản lí kho nguyên liệu");
            this.btnquanlikho.Click += new System.EventHandler(this.btnquanlikho_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Activecolor = System.Drawing.Color.Transparent;
            this.btnkhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btnkhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkhachhang.BorderRadius = 0;
            this.btnkhachhang.ButtonText = "";
            this.btnkhachhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkhachhang.DisabledColor = System.Drawing.Color.Gray;
            this.btnkhachhang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnkhachhang.Iconimage = global::ThucTapChuyenMon.Properties.Resources.customer_service;
            this.btnkhachhang.Iconimage_right = null;
            this.btnkhachhang.Iconimage_right_Selected = null;
            this.btnkhachhang.Iconimage_Selected = null;
            this.btnkhachhang.IconMarginLeft = 0;
            this.btnkhachhang.IconMarginRight = 0;
            this.btnkhachhang.IconRightVisible = true;
            this.btnkhachhang.IconRightZoom = 0D;
            this.btnkhachhang.IconVisible = true;
            this.btnkhachhang.IconZoom = 90D;
            this.btnkhachhang.IsTab = false;
            this.btnkhachhang.Location = new System.Drawing.Point(731, 7);
            this.btnkhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnkhachhang.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnkhachhang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnkhachhang.selected = false;
            this.btnkhachhang.Size = new System.Drawing.Size(71, 59);
            this.btnkhachhang.TabIndex = 5;
            this.btnkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhachhang.Textcolor = System.Drawing.Color.White;
            this.btnkhachhang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnkhachhang, "Quản lí nhân viên");
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Activecolor = System.Drawing.Color.Transparent;
            this.btnthongke.BackColor = System.Drawing.Color.Transparent;
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthongke.BorderRadius = 0;
            this.btnthongke.ButtonText = "";
            this.btnthongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthongke.DisabledColor = System.Drawing.Color.Gray;
            this.btnthongke.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthongke.Iconimage = global::ThucTapChuyenMon.Properties.Resources.Investment_48px;
            this.btnthongke.Iconimage_right = null;
            this.btnthongke.Iconimage_right_Selected = null;
            this.btnthongke.Iconimage_Selected = null;
            this.btnthongke.IconMarginLeft = 0;
            this.btnthongke.IconMarginRight = 0;
            this.btnthongke.IconRightVisible = true;
            this.btnthongke.IconRightZoom = 0D;
            this.btnthongke.IconVisible = true;
            this.btnthongke.IconZoom = 90D;
            this.btnthongke.IsTab = false;
            this.btnthongke.Location = new System.Drawing.Point(988, 7);
            this.btnthongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Normalcolor = System.Drawing.Color.Transparent;
            this.btnthongke.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnthongke.OnHoverTextColor = System.Drawing.Color.White;
            this.btnthongke.selected = false;
            this.btnthongke.Size = new System.Drawing.Size(67, 59);
            this.btnthongke.TabIndex = 4;
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.Textcolor = System.Drawing.Color.White;
            this.btnthongke.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnthongke, "Thống kê");
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Activecolor = System.Drawing.Color.Transparent;
            this.btnnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnhanvien.BorderRadius = 0;
            this.btnnhanvien.ButtonText = "";
            this.btnnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnhanvien.DisabledColor = System.Drawing.Color.Gray;
            this.btnnhanvien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnhanvien.Iconimage = global::ThucTapChuyenMon.Properties.Resources.waitress;
            this.btnnhanvien.Iconimage_right = null;
            this.btnnhanvien.Iconimage_right_Selected = null;
            this.btnnhanvien.Iconimage_Selected = null;
            this.btnnhanvien.IconMarginLeft = 0;
            this.btnnhanvien.IconMarginRight = 0;
            this.btnnhanvien.IconRightVisible = true;
            this.btnnhanvien.IconRightZoom = 0D;
            this.btnnhanvien.IconVisible = true;
            this.btnnhanvien.IconZoom = 90D;
            this.btnnhanvien.IsTab = false;
            this.btnnhanvien.Location = new System.Drawing.Point(619, 7);
            this.btnnhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Normalcolor = System.Drawing.Color.Transparent;
            this.btnnhanvien.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnnhanvien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnhanvien.selected = false;
            this.btnnhanvien.Size = new System.Drawing.Size(71, 59);
            this.btnnhanvien.TabIndex = 2;
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhanvien.Textcolor = System.Drawing.Color.White;
            this.btnnhanvien.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnnhanvien, "Quản lí nhân viên");
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnthucdon
            // 
            this.btnthucdon.Activecolor = System.Drawing.Color.Transparent;
            this.btnthucdon.BackColor = System.Drawing.Color.Transparent;
            this.btnthucdon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthucdon.BorderRadius = 0;
            this.btnthucdon.ButtonText = "";
            this.btnthucdon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthucdon.DisabledColor = System.Drawing.Color.Gray;
            this.btnthucdon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthucdon.Iconimage = global::ThucTapChuyenMon.Properties.Resources.food_and_restaurant;
            this.btnthucdon.Iconimage_right = null;
            this.btnthucdon.Iconimage_right_Selected = null;
            this.btnthucdon.Iconimage_Selected = null;
            this.btnthucdon.IconMarginLeft = 0;
            this.btnthucdon.IconMarginRight = 0;
            this.btnthucdon.IconRightVisible = true;
            this.btnthucdon.IconRightZoom = 0D;
            this.btnthucdon.IconVisible = true;
            this.btnthucdon.IconZoom = 90D;
            this.btnthucdon.IsTab = false;
            this.btnthucdon.Location = new System.Drawing.Point(507, 7);
            this.btnthucdon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthucdon.Name = "btnthucdon";
            this.btnthucdon.Normalcolor = System.Drawing.Color.Transparent;
            this.btnthucdon.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btnthucdon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnthucdon.selected = false;
            this.btnthucdon.Size = new System.Drawing.Size(71, 59);
            this.btnthucdon.TabIndex = 1;
            this.btnthucdon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthucdon.Textcolor = System.Drawing.Color.White;
            this.btnthucdon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnthucdon, "Quản lí đồ uống");
            this.btnthucdon.Click += new System.EventHandler(this.btnthucdon_Click);
            // 
            // btntrangchu
            // 
            this.btntrangchu.Activecolor = System.Drawing.Color.Transparent;
            this.btntrangchu.BackColor = System.Drawing.Color.Transparent;
            this.btntrangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrangchu.BorderRadius = 0;
            this.btntrangchu.ButtonText = "";
            this.btntrangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntrangchu.DisabledColor = System.Drawing.Color.Gray;
            this.btntrangchu.Iconcolor = System.Drawing.Color.Transparent;
            this.btntrangchu.Iconimage = global::ThucTapChuyenMon.Properties.Resources.working;
            this.btntrangchu.Iconimage_right = null;
            this.btntrangchu.Iconimage_right_Selected = null;
            this.btntrangchu.Iconimage_Selected = null;
            this.btntrangchu.IconMarginLeft = 0;
            this.btntrangchu.IconMarginRight = 0;
            this.btntrangchu.IconRightVisible = true;
            this.btntrangchu.IconRightZoom = 0D;
            this.btntrangchu.IconVisible = true;
            this.btntrangchu.IconZoom = 90D;
            this.btntrangchu.IsTab = false;
            this.btntrangchu.Location = new System.Drawing.Point(385, 7);
            this.btntrangchu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Normalcolor = System.Drawing.Color.Transparent;
            this.btntrangchu.OnHovercolor = System.Drawing.Color.Firebrick;
            this.btntrangchu.OnHoverTextColor = System.Drawing.Color.White;
            this.btntrangchu.selected = false;
            this.btntrangchu.Size = new System.Drawing.Size(67, 59);
            this.btntrangchu.TabIndex = 0;
            this.btntrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntrangchu.Textcolor = System.Drawing.Color.White;
            this.btntrangchu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btntrangchu, "Trang chủ bán hàng");
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = global::ThucTapChuyenMon.Properties.Resources.cogwheel1;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 56);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Thông tin tài khoản";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // Page_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 906);
            this.Controls.Add(this.pnlbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Page_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Main";
            this.Load += new System.EventHandler(this.Page_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlbutton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlbutton;
        private Bunifu.Framework.UI.BunifuFlatButton btntrangchu;
        private Bunifu.Framework.UI.BunifuFlatButton btnquanlikho;
        private Bunifu.Framework.UI.BunifuFlatButton btnkhachhang;
        private Bunifu.Framework.UI.BunifuFlatButton btnthongke;
        private Bunifu.Framework.UI.BunifuFlatButton btnnhanvien;
        private Bunifu.Framework.UI.BunifuFlatButton btnthucdon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider error;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
    }
}