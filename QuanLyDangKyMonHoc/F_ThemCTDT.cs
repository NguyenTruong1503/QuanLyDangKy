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
    public partial class F_ThemCTDT : Form
    {
        DataTable dtCTDT = null;

        BSChuongTrinhDaoTao dbCTDT = new BSChuongTrinhDaoTao();
        public F_ThemCTDT()
        {
            InitializeComponent();
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
                message = MessageBox.Show("Bạn có muốn thêm thông tin giảng viên", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbCTDT.AddCTDT(maNganh, maHocPhan, loaiHP);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
