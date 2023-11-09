namespace QuanLyDangKyMonHoc
{
    partial class F_ThongBao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgHopThuDen = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.btnDanhDau = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHopThuDen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hộp thư đến";
            // 
            // dgHopThuDen
            // 
            this.dgHopThuDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHopThuDen.Location = new System.Drawing.Point(136, 78);
            this.dgHopThuDen.Name = "dgHopThuDen";
            this.dgHopThuDen.RowHeadersWidth = 62;
            this.dgHopThuDen.RowTemplate.Height = 28;
            this.dgHopThuDen.Size = new System.Drawing.Size(883, 236);
            this.dgHopThuDen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi tiết thông báo:";
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(136, 366);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(883, 107);
            this.txtChiTiet.TabIndex = 3;
            // 
            // btnDanhDau
            // 
            this.btnDanhDau.Location = new System.Drawing.Point(579, 500);
            this.btnDanhDau.Name = "btnDanhDau";
            this.btnDanhDau.Size = new System.Drawing.Size(155, 40);
            this.btnDanhDau.TabIndex = 4;
            this.btnDanhDau.Text = "Đánh dấu đã xem";
            this.btnDanhDau.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa thông báo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // F_ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDanhDau);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgHopThuDen);
            this.Controls.Add(this.label1);
            this.Name = "F_ThongBao";
            this.Text = "F_ThongBao";
            ((System.ComponentModel.ISupportInitialize)(this.dgHopThuDen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgHopThuDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Button btnDanhDau;
        private System.Windows.Forms.Button button2;
    }
}