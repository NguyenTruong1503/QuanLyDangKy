namespace QuanLyDangKyMonHoc
{
    partial class F_ChuongTrinhDaoTao
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
            this.gvHienThongTinCTDT = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHocPhan = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblLoaiTraCuu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChuongTrinhDaoTao = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHienThongTinCTDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.gvHienThongTinCTDT);
            this.panel_Body.Controls.Add(this.groupBox1);
            this.panel_Body.Controls.Add(this.groupBox2);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(996, 456);
            this.panel_Body.TabIndex = 0;
            // 
            // gvHienThongTinCTDT
            // 
            this.gvHienThongTinCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHienThongTinCTDT.Location = new System.Drawing.Point(52, 202);
            this.gvHienThongTinCTDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvHienThongTinCTDT.Name = "gvHienThongTinCTDT";
            this.gvHienThongTinCTDT.RowHeadersWidth = 62;
            this.gvHienThongTinCTDT.RowTemplate.Height = 28;
            this.gvHienThongTinCTDT.Size = new System.Drawing.Size(891, 233);
            this.gvHienThongTinCTDT.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHocPhan);
            this.groupBox1.Controls.Add(this.btnTraCuu);
            this.groupBox1.Controls.Add(this.lblLoaiTraCuu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChuongTrinhDaoTao);
            this.groupBox1.Location = new System.Drawing.Point(84, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(806, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // txtHocPhan
            // 
            this.txtHocPhan.Location = new System.Drawing.Point(512, 19);
            this.txtHocPhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocPhan.Name = "txtHocPhan";
            this.txtHocPhan.Size = new System.Drawing.Size(176, 22);
            this.txtHocPhan.TabIndex = 2;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(708, 14);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(84, 27);
            this.btnTraCuu.TabIndex = 5;
            this.btnTraCuu.Text = "Tìm kiếm";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // lblLoaiTraCuu
            // 
            this.lblLoaiTraCuu.AutoSize = true;
            this.lblLoaiTraCuu.Location = new System.Drawing.Point(87, 26);
            this.lblLoaiTraCuu.Name = "lblLoaiTraCuu";
            this.lblLoaiTraCuu.Size = new System.Drawing.Size(78, 16);
            this.lblLoaiTraCuu.TabIndex = 1;
            this.lblLoaiTraCuu.Text = "Loại tra cứu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập thông tin: ";
            // 
            // cbChuongTrinhDaoTao
            // 
            this.cbChuongTrinhDaoTao.FormattingEnabled = true;
            this.cbChuongTrinhDaoTao.Items.AddRange(new object[] {
            "Mã học phần",
            "Mã ngành"});
            this.cbChuongTrinhDaoTao.Location = new System.Drawing.Point(236, 19);
            this.cbChuongTrinhDaoTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChuongTrinhDaoTao.Name = "cbChuongTrinhDaoTao";
            this.cbChuongTrinhDaoTao.Size = new System.Drawing.Size(108, 24);
            this.cbChuongTrinhDaoTao.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(84, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(806, 80);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(339, 30);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(595, 30);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(78, 30);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // F_ChuongTrinhDaoTao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 456);
            this.Controls.Add(this.panel_Body);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_ChuongTrinhDaoTao";
            this.Text = "Chương trình đào tạo";
            this.Load += new System.EventHandler(this.F_ChuongTrinhDaoTao_Load);
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHienThongTinCTDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.DataGridView gvHienThongTinCTDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHocPhan;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblLoaiTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChuongTrinhDaoTao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}