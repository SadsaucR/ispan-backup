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

namespace ADONET2
{
    public partial class Form3 : Form
    {
        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        SqlCommand cmd;

        public Form3()
        {
            InitializeComponent();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            sqlc = new SqlConnection(ADONET2.Properties.Settings.Default.NorthwindConnectionString);
            sqld = new SqlDataAdapter();
            ds=new DataSet();
        }

        public void cmdin(string code)
        {
            cmd = new SqlCommand($"{code}", sqlc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ds.Tables["data"]!=null)
            {
                ds.Tables["data"].Clear();
            }
            cmdin("select * from Employees");
            sqld.SelectCommand=cmd;
            sqld.Fill(ds,"data");
            dataGridView1.DataSource = ds.Tables["data"];

            dataGridView1.Columns[0].HeaderText = "編號";
            dataGridView1.Columns[1] .HeaderText="姓";
            dataGridView1.Columns[2].HeaderText="名";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ds.Tables["data"] != null)
            {
                ds.Tables["data"].Clear();
            }
            cmdin("select * from Employees where EmployeeID = 1");
            sqld.SelectCommand = cmd;
            sqld.Fill(ds, "data");
            dataGridView1.DataSource = ds.Tables["data"];
            dataGridView1.Columns[0].HeaderText = "編號";
            dataGridView1.Columns[1].HeaderText = "姓";
            dataGridView1.Columns[2].HeaderText = "名";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "";
            SqlConnection sqlc = new SqlConnection(ADONET2.Properties.Settings.Default.NorthwindConnectionString);
            SqlDataAdapter sqld = new SqlDataAdapter(sql,sqlc);
            DataSet ds = new DataSet();
            sqld.Fill(ds, "Pikachu");
            dataGridView1.DataSource = ds.Tables["Pikachu"];
        }

    }
}
