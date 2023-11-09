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
    public partial class F_QuanTri : Form
    {
        public F_QuanTri()
        {
            InitializeComponent();
        }
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

        private void Current_Button_Click(Control button_click)
        {
            List<Control> controls = new List<Control>() { btnSinhVien,btnGiangVien,btnHocPhan,btnChuongTrinhDaoTao,btnThongBao };
            foreach (Control control in controls)
                if (control == button_click)
                    button_click.BackColor = Color.FromArgb(255, 204, 153);
                else control.BackColor = Color.Transparent;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnSinhVien);
            OpenChildForm(new F_SinhVienQT());
            lblHeader.Text = btnSinhVien.Text;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnGiangVien);
            OpenChildForm(new F_GiangVienQT());
            lblHeader.Text = btnGiangVien.Text;
        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnHocPhan);
            OpenChildForm(new F_HocPhan());
            lblHeader.Text = btnHocPhan.Text;
        }

        private void btnChuongTrinhDaoTao_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnChuongTrinhDaoTao);
            OpenChildForm(new F_ChuongTrinhDaoTao());
            lblHeader.Text = btnChuongTrinhDaoTao.Text;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnThongBao);
            OpenChildForm(new F_GuiThongBao());
            lblHeader.Text = btnThongBao.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnThoat);
            F_DangNhap fdangnhap = new F_DangNhap();
            this.Hide();
            fdangnhap.ShowDialog();
            this.Close();
        }
    }
}
