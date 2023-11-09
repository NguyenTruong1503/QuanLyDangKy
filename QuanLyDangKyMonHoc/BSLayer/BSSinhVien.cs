using QuanLyDangKyMonHoc.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDangKyMonHoc.BSLayer;
using System.Data.SqlClient;

namespace QuanLyDangKyMonHoc.BSLayer
{
    internal class BSSinhVien
    {
        DBMain db = null;

        public BSSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LoadDDSV()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadDSSV()",CommandType.Text);
        }
        public DataSet SearchSV(string maSV)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.VarChar);
            p1.Value = maSV;
            return db.ExcuteQueryDataSetWithParam("SELECT * FROM TimKiemSinhVienTheoMa(@string)", CommandType.Text, p1);
        }
        public DataSet DeleteSV(string MaSV)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            return db.ExcuteQueryDataSetWithParam("XoaThongTinSV", CommandType.StoredProcedure, p1);
        }
        public DataSet UpdateSV(string MaSV, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi,string SoDienThoai, string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@HoTen", SqlDbType.NVarChar);
            p2.Value = HoTen;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.Date);
            p4.Value = NgaySinh.Date;
            SqlParameter p5 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            p5.Value = DiaChi;
            SqlParameter p6 = new SqlParameter("@SoDienThoai", SqlDbType.VarChar);
            p6.Value = SoDienThoai;
            SqlParameter p7 = new SqlParameter("@MaLop", SqlDbType.VarChar);
            p7.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("CapNhatThongTinSinhVien", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7);
        }
        public DataSet AddSV(string MaSV, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@HoTen", SqlDbType.NVarChar);
            p2.Value = HoTen;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.Date);
            p4.Value = NgaySinh.Date;
            SqlParameter p5 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            p5.Value = DiaChi;
            SqlParameter p6 = new SqlParameter("@SoDienThoai", SqlDbType.VarChar);
            p6.Value = SoDienThoai;
            SqlParameter p7 = new SqlParameter("@MaLop", SqlDbType.VarChar);
            p7.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("InsertSV", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7);
        }
    }
}
