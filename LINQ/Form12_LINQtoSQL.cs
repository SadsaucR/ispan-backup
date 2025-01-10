using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form12_LINQtoSQL : Form
    {
        public Form12_LINQtoSQL()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //MYDataClasses.dbml 中的類別
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
            //宣告匿名型態，查詢語法
            var select = from data in pika.Products select data;
            //print out
            dataGridView1.DataSource = select;
        }
        //where
        private void button2_Click(object sender, EventArgs e)
        {
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
            var where = from row in pika.Products
                                    where row.ProductID == 1
                                    select row;
            dataGridView1.DataSource = where;
        }
        //join 
        //我想要同時顯示main,part
        //使用之前的new int[] {1,2,3,4}
        private void button3_Click(object sender, EventArgs e)
        {
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
            var join = from part in pika.Order_Details
                                join main in pika.Products
                                on part.ProductID equals main.ProductID
                               //可追加where條件
                               //where main.ProductID == 1 
                               select new { 產品名=main.ProductName,   編號=part.OrderID };
            dataGridView1.DataSource = join;
        }
    }
}
