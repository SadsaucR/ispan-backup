using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom.Compiler;

namespace ADONET5
{
    internal class MyDB
    {
        #region 宣告變數
        private SqlConnection sqlc { get; set; }
        private SqlDataAdapter sqld { get; set; }
        private DataSet ds { get; set; }
        private SqlCommandBuilder sqlb { get; set; }
        #endregion


        public MyDB()
        {
            sqlc = new SqlConnection(ADONET5.Properties.Settings.Default.DW);
            sqld = new SqlDataAdapter();
            ds = new DataSet();
        }
        //public MyDB(string cnt)
        //{
        //    sqlc = new SqlConnection($"Data Source=localhost\\SQLEXPRESS;Initial Catalog={cnt};Integrated Security=True;TrustServerCertificate=True");
        //    sqld = new SqlDataAdapter();
        //    ds = new DataSet();
        //}

        public  DataTable  PikaGetDataTable(string code)
        {
            sqld.SelectCommand = new SqlCommand(code, sqlc);
            if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            sqld.Fill(ds, "DimCurrency");
            return ds.Tables["DimCurrency"];    
        }

        public int PikaInserter(DataTable dt)
        {

            SqlCommandBuilder sqlb = new SqlCommandBuilder(sqld);

            SqlCommand insert_cmd = sqlb.GetInsertCommand();

            sqld.InsertCommand = insert_cmd;
            
            int temp =sqld.Update(dt);

            return temp;
        }
    }
}
