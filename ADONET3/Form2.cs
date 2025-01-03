using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET3
{
    public partial class Form2 : Form
    {
        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        SqlCommand cmd;
        int currentpage;
        int currentdata;
        int eachpage = 8;
        int totaldata;
        int totalpage;


        public void cmdin(string code, string tbname)
        {
            if (ds.Tables[tbname] != null)
            {
                ds.Tables[tbname].Clear();
            }
            label2.Text = code;
            cmd = new SqlCommand($"{code}", sqlc);
            sqld.SelectCommand = cmd;
            sqld.Fill(ds, $"{tbname}");
            dataGridView1.DataSource = ds.Tables[tbname];
        }

        public void chkpage()
        {

            if (currentpage >= totalpage - 1)
                ButtonPgdn.Enabled = false;

            else
                ButtonPgdn.Enabled = true;

            if (currentpage == 0)
                ButtonPgup.Enabled = false;

            else
                ButtonPgup.Enabled = true;
        }

        public void display()
        {
            label1.Text = $"第{currentpage+1}頁，顯示第{currentdata+1}筆到第{currentdata+eachpage}筆資料，總共是{totaldata}筆資料";
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ButtonSelect.Text = "選取";
            ButtonPgup.Text = "上一頁";
            ButtonPgdn.Text = "下一頁";
            label1.Text = "已選出的資料列:";
            sqlc= new SqlConnection(ADONET3.Properties.Settings.Default.DW2022);
            sqld = new SqlDataAdapter();
            ds = new DataSet();
            ButtonPgup.Enabled = false;
            ButtonPgdn.Enabled = false;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            currentpage = 0;
            currentdata = 0;
            ButtonPgup.Enabled = true;
            ButtonPgdn.Enabled = true;
            //cmdin($"select * from Employees order by EmployeeID", "sub");
            cmdin($"select * from DimCurrency order by CurrencyKey","sub");
            totaldata = ds.Tables["sub"].Rows.Count;
            totalpage = (int)Math.Ceiling((double)totaldata / eachpage);
            //cmdin($"select * from Employees order by EmployeeID offset {currentdata} rows fetch next {eachpage} rows only","main");
            cmdin($"select * from DimCurrency order by CurrencyKey OFFSET {currentdata}  ROWS FETCH NEXT {eachpage}   ROWS ONLY","main");
            chkpage();
            display();
        }

        private void ButtonPgdn_Click(object sender, EventArgs e)
        { 
            currentpage++;
            chkpage();
            currentdata += eachpage;
            cmdin($"select * from DimCurrency order by CurrencyKey OFFSET {currentdata}  ROWS FETCH NEXT {eachpage}   ROWS ONLY", "main");
            display();
        }

        private void ButtonPgup_Click(object sender, EventArgs e)
        {
            currentpage--;
            chkpage();
            currentdata -= eachpage;
            cmdin($"select * from DimCurrency order by CurrencyKey OFFSET {currentdata}  ROWS FETCH NEXT {eachpage}   ROWS ONLY","main");
            display();   
        }
        }
    }
