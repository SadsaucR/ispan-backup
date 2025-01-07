using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET6
{
    public partial class Form1 : Form
    {
        MyDBHelper dd=new MyDBHelper();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt= dd.GetDataTable(sql);
            dataGridView1.DataSource = dt;
        }

        private void ButtonWhere_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt = dd.GetDataTable(sql);
            DataRow row = dt.NewRow();
            row["CurrencyKey"] = 106;
            row["CurrencyAlternateKey"] = "ZZZ";
            row["CurrencyName"] = "Pikachu";
            dt.Rows.Add(row);
            dd.InsertData(dt);
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            string sql = $"select CurrencyName  from DimCurrency where CurrencyAlternateKey = 'AWG'";
            dt = dd.GetDataTable(sql);
            textBox2.Text=dt.Rows[0].ItemArray[0].ToString();

        }
    }
}
