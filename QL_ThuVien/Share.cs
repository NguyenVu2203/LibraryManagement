using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_ThuVien
{
    class Share
    {
        public SqlConnection conn;

        public string ConnectionString
        {
            get { return conn.ConnectionString; }
        }

        public Share()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\.NET\DoAn_.Net_Nhom10_QL_ThuVien\DoAn_.Net_Nhom10_QL_ThuVien\QL_ThuVien\QL_ThuVien.mdf;Integrated Security=True";
        }

        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }

        public bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                return false;
            }
            return true;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            try
            {
                this.OpenConn();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }catch(Exception ex)
            {
                string loi = ex.Message;
                cmd.Dispose();
                conn.Close();

            }
            return dt;
        }

        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }

        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
    }
}
