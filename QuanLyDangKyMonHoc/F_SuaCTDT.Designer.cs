namespace QuanLyDangKyMonHoc
{
    partial class F_SuaCTDT
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiHP = new System.Windows.Forms.TextBox();
            this.gvThongTinCTDT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinCTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(751, 305);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 42);
            this.btnCapNhat.TabIndex = 53;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(840, 102);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(124, 22);
            this.txtMaNganh.TabIndex = 52;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(840, 177);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(124, 22);
            this.txtTenHP.TabIndex = 41;
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(684, 182);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(89, 16);
            this.lblTenHP.TabIndex = 33;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã học phần";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(840, 144);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(124, 22);
            this.txtMaHP.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã ngành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Loại học phần";
            // 
            // txtLoaiHP
            // 
            this.txtLoaiHP.Location = new System.Drawing.Point(840, 216);
            this.txtLoaiHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiHP.Name = "txtLoaiHP";
            this.txtLoaiHP.Size = new System.Drawing.Size(124, 22);
            this.txtLoaiHP.TabIndex = 57;
            // 
            // gvThongTinCTDT
            // 
            this.gvThongTinCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongTinCTDT.Location = new System.Drawing.Point(36, 65);
            this.gvThongTinCTDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvThongTinCTDT.Name = "gvThongTinCTDT";
            this.gvThongTinCTDT.RowHeadersWidth = 62;
            this.gvThongTinCTDT.RowTemplate.Height = 28;
            this.gvThongTinCTDT.Size = new System.Drawing.Size(587, 292);
            this.gvThongTinCTDT.TabIndex = 98;
            this.gvThongTinCTDT.SelectionChanged += new System.EventHandler(this.gvThongTinCTDT_SelectionChanged);
            // 
            // F_SuaCTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 456);
            this.Controls.Add(this.gvThongTinCTDT);
            this.Controls.Add(this.txtLoaiHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtMaNganh);
            this.Controls.Add(this.txtTenHP);
            this.Controls.Add(this.lblTenHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_SuaCTDT";
            this.Text = "F_SuaCTDT";
            this.Load += new System.EventHandler(this.F_SuaCTDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinCTDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiHP;
        private System.Windows.Forms.DataGridView gvThongTinCTDT;
    }
}