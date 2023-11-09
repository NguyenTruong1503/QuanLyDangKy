using QuanLyDangKyMonHoc.BSLayer;
using QuanLyDangKyMonHoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyMonHoc
{
    public partial class F_ThemGVQT : Form
    {
        DataTable dtGiangVien = null;

        BSGiangVien dbGiangVien = new BSGiangVien();

        public bool Them;
        public string MaGiangVien;
        public F_ThemGVQT(string MaGV, bool Them = false)
        {
            InitializeComponent();
            this.MaGiangVien = MaGV;
            this.Them = Them;
        }

        private void F_ThemGVQT_Load(object sender, EventArgs e)
        {
           
               
        }

       

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                try
                {
                    string maGiangVien = txtMaGV.Text;
                    string hoTen = txtTenGV.Text;
                    string gioiTinh = txtGioiTinh.Text;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string diaChi = txtDiaChi.Text;
                    string soDT = txtSoDT.Text;
                    string trinhDo = txtTrinhDo.Text;
                    string MaBoMon = txtMaBoMon.Text;

                    DialogResult message;
                    // Hiện hộp thoại hỏi đáp 
                    message = MessageBox.Show("Bạn có muốn thêm thông tin giảng viên", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (message == DialogResult.Yes)
                    {
                        dbGiangVien.AddGV(maGiangVien, hoTen, gioiTinh, ngaySinh, diaChi, soDT, trinhDo, MaBoMon);
                        // Cập nhật lại DataGridView

                        // Thông báo 
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        // Thông báo 
                        MessageBox.Show("Không thể thêm");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string maGiangVien = txtMaGV.Text;
                    string hoTen = txtTenGV.Text;
                    string gioiTinh = txtGioiTinh.Text;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string diaChi = txtDiaChi.Text;
                    string soDT = txtSoDT.Text;
                    string trinhDo = txtTrinhDo.Text;
                    string MaBoMon = txtMaBoMon.Text;

                    DialogResult message;
                    // Hiện hộp thoại hỏi đáp 
                    message = MessageBox.Show("Bạn có muốn cập nhật thông tin giảng viên", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (message == DialogResult.Yes)
                    {
                        dbGiangVien.UpdateGV(maGiangVien, hoTen, gioiTinh, ngaySinh, diaChi, soDT, trinhDo, MaBoMon);
                        // Thông báo 
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        // Thông báo 
                        MessageBox.Show("Không thể cập nhật");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
