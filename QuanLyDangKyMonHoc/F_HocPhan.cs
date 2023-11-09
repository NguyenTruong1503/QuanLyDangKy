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
    public partial class F_HocPhan : Form
    {
        public F_HocPhan()
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_SuaHocPhan());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new F_SuaHocPhan());
        }
    }
}
