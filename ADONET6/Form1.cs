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
using System.Xml.Linq;

namespace ADONET6
{
    public partial class Form1 : Form
    {
        MyDBHelper dd;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dd = new MyDBHelper();
            dt = new DataTable();
        }
        //按鈕1:列出DimCurrency資料表
        private void ButtonAll_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt = dd.GetDataTable(sql);
            dataGridView1.DataSource = dt;
        }
        //按鈕2:將選取資料列綁定至textbox中
        private void ButtonWhere_Click(object sender, EventArgs e)
        {
            string sql = "select * from DimCurrency";
            dt = dd.GetDataTable(sql);
            dataGridView1.DataSource = dt;
            //初始化 三個textbox
            id.DataBindings.Clear();
            key.DataBindings.Clear();
            name.DataBindings.Clear();

            //綁定資料:DataBindings.Add(屬性名稱,來源DT,資料項名稱)
            id.DataBindings.Add("text", dt, "currencyKey");
            key.DataBindings.Add("text", dt, "currencyAlternateKey");
            name.DataBindings.Add("text", dt, "currencyName");
        }
        //按鈕3:判斷資料是否重複並新增
        private void ButtonTest_Click(object sender, EventArgs e)
        {
            //將textbox(Key)中的值設為篩選條件
            string sql = $"select *  from DimCurrency where CurrencyAlternateKey = '{key.Text}'";
            dt = dd.GetDataTable(sql);
            string xb;
            //當dt中存在資料時，清空xb
            if (dt.Rows.Count > 0)
                xb = dt.Rows[0].ItemArray[2].ToString();
            else
                xb = string.Empty;
            //宣告@Key,@Name以存放欲更新的資料
            string sql2 = "insert into DimCurrency(CurrencyAlternateKey,CurrencyName) values (@Key,@Name)";

            if (xb != string.Empty)
                MessageBox.Show($"此縮寫已使用，不可使用，名為{xb}");
            else
            {
                string[] k = { "@Key", "@Name" };
                string[] v = { key.Text, name.Text };
                bool check = dd.InsertData(sql2, k, v);
                if (check)
                    MessageBox.Show($"新增資料成功!");
                else
                    MessageBox.Show($"新增資料失敗!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"update DimCurrency set CurrencyAlternateKey=@Key,CurrencyName=@Name where CurrencyKey = @Id";

        }
    }
}
