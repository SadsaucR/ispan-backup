using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class mydb
    {
        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        SqlCommand cmd;

        public mydb()
        {
            sqlc = new SqlConnection("Data Source=DESKTOP-AVM54SB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            sqld = new SqlDataAdapter();
            ds = new DataSet();
            cmd = new SqlCommand();
        }
        public DataTable GetDataTable(string sqlcmd)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sqlcmd;
            cmd.Connection = sqlc;
            sqld.SelectCommand = cmd;
            sqld.Fill(dt);
            return dt;
        }

        public DataTable GetDataTable(string sqlcmd, string k1, string v1,string title)
        {
            DataTable dt = new DataTable();
            cmd.Connection = sqlc;
            cmd.CommandText = sqlcmd;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue(k1, v1);
            sqld.SelectCommand = cmd;
            //(dt.Columns).Items[0]
            sqld.Fill(dt);
            dt.Columns[0].ColumnName = title;
            return dt;
        }
    }
}
