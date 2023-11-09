namespace QuanLyDangKyMonHoc
{
    partial class F_ThemCTDT
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
            this.txtLoaiHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoaiHP
            // 
            this.txtLoaiHP.Location = new System.Drawing.Point(515, 219);
            this.txtLoaiHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiHP.Name = "txtLoaiHP";
            this.txtLoaiHP.Size = new System.Drawing.Size(124, 22);
            this.txtLoaiHP.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Loại học phần";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(426, 309);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(121, 42);
            this.btnCapNhat.TabIndex = 64;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(515, 106);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(124, 22);
            this.txtMaNganh.TabIndex = 63;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(515, 181);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(124, 22);
            this.txtTenHP.TabIndex = 62;
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(358, 186);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(89, 16);
            this.lblTenHP.TabIndex = 61;
            this.lblTenHP.Text = "Tên học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã học phần";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(515, 148);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(124, 22);
            this.txtMaHP.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mã ngành:";
            // 
            // F_ThemCTDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 456);
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
            this.Name = "F_ThemCTDT";
            this.Text = "F_ThemCTDT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoaiHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label1;
    }
}