using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDangKyMonHoc.DBLayer
{
    internal class DBMain
    {
        static string un, pwd;
        public static string username
        {
            get
            {
                return un;
            }
            set
            {
                un = value;
            }
        }
        public static string password
        {
            get { return pwd; }
            set { pwd = value; }
        }
        string ConnStr = "Data Source=NGUYENTRUONG\\SQLEXPRESS;Initial Catalog=QuanLyDangKyMonHoc;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExcuteQueryDataSet(string strSQL, CommandType commType)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = commType;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            //MessageBox.Show(ds.Tables.Count.ToString());
            return ds;
        }

        public DataSet ExcuteQueryDataSetWithParam(string strSQL, CommandType commType, params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = commType;
            comm.Parameters.Clear();
            foreach (SqlParameter p in param)
            {
                comm.Parameters.Add(p);
            }
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            //MessageBox.Show(ds.Tables.Count.ToString());
            return ds;
        }

        public bool MyExcuteNonQuery(string strSQL, CommandType commType, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = commType;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public int ExcuteQueryScalar(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            int k = 0;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            if (param != null)
            {

                comm.Parameters.Clear();
                foreach (SqlParameter p in param)
                {
                    comm.Parameters.Add(p);
                }
            }
            try
            {
                k = Int32.Parse(comm.ExecuteScalar().ToString());
            }
            catch (SqlException e)
            {
                error = e.Message;
            }
            finally
            {
                conn.Close();
            }
            return k;
        }
    }
}
