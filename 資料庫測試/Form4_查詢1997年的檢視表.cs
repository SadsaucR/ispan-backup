using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 資料庫測試
{
    public partial class Form4_查詢1997年的檢視表 : Form
    {
        public Form4_查詢1997年的檢視表()
        {
            InitializeComponent();
        }
        private string conn = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private void Form4_查詢1997年的檢視表_Load(object sender, EventArgs e)
        {
            MyDB db = new MyDB(conn);
            comboBox1.DataSource = db.GetDataTable("select CategoryID,CategoryName from Categories");
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid = ((DataRowView)comboBox1.SelectedItem).Row.ItemArray[0].ToString();
            string price=textBox1.Text;

            //MessageBox.Show($"類:{cid} 類:{price}");

            string sql = "select CategoryID,CategoryName,ProductName,CAST(ProductSales as int) from [Sales by Category] where CategoryID =@cid and ProductSales >@price";
            Dictionary<string,string> dc = new Dictionary<string,string>();
            dc.Add("@cid", cid);
            dc.Add("@price",price);

            MyDB db = new MyDB(conn);
            DataTable tmp = db.GetDataTable(sql,dc);
            dataGridView1.DataSource =tmp;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
    }
}
