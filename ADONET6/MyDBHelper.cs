using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADONET6
{
    internal class MyDBHelper
    {
        private SqlConnection sqlc { get; set; }
        private SqlDataAdapter sqld { get; set; }
        private DataSet ds { get; set; }
        private SqlCommandBuilder sqlb { get; set; }

        public MyDBHelper()
        {
            sqlc = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;TrustServerCertificate=True");
            sqld = new SqlDataAdapter();
            ds = new DataSet();
        }
        public DataTable GetDataTable(string code)
        {
            sqld.SelectCommand = new SqlCommand(code, sqlc);
            if (ds.Tables["main"] != null) ds.Tables["main"].Clear();
            sqld.Fill(ds, "main");
            return ds.Tables["main"];
        }

        public bool InsertData(string code, string[] key, string[] values)
        {
            //將key,values傳入主程式的@key,@name中
            sqld.InsertCommand = new SqlCommand(code, sqlc);
            for (int i = 0; i < key.Length; i++)
            {
                sqld.InsertCommand.Parameters.AddWithValue(key[i], values[i]);
            }
            //宣告一個變數存放已新增的資料數
            sqlc.Open();
            int Insert_count = sqld.InsertCommand.ExecuteNonQuery();
            sqlc.Close();
            bool temp = (Insert_count == 1 ? true : false);
            return temp;
        }

        public void updateData(string code, string[] key, string[] values)
        {
            SqlCommand xa = sqlb.GetUpdateCommand();
            sqld.SelectCommand = xa;
            for (int i = 0; i < key.Length; i++)
            {
                sqld.UpdateCommand.Parameters.AddWithValue(key[i], values[i]);
            }
            //宣告一個變數存放已新增的資料數
            sqlc.Open();
            int Update_count = sqld.UpdateCommand.ExecuteNonQuery();
            sqlc.Close();
            bool temp = (Update_count == 1 ? true : false);
            //return temp;
            //sqld.Update(ds, "main");
            //sqld.UpdateCommand = new SqlCommand(sql, sqlc);
            //sqld.UpdateCommand.Parameters.AddWithValue("@AK", txtKey.Text);
            //sqld.UpdateCommand.Parameters.AddWithValue("@CN", txtName.Text);
            //sqld.UpdateCommand.Parameters.AddWithValue("@PCK", txtID.Text);
        }

    }

}
