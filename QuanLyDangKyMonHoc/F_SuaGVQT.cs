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

    public partial class F_SuaGVQT : Form
    {
        DataTable dtGiangVien = null;

        BSGiangVien dbGiangVien = new BSGiangVien();
        public F_SuaGVQT()
        {
            InitializeComponent();
        }

        private void F_SuaGVQT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dtGiangVien = new DataTable();
                dtGiangVien.Clear();
                DataSet ds = dbGiangVien.GetGV();
                dtGiangVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                gvThongTinGVSua.DataSource = dtGiangVien;
                // Thay đổi độ rộng cột 
                gvThongTinGVSua.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
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

        private void gvThongTinGVSua_SelectionChanged(object sender, EventArgs e)
        {
            if (gvThongTinGVSua.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvThongTinGVSua.SelectedRows[0];
                txtMaGV.Text = selectedRow.Cells["MaGiangVien"].Value.ToString();
                txtTenGV.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtGioiTinh.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSoDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txtTrinhDo.Text = selectedRow.Cells["TrinhDo"].Value.ToString();
                txtMaBoMon.Text = selectedRow.Cells["MaBoMon"].Value.ToString();
            }
        }
    }
}
