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
    public partial class F_ChuongTrinhDaoTao : Form
    {
        DataTable dtChuongTrinhDaoTao = null;
        BSChuongTrinhDaoTao dbChuongTrinhDaoTao = new BSChuongTrinhDaoTao();
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public F_ChuongTrinhDaoTao()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            F_ThemCTDT f_them = new F_ThemCTDT();
            f_them.ShowDialog();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành 
                int r = gvHienThongTinCTDT.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaNganh = gvHienThongTinCTDT.Rows[r].Cells[0].Value.ToString();
                string strMaHP = gvHienThongTinCTDT.Rows[r].Cells[1].Value.ToString();
                Console.WriteLine(strMaNganh);
                Console.WriteLine(strMaHP);
                DialogResult message;
                // Hiện hộp thoại hỏi đáp 
                message = MessageBox.Show("Bạn có muốn xóa môn học này không", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (message == DialogResult.Yes)
                {
                    dbChuongTrinhDaoTao.DeleteCTDT(strMaNganh, strMaHP);
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
        private void LoadData()
        {
            try
            {
                dtChuongTrinhDaoTao = new DataTable();
                dtChuongTrinhDaoTao.Clear();
                DataSet ds = dbChuongTrinhDaoTao.LoadDSChuongTrinhDaoTao();
                dtChuongTrinhDaoTao = ds.Tables[0];
                gvHienThongTinCTDT.DataSource = dtChuongTrinhDaoTao;
                gvHienThongTinCTDT.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            F_SuaCTDT f_sua = new F_SuaCTDT();
            f_sua.ShowDialog();
            LoadData();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            try
            {
                string loaiTraCuu = "";
                loaiTraCuu += cbChuongTrinhDaoTao.SelectedItem;
                dtChuongTrinhDaoTao = new DataTable();
                dtChuongTrinhDaoTao.Clear();
                DataSet ds;
                if (loaiTraCuu.Trim() == "Mã học phần")
                {
                    ds = dbChuongTrinhDaoTao.SearchCTDT_maHP(txtHocPhan.Text.Trim());
                }
                else
                {
                    ds = dbChuongTrinhDaoTao.SearchCTDT_maNganh(txtHocPhan.Text.Trim());
                }
                dtChuongTrinhDaoTao = ds.Tables[0];
                gvHienThongTinCTDT.DataSource = dtChuongTrinhDaoTao;
                gvHienThongTinCTDT.AutoResizeColumns();
                txtHocPhan.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F_ChuongTrinhDaoTao_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
