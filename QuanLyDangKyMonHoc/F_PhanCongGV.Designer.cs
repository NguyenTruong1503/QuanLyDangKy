namespace QuanLyDangKyMonHoc
{
    partial class F_PhanCongGV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.cbDanhSachGV = new System.Windows.Forms.ComboBox();
            this.cbDanhSachHP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bộ Môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách giảng viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách lớp học phần";
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Location = new System.Drawing.Point(761, 388);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(193, 56);
            this.btnPhanCong.TabIndex = 4;
            this.btnPhanCong.Text = "Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            // 
            // txtBoMon
            // 
            this.txtBoMon.Location = new System.Drawing.Point(901, 79);
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.Size = new System.Drawing.Size(121, 26);
            this.txtBoMon.TabIndex = 5;
            // 
            // cbDanhSachGV
            // 
            this.cbDanhSachGV.FormattingEnabled = true;
            this.cbDanhSachGV.Location = new System.Drawing.Point(901, 149);
            this.cbDanhSachGV.Name = "cbDanhSachGV";
            this.cbDanhSachGV.Size = new System.Drawing.Size(121, 28);
            this.cbDanhSachGV.TabIndex = 6;
            // 
            // cbDanhSachHP
            // 
            this.cbDanhSachHP.FormattingEnabled = true;
            this.cbDanhSachHP.Location = new System.Drawing.Point(901, 217);
            this.cbDanhSachHP.Name = "cbDanhSachHP";
            this.cbDanhSachHP.Size = new System.Drawing.Size(121, 28);
            this.cbDanhSachHP.TabIndex = 7;
            // 
            // F_PhanCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 528);
            this.Controls.Add(this.cbDanhSachHP);
            this.Controls.Add(this.cbDanhSachGV);
            this.Controls.Add(this.txtBoMon);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_PhanCongGV";
            this.Text = "F_PhanCongGV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.TextBox txtBoMon;
        private System.Windows.Forms.ComboBox cbDanhSachGV;
        private System.Windows.Forms.ComboBox cbDanhSachHP;
    }
}