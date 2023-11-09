using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyMonHoc.DAO
{
    public class GiangVien
    {
        public readonly string MaGiangVien;
        public readonly string HoTen;
        public readonly string GioiTinh;
        public readonly DateTime NgaySinh;
        public readonly string TrinhDo;
        public readonly string DiaChi;
        public readonly string SoDienThoai;
        public readonly string MaBoMon;

        public GiangVien(string MaGiangVien, string HoTen, string GioiTinh, DateTime NgaySinh, string TrinhDo, string DiaChi, string MaBoMon, string SoDienThoai)
        {
            this.MaGiangVien = MaGiangVien;
            this.HoTen=HoTen;   
            this.GioiTinh=GioiTinh; 
            this.NgaySinh=NgaySinh; 
            this.TrinhDo=TrinhDo;
            this.DiaChi=DiaChi;
            this.SoDienThoai=SoDienThoai;
            this.MaBoMon=MaBoMon;   
        }
    }
    
}
