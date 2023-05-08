using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public static SqlConnection conn;
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
            conn.Close();
        }

        public static List<string> listProductName()
        {
            string sql = "SELECT product_name FROM Product";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            var data = new List<string>();
            data.Add("None");
            while (reader.Read())
            {
                string product_name = reader.GetString(0);
                data.Add(product_name);
            }
            conn.Close();
            return data;


        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            conn.Close();
            return dt;
        }
    }
}
