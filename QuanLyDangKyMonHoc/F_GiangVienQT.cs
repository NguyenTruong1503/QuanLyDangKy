using QuanLyDangKyMonHoc.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyMonHoc
{
    public partial class F_GiangVienQT : Form
    {
        DataTable dtGiangVien = null;
        
        BSGiangVien dbGiangVien = new BSGiangVien();
        public F_GiangVienQT()
        {
            InitializeComponent();
        }

        private void F_GiangVienQT_Load(object sender, EventArgs e)
        {

            LoadData();
           

            //dtgTTCongDan.Columns[3].Visible = false;
        }

        private void LoadData()
        {
            try
            {
                dtGiangVien = new DataTable();
                dtGiangVien.Clear();
                DataSet ds = dbGiangVien.LoadDSGV();
                dtGiangVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                gvHienThongTinGiangVien.DataSource = dtGiangVien;
                // Thay đổi độ rộng cột 
                gvHienThongTinGiangVien.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dtGiangVien = new DataTable();
                dtGiangVien.Clear();
                DataSet ds = dbGiangVien.SearchGV(txtTimKiemTheoMaGV.Text.Trim());
                dtGiangVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                gvHienThongTinGiangVien.DataSource = dtGiangVien;
                // Thay đổi độ rộng cột 
                gvHienThongTinGiangVien.AutoResizeColumns();
                txtTimKiemTheoMaGV.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            F_ThemGVQT f_them = new F_ThemGVQT(null,true);
            f_them.ShowDialog();
            LoadData();

            //try
            //{

            //    string maGiangVien = txtMaGV.Text;
            //    string hoTen = txtTenGV.Text;
            //    string gioiTinh = txtGioiTinh.Text;
            //    DateTime ngaySinh = dtpNgaySinh.Value;
            //    string diaChi = txtDiaChi.Text;
            //    string soDT = txtSoDT.Text;
            //    string trinhDo = txtTrinhDo.Text;
            //    string MaBoMon = txtBoMon.Text;

            //    DialogResult message;
            //    // Hiện hộp thoại hỏi đáp 
            //    message = MessageBox.Show("Bạn có muốn thêm thông tin sinh viên", "Trả lời",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    // Kiểm tra có nhắp chọn nút Ok không? 
            //    if (message == DialogResult.Yes)
            //    {
            //        dbGiangVien.AddGV(maGiangVien, hoTen, gioiTinh, ngaySinh, diaChi, soDT, trinhDo, MaBoMon);
            //        // Cập nhật lại DataGridView
            //        LoadData();
            //        // Thông báo 
            //        MessageBox.Show("Thêm thành công!");
            //    }
            //    else
            //    {
            //        // Thông báo 
            //        MessageBox.Show("Không thể thêm");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            //int row = gvHienThongTinGiangVien.CurrentCell.RowIndex;
            // string magv = gvHienThongTinGiangVien.Rows[row].Cells[0].Value.ToString();
            //F_ThemGVQT f_them = new F_ThemGVQT(magv,false);

            F_SuaGVQT f_sua = new F_SuaGVQT();
            f_sua.ShowDialog();


           

           // f_them.ShowDialog();
            LoadData();
            //try
            //{
            //    string maGiangVien = txtMaGV.Text;
            //    string hoTen = txtTenGV.Text;
            //    string gioiTinh = txtGioiTinh.Text;
            //    DateTime ngaySinh = dtpNgaySinh.Value;
            //    string diaChi = txtDiaChi.Text;
            //    string soDT = txtSoDT.Text;
            //    string trinhDo = txtTrinhDo.Text;
            //    string MaBoMon = txtBoMon.Text;

            //    DialogResult message;
            //    // Hiện hộp thoại hỏi đáp 
            //    message = MessageBox.Show("Bạn có muốn cập nhật thông tin giảng viên", "Trả lời",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    // Kiểm tra có nhắp chọn nút Ok không? 
            //    if (message == DialogResult.Yes)
            //    {
            //        dbGiangVien.UpdateGV(maGiangVien, hoTen, gioiTinh, ngaySinh, diaChi, soDT, trinhDo, MaBoMon);
            //        // Cập nhật lại DataGridView
            //        LoadData();
            //        // Thông báo 
            //        MessageBox.Show("Cập nhật thành công!");
            //    }
            //    else
            //    {
            //        // Thông báo 
            //        MessageBox.Show("Không thể cập nhật");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = gvHienThongTinGiangVien.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaGiangVien = gvHienThongTinGiangVien.Rows[r].Cells[0].Value.ToString();
                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn xóa thông tin giảng viên", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbGiangVien.DeleteGV(strMaGiangVien);
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

        private void gvHienThongTinGiangVien_SelectionChanged(object sender, EventArgs e)
        {
            if (gvHienThongTinGiangVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvHienThongTinGiangVien.SelectedRows[0];
                txtMaGV.Text = selectedRow.Cells["MaGiangVien"].Value.ToString();
                txtTenGV.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSoDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtTrinhDo.Text = selectedRow.Cells["TrinhDo"].Value.ToString();
                txtBoMon.Text = selectedRow.Cells["TenBoMon"].Value.ToString();
                txtKhoa.Text = selectedRow.Cells["TenKhoa"].Value.ToString();

                if (selectedRow.Cells["MaGiangVien"].Value.ToString() == selectedRow.Cells["TruongKhoa"].Value.ToString())
                {
                    txtChucVu.Text = "Trưởng Khoa";
                }
                else if (selectedRow.Cells["MaGiangVien"].Value.ToString() == selectedRow.Cells["TruongBoMon"].Value.ToString())
                {
                    txtChucVu.Text = "Trưởng Bộ Môn";
                }
                else
                    txtChucVu.Text = "";
            }
        }
        public class MyDataCollection
        {
            public string MaGiangVien;
            public string HoTen;
            public string GioiTinh;
            public DateTime NgaySinh;
            public string TrinhDo;
            public string DiaChi;
            public string SoDienThoai;
            public string MaBoMon;
        }
    }
}
