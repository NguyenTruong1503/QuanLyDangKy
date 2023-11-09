using QuanLyDangKyMonHoc.DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyMonHoc.BSLayer
{
    internal class BSGiangVien
    {
        DBMain db = null;

        public BSGiangVien()
        {
            db = new DBMain();
        }
        public DataSet LoadDSGV()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadDSGV()", CommandType.Text);
        }
        public DataSet SearchGV(string MaGiangVien)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.VarChar);
            p1.Value = MaGiangVien;
            return db.ExcuteQueryDataSetWithParam("SELECT * FROM TimKiemGiangVienTheoMa(@string)", CommandType.Text, p1);
        }
        public DataSet GetGV()
        {
            return db.ExcuteQueryDataSet($"select * from getGiangVien()", CommandType.Text);
        }
        public DataSet DeleteGV(string MaGiangVien)
        {
            SqlParameter p1 = new SqlParameter("@MaGiangVien", SqlDbType.VarChar);
            p1.Value = MaGiangVien;
            return db.ExcuteQueryDataSetWithParam("proc_xoaGiangVien", CommandType.StoredProcedure, p1);
        }
        public DataSet UpdateGV(string MaGiangVien, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string TrinhDo, string MaBoMon)
        {
            SqlParameter p1 = new SqlParameter("@MaGiangVien", SqlDbType.VarChar);
            p1.Value = MaGiangVien;
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
            SqlParameter p7 = new SqlParameter("@TrinhDo", SqlDbType.NVarChar);
            p7.Value = TrinhDo;
            SqlParameter p8 = new SqlParameter("@MaBoMon", SqlDbType.VarChar);
            p8.Value = MaBoMon;
            return db.ExcuteQueryDataSetWithParam("CapNhatThongTinGiangVien", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8);
        }
        public DataSet AddGV(string MaGiangVien, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi, string SoDienThoai, string TrinhDo, string MaBoMon)
        {
            SqlParameter p1 = new SqlParameter("@MaGiangVien", SqlDbType.VarChar);
            p1.Value = MaGiangVien;
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
            SqlParameter p7 = new SqlParameter("@TrinhDo", SqlDbType.NVarChar);
            p7.Value = TrinhDo;
            SqlParameter p8 = new SqlParameter("@MaBoMon", SqlDbType.VarChar);
            p8.Value = MaBoMon;
            return db.ExcuteQueryDataSetWithParam("InsertGV", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8);
        }
    }
}
