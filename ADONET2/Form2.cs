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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employees";

           string conn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServerCertificate = True";

            // 新! SqlConnection 設定連線
            SqlConnection apple = new SqlConnection(conn);

            //新! SqlDataAdapter
            SqlDataAdapter bee = new SqlDataAdapter(sql, apple);
            DataSet cat = new DataSet();
            bee.Fill(cat);

            this.dataGridView1.DataSource = cat.Tables[0];

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ADONET2.Properties.Settings.Default.NorthwindConnectionString;
            SqlConnection cat = new SqlConnection(textBox1.Text);
            SqlDataAdapter dog = new SqlDataAdapter("select  Photo from Employees",cat);
            DataSet egg = new DataSet();
            dog.Fill(egg, "Pikachu");

            dataGridView2.DataSource = egg.Tables["Pikachu"];
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
