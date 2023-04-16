using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection conn;
        public static void connect()
        {
            string s = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn = new SqlConnection(s);
            conn.Open();

        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
