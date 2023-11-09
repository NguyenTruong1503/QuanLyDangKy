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
    public partial class F_SuaCTDT : Form
    {
        DataTable dtCTDT = null;

        BSChuongTrinhDaoTao dbCTDT = new BSChuongTrinhDaoTao();
        public F_SuaCTDT()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtCTDT = new DataTable();
                dtCTDT.Clear();
                DataSet ds = dbCTDT.GetCTDT();
                dtCTDT = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                gvThongTinCTDT.DataSource = dtCTDT;
                // Thay đổi độ rộng cột 
                gvThongTinCTDT.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F_SuaCTDT_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvThongTinCTDT_SelectionChanged(object sender, EventArgs e)
        {
            if (gvThongTinCTDT.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvThongTinCTDT.SelectedRows[0];
                txtMaNganh.Text = selectedRow.Cells["MaNganh"].Value.ToString();
                txtMaHP.Text = selectedRow.Cells["MaHocPhan"].Value.ToString();
                txtTenHP.Text = selectedRow.Cells["TenHocPhan"].Value.ToString();
                txtLoaiHP.Text = selectedRow.Cells["LoaiHocPhan"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maNganh = txtMaNganh.Text;
                string maHocPhan = txtMaHP.Text;
                string tenHP = txtTenHP.Text;
                string loaiHP = txtLoaiHP.Text;

                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn cập nhật thông tin chương trình đào tạo", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbCTDT.UpdateCTDT(maNganh, maHocPhan, loaiHP);
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
    }
}
