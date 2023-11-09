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
    public partial class F_GiangVien : Form
    {
        public F_GiangVien()
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
            childForm.Dock= DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Current_Button_Click(Control button_click)
        {
            List<Control> controls = new List<Control>() { btnThongTin,btnThoiKhoaBieu,btnPhanCong,btnThongBao,btnThongBao };
            foreach (Control control in controls)
                if (control == button_click)
                    button_click.BackColor = Color.FromArgb(255, 204, 153);
                else control.BackColor = Color.Transparent;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnThongTin);
            OpenChildForm(new F_ThongTinGV());
            lblHeader.Text = btnThongTin.Text;
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnThoiKhoaBieu);
            OpenChildForm(new F_ThoiKhoaBieuGV());
            lblHeader.Text = btnThoiKhoaBieu.Text;
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnPhanCong);
            OpenChildForm(new F_PhanCongGV());
            lblHeader.Text = btnPhanCong.Text;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            Current_Button_Click(btnThongBao);
            OpenChildForm(new F_ThongBao());
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
