using QuanLyDangKyMonHoc.BSLayer;
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
    public partial class F_SinhVienQT : Form
    {
        DataTable dtSinhVien = null;
        BSSinhVien dbSinhVien = new BSSinhVien();
        public F_SinhVienQT()
        {
            InitializeComponent();
        }

        private void F_SinhVienQT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSinhVien.LoadDDSV();
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                gvHienThongTinSinhVien.DataSource = dtSinhVien;
                // Thay đổi độ rộng cột 
                gvHienThongTinSinhVien.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvHienThongTinSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (gvHienThongTinSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvHienThongTinSinhVien.SelectedRows[0];
                txtMaSV.Text = selectedRow.Cells["MaSV"].Value.ToString();
                txtTenSV.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSoDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtMaLop.Text = selectedRow.Cells["MaLop"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSinhVien.SearchSV(txtTimKiemTheoMaSV.Text.Trim());
                dtSinhVien = ds.Tables[0];  
                // Đưa dữ liệu lên DataGridView 
                gvHienThongTinSinhVien.DataSource = dtSinhVien;
                // Thay đổi độ rộng cột 
                gvHienThongTinSinhVien.AutoResizeColumns();
                txtTimKiemTheoMaSV.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = gvHienThongTinSinhVien.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaSV = gvHienThongTinSinhVien.Rows[r].Cells[0].Value.ToString();
                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn xóa thông tin sinh viên", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbSinhVien.DeleteSV(strMaSV);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thể xóa");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text;
                string hoTen = txtTenSV.Text;
                string gioiTinh = txtGioiTinh.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string soDT = txtSoDT.Text; 
                string maLop = txtMaLop.Text;

                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn cập nhật thông tin sinh viên", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbSinhVien.UpdateSV(maSV,hoTen,gioiTinh,ngaySinh,diaChi,soDT,maLop);
                    // Cập nhật lại DataGridView
                    LoadData();
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {     
                string maSV = txtMaSV.Text;
                string hoTen = txtTenSV.Text;
                string gioiTinh = txtGioiTinh.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string diaChi = txtDiaChi.Text;
                string soDT = txtSoDT.Text;
                string maLop = txtMaLop.Text;

                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn thêm thông tin sinh viên", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbSinhVien.AddSV(maSV, hoTen, gioiTinh, ngaySinh, diaChi, soDT, maLop);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Thêm thành công!");
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
        private void ResetTextAll()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtMaLop.Text = "";
        }
    }
}
