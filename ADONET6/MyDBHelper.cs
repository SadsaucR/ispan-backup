using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            sqlc = new SqlConnection(ADONET6.Properties.Settings.Default.DW);
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

        public int InsertData(DataTable dt)
        {
            sqlb = new SqlCommandBuilder(sqld);
            SqlCommand insert_cmd = sqlb.GetInsertCommand();
            sqld.InsertCommand = insert_cmd;
            int temp = sqld.Update(dt);
            return temp;
        }

        public void checkkey()
        {

        }

    }

}
