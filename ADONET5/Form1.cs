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

namespace ADONET5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataTable dt;
        MyDB dd = new MyDB();

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dataGridView1.DataSource = dd.PikaGetDataTable(sql);
        }

        private void ButtonWhere_Click(object sender, EventArgs e)
        {
            //MyDB cc = new MyDB("Northwind");
            //string sql = "select * from Employees";
            //dataGridView1.DataSource = cc.PikaGetDataTable(sql);
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt = dd.PikaGetDataTable(sql);

            DataRow row =dt.NewRow() ;
            row["CurrencyKey"] = 106;
            row["CurrencyAlternateKey"] = "ZZZ";
            row["CurrencyName"] = "Pikachu";
            dt.Rows.Add(row);
            dd.PikaInserter(dt);
        }
    }
}
