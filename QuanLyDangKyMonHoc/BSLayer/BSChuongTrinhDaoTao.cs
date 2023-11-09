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
    internal class BSChuongTrinhDaoTao
    {
        DBMain db = null;
        public BSChuongTrinhDaoTao()
        {
            db = new DBMain();
        }
        public DataSet LoadDSChuongTrinhDaoTao()
        {
            return db.ExcuteQueryDataSet($"select * from V_DANHSACHCHUONGTRINHDAOTAO", CommandType.Text);
        }
        public DataSet GetCTDT()
        {
            return db.ExcuteQueryDataSet($"select * from getCTDT()", CommandType.Text);
        }
        public DataSet SearchCTDT_maHP(string maHP)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.VarChar);
            p1.Value = maHP;
            return db.ExcuteQueryDataSetWithParam("select * from TimKiemChuongTrinhDaoTao_MaHocPhan(@string)", CommandType.Text, p1);

        }
        public DataSet SearchCTDT_maNganh(string maNganh)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = maNganh;
            return db.ExcuteQueryDataSetWithParam("select * from TimKiemChuongTrinhDaoTao_MaNganh(@string)", CommandType.Text, p1);
        }
        public DataSet DeleteCTDT(string MaNganh, string MaHocPhan)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.VarChar);
            p1.Value = MaNganh;
            SqlParameter p2 = new SqlParameter("@MaHocPhan", SqlDbType.VarChar);
            p2.Value = MaHocPhan;
            Console.WriteLine(p1.Value + " " + p2.Value + 'h');
            return db.ExcuteQueryDataSetWithParam("[dbo].[XoaChuongTrinhDaoTao]", CommandType.StoredProcedure, p1, p2);
        }
        public DataSet AddCTDT(string MaNganh, string MaHocPhan, string LoaiHocPhan)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.VarChar);
            p1.Value = MaNganh;
            SqlParameter p2 = new SqlParameter("@MaHocPhan", SqlDbType.VarChar);
            p2.Value = MaHocPhan;
            SqlParameter p3 = new SqlParameter("@LoaiHocPhan", SqlDbType.NVarChar);
            p3.Value = LoaiHocPhan;

            return db.ExcuteQueryDataSetWithParam("[dbo].[ThemChuongTrinhDaoTao]", CommandType.StoredProcedure, p1, p2, p3);
        }
        public DataSet UpdateCTDT(string maNganh, string maHocPhan, string loaiHocPhan)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.VarChar);
            p1.Value = maNganh;
            SqlParameter p2 = new SqlParameter("@MaHocPhan", SqlDbType.VarChar);
            p2.Value = maHocPhan;
            SqlParameter p3 = new SqlParameter("@LoaiHocPhan", SqlDbType.NVarChar);
            p3.Value = loaiHocPhan;
            return db.ExcuteQueryDataSetWithParam("[dbo].[CapNhatChuongTrinhDaoTao]", CommandType.StoredProcedure, p1, p2, p3);
        }
    }
}
