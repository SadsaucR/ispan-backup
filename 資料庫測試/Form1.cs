using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 資料庫測試
{
    //LINQ to SQL 用法  先在專案加入Linq to SQL Class

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=DESKTOP-1VJ4VUO;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection sqlc = new SqlConnection(connstr);
            SqlDataAdapter sqld = new SqlDataAdapter();
            
            //LINQ 查詢語法
            var result = from p in 
                         where p.ID == 1
                         select p;
        }
    }
}
