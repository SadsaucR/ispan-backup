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
    public partial class Form1_過年前練習查詢 : Form
    {
        public Form1_過年前練習查詢()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string sqlcmd = "select * from products";
            SqlDataAdapter sqld = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            textBox1.Text = sqlcmd;
            sqld.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqld.Fill(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            string sqlcmd = "select * from products";
            dataGridView1.DataSource = db.GetDataTable(sqlcmd);
            textBox1.Text = sqlcmd;
        }

        //button 3 test code : select * from products where CategoryID = @c 
        //textbox3~4 分別填入 @c,1
        private void button3_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            MyDB db = new MyDB(connstring);
            dataGridView1.DataSource = db.GetDataTable(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        //button 4 test code : select * from products where CategoryID = @c and UnitPrice = @p
        //textbox2~5 分別填入 @c,1,@p,18
        private void button4_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            MyDB db = new MyDB(connstring);
            Dictionary<string, string> condition = new Dictionary<string, string>();
            condition.Add(textBox2.Text, textBox3.Text);
            condition.Add(textBox4.Text, textBox5.Text);
            dataGridView1.DataSource = db.GetDataTable(textBox1.Text,condition);
        }
    }
}
