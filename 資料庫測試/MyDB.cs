using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 資料庫測試
{
    internal class MyDB
    {
        private string connstring;

        public MyDB()
        {

        }
        //建立資料庫連線
        public MyDB(string userConnString) 
        {
            connstring = userConnString;
        }
        public DataTable GetDataTable(string code)
        {
            SqlConnection sqlc = new SqlConnection(connstring);
            SqlDataAdapter sqld = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlc;
            cmd.CommandText = code;

            sqld.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqld.Fill(dt);
            return dt;
        }



        public DataTable GetDataTable(string userSQL,string pkey,string pvalue)
        {
            SqlConnection sqlc = new SqlConnection(connstring);
            SqlDataAdapter sqld = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlc;
            cmd.CommandText = userSQL;

            cmd.Parameters.AddWithValue(pkey, pvalue);

            sqld.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqld.Fill(dt);
            return dt;
        }

       public DataTable GetDataTable(string userSQL, Dictionary<string, string> userDie)
        {
            SqlConnection sqlc = new SqlConnection(connstring);
            SqlDataAdapter sqld = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlc;
            cmd.CommandText = userSQL;

            foreach (KeyValuePair<string,string> item in userDie)
            {
                cmd.Parameters.AddWithValue (item.Key, item.Value);
            }

            //cmd.Parameters.AddWithValue(pkey, pvalue);

            sqld.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqld.Fill(dt);
            return dt;
        }


    }
}
