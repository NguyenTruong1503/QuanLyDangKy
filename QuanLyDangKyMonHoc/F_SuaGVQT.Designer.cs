namespace QuanLyDangKyMonHoc
{
    partial class F_SuaGVQT
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
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.MaSV = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.TenSV = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.gvThongTinGVSua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinGVSua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(931, 451);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 47);
            this.btnCapNhat.TabIndex = 95;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(702, 361);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(164, 26);
            this.txtTrinhDo.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Trình Độ:";
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.Location = new System.Drawing.Point(702, 404);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(164, 26);
            this.txtMaBoMon.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Mã Bộ Môn:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(702, 262);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(164, 26);
            this.txtGioiTinh.TabIndex = 90;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(702, 308);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(164, 26);
            this.txtSoDT.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Số điện thoại:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(404, 359);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(159, 26);
            this.dtpNgaySinh.TabIndex = 87;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 11, 12, 0, 8, 30, 0);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(404, 268);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(159, 26);
            this.txtMaGV.TabIndex = 79;
            // 
            // MaSV
            // 
            this.MaSV.AutoSize = true;
            this.MaSV.Location = new System.Drawing.Point(285, 268);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(110, 20);
            this.MaSV.TabIndex = 82;
            this.MaSV.Text = "Mã giảng viên:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(404, 308);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(159, 26);
            this.txtTenGV.TabIndex = 80;
            // 
            // TenSV
            // 
            this.TenSV.AutoSize = true;
            this.TenSV.Location = new System.Drawing.Point(285, 314);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(115, 20);
            this.TenSV.TabIndex = 83;
            this.TenSV.Text = "Tên giảng viên:";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(285, 407);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(61, 20);
            this.DiaChi.TabIndex = 86;
            this.DiaChi.Text = "Địa chỉ:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(594, 268);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(71, 20);
            this.GioiTinh.TabIndex = 84;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(285, 360);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(82, 20);
            this.NgaySinh.TabIndex = 85;
            this.NgaySinh.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(404, 402);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(159, 26);
            this.txtDiaChi.TabIndex = 81;
            // 
            // gvThongTinGVSua
            // 
            this.gvThongTinGVSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThongTinGVSua.Location = new System.Drawing.Point(160, 32);
            this.gvThongTinGVSua.Name = "gvThongTinGVSua";
            this.gvThongTinGVSua.RowHeadersWidth = 62;
            this.gvThongTinGVSua.RowTemplate.Height = 28;
            this.gvThongTinGVSua.Size = new System.Drawing.Size(843, 206);
            this.gvThongTinGVSua.TabIndex = 96;
            this.gvThongTinGVSua.SelectionChanged += new System.EventHandler(this.gvThongTinGVSua_SelectionChanged);
            // 
            // F_SuaGVQT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 529);
            this.Controls.Add(this.gvThongTinGVSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTrinhDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaBoMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.MaSV);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.TenSV);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Name = "F_SuaGVQT";
            this.Text = "F_SuaGVQT";
            this.Load += new System.EventHandler(this.F_SuaGVQT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinGVSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label MaSV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label TenSV;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView gvThongTinGVSua;
    }
}