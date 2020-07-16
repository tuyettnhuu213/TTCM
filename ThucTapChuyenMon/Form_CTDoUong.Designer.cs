namespace ThucTapChuyenMon
{
    partial class Form_CTDoUong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.btnthem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvloai = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbsize = new System.Windows.Forms.Label();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.btluu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 63);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHI TIẾT SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Đơn Giá :";
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.ForeColor = System.Drawing.Color.Gray;
            this.txtgia.Location = new System.Drawing.Point(364, 415);
            this.txtgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(168, 26);
            this.txtgia.TabIndex = 29;
            this.txtgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            this.txtgia.Enter += new System.EventHandler(this.txtgia_Enter);
            this.txtgia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgia_KeyDown);
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            this.txtgia.Leave += new System.EventHandler(this.txtgia_Leave);
            // 
            // btnthem
            // 
            this.btnthem.Activecolor = System.Drawing.Color.Pink;
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
            this.btnthem.IconZoom = 65D;
            this.btnthem.IsTab = false;
            this.btnthem.Location = new System.Drawing.Point(149, 477);
            this.btnthem.Margin = new System.Windows.Forms.Padding(5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Normalcolor = System.Drawing.Color.IndianRed;
            this.btnthem.OnHovercolor = System.Drawing.Color.LightPink;
            this.btnthem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnthem.selected = false;
            this.btnthem.Size = new System.Drawing.Size(194, 44);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnthem.Textcolor = System.Drawing.Color.White;
            this.btnthem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgvloai
            // 
            this.dgvloai.AllowUserToAddRows = false;
            this.dgvloai.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvloai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvloai.BackgroundColor = System.Drawing.Color.White;
            this.dgvloai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvloai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.size,
            this.gia,
            this.xoa});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloai.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvloai.DoubleBuffered = true;
            this.dgvloai.EnableHeadersVisualStyles = false;
            this.dgvloai.GridColor = System.Drawing.Color.IndianRed;
            this.dgvloai.HeaderBgColor = System.Drawing.Color.IndianRed;
            this.dgvloai.HeaderForeColor = System.Drawing.Color.White;
            this.dgvloai.Location = new System.Drawing.Point(132, 173);
            this.dgvloai.Margin = new System.Windows.Forms.Padding(4);
            this.dgvloai.Name = "dgvloai";
            this.dgvloai.ReadOnly = true;
            this.dgvloai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloai.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvloai.RowHeadersWidth = 51;
            this.dgvloai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloai.Size = new System.Drawing.Size(565, 140);
            this.dgvloai.TabIndex = 27;
            this.dgvloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloai_CellClick);
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Đơn Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle8;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.HeaderText = "   Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 60;
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Location = new System.Drawing.Point(260, 382);
            this.lbsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(43, 17);
            this.lbsize.TabIndex = 33;
            this.lbsize.Text = "Size :";
            // 
            // txtsize
            // 
            this.txtsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsize.ForeColor = System.Drawing.Color.Gray;
            this.txtsize.Location = new System.Drawing.Point(364, 379);
            this.txtsize.Margin = new System.Windows.Forms.Padding(4);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(168, 26);
            this.txtsize.TabIndex = 32;
            this.txtsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsize.Enter += new System.EventHandler(this.txtsize_Enter);
            this.txtsize.Leave += new System.EventHandler(this.txtsize_Leave);
            // 
            // btluu
            // 
            this.btluu.Activecolor = System.Drawing.Color.Pink;
            this.btluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btluu.BackColor = System.Drawing.Color.IndianRed;
            this.btluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btluu.BorderRadius = 0;
            this.btluu.ButtonText = "Lưu";
            this.btluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btluu.DisabledColor = System.Drawing.Color.DimGray;
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
            this.btluu.Location = new System.Drawing.Point(353, 477);
            this.btluu.Margin = new System.Windows.Forms.Padding(5);
            this.btluu.Name = "btluu";
            this.btluu.Normalcolor = System.Drawing.Color.IndianRed;
            this.btluu.OnHovercolor = System.Drawing.Color.LightPink;
            this.btluu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btluu.selected = false;
            this.btluu.Size = new System.Drawing.Size(125, 44);
            this.btluu.TabIndex = 31;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btluu.Textcolor = System.Drawing.Color.White;
            this.btluu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Pink;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(488, 477);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.IndianRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightPink;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(137, 44);
            this.bunifuFlatButton1.TabIndex = 34;
            this.bunifuFlatButton1.Text = "Thoát";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Form_CTDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(830, 584);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvloai);
            this.Controls.Add(this.lbsize);
            this.Controls.Add(this.txtsize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CTDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CTDoUong";
            this.Load += new System.EventHandler(this.Form_CTDoUong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btluu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgia;
        private Bunifu.Framework.UI.BunifuFlatButton btnthem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.TextBox txtsize;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}