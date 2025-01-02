using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADONET3
{
    public partial class Form1 : Form
    {

        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        SqlCommand cmd;
        //自訂函數 Titletrans 用途:將columns列命名
        //自訂函數 cmdin 用途:if移除重複資料，將sqlcode字串帶入adapter中,並將運行結果帶入DataSet中

        public void Titletrans()
        {
            string[] Title = { "ID", "名", "姓", "標題" };
            for (int i = 0; i < Title.Length; i++)
            {
                this.dataGridView1.Columns[i].HeaderText = Title[i];
            }
        }
        public void cmdin(string code,string tbname)
        {
            if (ds.Tables[tbname] != null)
            {
                ds.Tables[tbname].Clear();
            }
            
            SqlCode.Text = code;
            cmd = new SqlCommand($"{code}", sqlc);
            sqld.SelectCommand = cmd;
            sqld.Fill(ds, $"{tbname}");
            dataGridView1.DataSource = ds.Tables[tbname];
            Titletrans();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlc =new SqlConnection(ADONET3.Properties.Settings.Default.NorthwindConnectionString);
            sqld = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            cmdin("select * from Employees", "All");
        }

        private void ButtonWhere_Click(object sender, EventArgs e)
        {
            if(schinput.Text != null)
            cmdin($"select * from Employees where EmployeeID = {schinput.Text}", "Where");
            else
                cmdin("select * from Employees", "Where");
        }

        //阻擋惡意code 防止攻擊
        private void ButtonTest_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employees where EmployeeID = @EmployeeID";
            sqld.SelectCommand = new SqlCommand(sql, sqlc);
            sqld.SelectCommand.Parameters.AddWithValue("@EmployeeID", schinput.Text);
            sqld.Fill(ds, "test");
            dataGridView1.DataSource = ds.Tables["test"];
        }
    }
}
