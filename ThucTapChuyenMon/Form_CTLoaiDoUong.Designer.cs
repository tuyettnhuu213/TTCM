namespace ThucTapChuyenMon
{
    partial class Form_CTLoaiDoUong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvloai = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btluu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloai = new System.Windows.Forms.TextBox();
            this.btnthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvloai
            // 
            this.dgvloai.AllowUserToAddRows = false;
            this.dgvloai.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvloai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvloai.BackgroundColor = System.Drawing.Color.White;
            this.dgvloai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvloai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloai,
            this.tenloai,
            this.xoa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvloai.DoubleBuffered = true;
            this.dgvloai.EnableHeadersVisualStyles = false;
            this.dgvloai.GridColor = System.Drawing.Color.IndianRed;
            this.dgvloai.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.dgvloai.HeaderForeColor = System.Drawing.Color.White;
            this.dgvloai.Location = new System.Drawing.Point(51, 137);
            this.dgvloai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvloai.Name = "dgvloai";
            this.dgvloai.ReadOnly = true;
            this.dgvloai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloai.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvloai.RowHeadersWidth = 51;
            this.dgvloai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloai.Size = new System.Drawing.Size(565, 185);
            this.dgvloai.TabIndex = 18;
            this.dgvloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloai_CellClick);
            // 
            // maloai
            // 
            this.maloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maloai.DataPropertyName = "maloai";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.MinimumWidth = 6;
            this.maloai.Name = "maloai";
            this.maloai.ReadOnly = true;
            // 
            // tenloai
            // 
            this.tenloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Tên Loại";
            this.tenloai.MinimumWidth = 6;
            this.tenloai.Name = "tenloai";
            this.tenloai.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.HeaderText = "   Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 63);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOẠI ĐỒ UỐNG";
            // 
            // btluu
            // 
            this.btluu.Activecolor = System.Drawing.Color.LightPink;
            this.btluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btluu.Location = new System.Drawing.Point(271, 420);
            this.btluu.Margin = new System.Windows.Forms.Padding(5);
            this.btluu.Name = "btluu";
            this.btluu.Normalcolor = System.Drawing.Color.IndianRed;
            this.btluu.OnHovercolor = System.Drawing.Color.LightPink;
            this.btluu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btluu.selected = false;
            this.btluu.Size = new System.Drawing.Size(137, 44);
            this.btluu.TabIndex = 22;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btluu.Textcolor = System.Drawing.Color.White;
            this.btluu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên : ";
            // 
            // txtloai
            // 
            this.txtloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloai.ForeColor = System.Drawing.Color.Gray;
            this.txtloai.Location = new System.Drawing.Point(280, 359);
            this.txtloai.Margin = new System.Windows.Forms.Padding(4);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(168, 26);
            this.txtloai.TabIndex = 20;
            this.txtloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtloai.Enter += new System.EventHandler(this.txtloai_Enter);
            this.txtloai.Leave += new System.EventHandler(this.txtloai_Leave);
            // 
            // btnthem
            // 
            this.btnthem.Activecolor = System.Drawing.Color.LightPink;
            this.btnthem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthem.BackColor = System.Drawing.Color.IndianRed;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.BorderRadius = 0;
            this.btnthem.ButtonText = "Thêm";
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.DisabledColor = System.Drawing.Color.Gray;
            this.btnthem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnthem.Iconimage = global::ThucTapChuyenMon.Properties.Resources.plus;
            this.btnthem.Iconimage_right = null;
            this.btnthem.Iconimage_right_Selected = null;
            this.btnthem.Iconimage_Selected = null;
            this.btnthem.IconMarginLeft = 0;
            this.btnthem.IconMarginRight = 0;
            this.btnthem.IconRightVisible = true;
            this.btnthem.IconRightZoom = 0D;
            this.btnthem.IconVisible = true;
            this.btnthem.IconZoom = 52D;
            this.btnthem.IsTab = false;
            this.btnthem.Location = new System.Drawing.Point(109, 420);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnthem.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnthem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnthem.selected = false;
            this.btnthem.Size = new System.Drawing.Size(127, 44);
            this.btnthem.TabIndex = 19;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Textcolor = System.Drawing.Color.White;
            this.btnthem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thoát";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(424, 420);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(137, 44);
            this.bunifuFlatButton1.TabIndex = 24;
            this.bunifuFlatButton1.Text = "Thoát";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form_CTLoaiDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(655, 520);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.dgvloai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.btnthem);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CTLoaiDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CTLoaiDoUong";
            this.Load += new System.EventHandler(this.Form_CTLoaiDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btluu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloai;
        private Bunifu.Framework.UI.BunifuFlatButton btnthem;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}