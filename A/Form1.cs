using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class Form1 : Form
    {
        string cs = "Data Source=DESKTOP-AVM54SB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        //需求描述：公司需要一個查詢客戶訂單商品的功能
        //表單視窗元件：不拘，請依照自己的想法設計
        //資料庫連線方式：不拘，請依照自己的想法設計
        //測試方式：
        //1. 使用者可以看見客戶清單
        //2. 使用者選擇客戶後，畫面出現該客戶購買過的商品
        

        private void Form1_Load(object sender, EventArgs e)
        {
            mydb db = new mydb();
            string cmdname = "select ContactName from Customers";

            comboBox1.DataSource=db.GetDataTable(cmdname);
            comboBox1.DisplayMember = "ContactName";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mydb db = new mydb();
            string cmd = "select ProductName from Customers \r\nLeft Join Orders on Customers.CustomerID = Orders.CustomerID\r\nLeft Join [Order Details] on Orders.OrderID = [Order Details].OrderID\r\nLeft Join Products on [Order Details].ProductID=Products.ProductID\r\nwhere ContactName = @name group by ContactName,ProductName";
            dataGridView1.DataSource = db.GetDataTable(cmd,"@name",comboBox1.Text,"購買過的東西");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
