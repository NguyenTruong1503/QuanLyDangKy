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
    internal class BSLopHocPhan
    {
        DBMain db = null;
        string err = null;
        public BSLopHocPhan()
        {
            db = new DBMain();
        }
        public DataSet DeleteLopHocPhan(string MaLopHP)
        {
            SqlParameter p1 = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            p1.Value = MaLopHP;

            return db.ExcuteQueryDataSetWithParam("DeleteLopHocPhan", CommandType.StoredProcedure, p1);
        }
    }
}
