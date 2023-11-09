namespace QuanLyDangKyMonHoc
{
    partial class F_ThemHocPhan
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
            this.panel_Body = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHocPhan = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblLoaiTraCuu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChuongTrinhDaoTao = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.btnDangKy);
            this.panel_Body.Controls.Add(this.dataGridView1);
            this.panel_Body.Controls.Add(this.groupBox1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1121, 569);
            this.panel_Body.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHocPhan);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.lblLoaiTraCuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChuongTrinhDaoTao);
            this.groupBox1.Location = new System.Drawing.Point(95, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // txtHocPhan
            // 
            this.txtHocPhan.Location = new System.Drawing.Point(576, 24);
            this.txtHocPhan.Name = "txtHocPhan";
            this.txtHocPhan.Size = new System.Drawing.Size(198, 26);
            this.txtHocPhan.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(797, 18);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(94, 34);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tìm kiếm";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // lblLoaiTraCuu
            // 
            this.lblLoaiTraCuu.AutoSize = true;
            this.lblLoaiTraCuu.Location = new System.Drawing.Point(98, 32);
            this.lblLoaiTraCuu.Name = "lblLoaiTraCuu";
            this.lblLoaiTraCuu.Size = new System.Drawing.Size(96, 20);
            this.lblLoaiTraCuu.TabIndex = 1;
            this.lblLoaiTraCuu.Text = "Loại tra cứu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập thông tin: ";
            // 
            // cbChuongTrinhDaoTao
            // 
            this.cbChuongTrinhDaoTao.FormattingEnabled = true;
            this.cbChuongTrinhDaoTao.Items.AddRange(new object[] {
            "Mã học phần",
            "Tên học phần"});
            this.cbChuongTrinhDaoTao.Location = new System.Drawing.Point(266, 24);
            this.cbChuongTrinhDaoTao.Name = "cbChuongTrinhDaoTao";
            this.cbChuongTrinhDaoTao.Size = new System.Drawing.Size(121, 28);
            this.cbChuongTrinhDaoTao.TabIndex = 3;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(855, 477);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(147, 48);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // F_ThemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 569);
            this.Controls.Add(this.panel_Body);
            this.Name = "F_ThemHocPhan";
            this.Text = "F_ThemHocPhan";
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHocPhan;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblLoaiTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChuongTrinhDaoTao;
        private System.Windows.Forms.Button btnDangKy;
    }
}