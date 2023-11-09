using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyMonHoc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new F_DangNhap());
            Application.Run(new F_QuanTri());
            //Application.Run(new F_SinhVien());
            //Application.Run(new F_GiangVien());

            //Application.Run(new F_SinhVienQT());   
        }
    }
}
