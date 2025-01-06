using System;
using System.CodeDom.Compiler;
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
using System.Xml.Serialization;

namespace ADONET4
{
    public partial class Form1 : Form
    {
        #region 變數
        //宣告會跨函數的變數
        private int currentPage;
        private int[,] Pages;
        private int temp=0;
        private int totalPages;
        private int eachPage;

        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        public void setTotalpage()
        {
            string sql = "select Count(*) from Employees";
            sqld.SelectCommand=new SqlCommand(sql,sqlc);
            sqld.Fill(ds,"sub");
            totalPages= (int)ds.Tables["sub"].Rows[0].ItemArray[0];
            label2.Text = $"總資料數為{totalPages.ToString()}";

        }

        public void calc()
        {
            Pages = new int[temp,2];

            for (int i = 0; i < Pages.GetLength(0); i++) 
            {
                Pages[i,0]=i*eachPage;
                if (i == (Pages.GetLength(0) - 1))
                {
                    Pages[i, 1] = totalPages - (i * eachPage);
                }
                else
                {
                    Pages[i,1]=eachPage;
                }
            }
        }

        public void setDataGridView(int start,int next)
        {
            eachPage = next;
            string sql = $"select * from Employees order by EmployeeID offset @start rows fetch next @next rows only";
            sqld.SelectCommand=new SqlCommand (sql,sqlc);
            sqld.SelectCommand.Parameters.AddWithValue(@"start",start);
            sqld.SelectCommand.Parameters.AddWithValue(@"next", next);
            if (ds.Tables["main"] != null) ds.Tables["main"].Clear();
            sqld.Fill(ds, "main");
            dataGridView1.DataSource = ds.Tables["main"];
        }

        public void setButton(bool startEnable,bool preEnable,bool nextEnable)
        {
            ButtonSelect.Enabled = startEnable;
            ButtonPgup.Enabled = preEnable;
            ButtonPgdn.Enabled = preEnable;
        }



        public int getTablepage()
        {
            return totalPages/eachPage+((totalPages % eachPage !=0)?1:0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlc = new SqlConnection(ADONET4.Properties.Settings.Default.NW);
            sqld = new SqlDataAdapter();
            ds= new DataSet();
            eachPage = 3;
            setTotalpage();
            label3.Text=getTablepage().ToString();
            calc();
            //setDataGridView(0,3);
            setButton(true, false, false);
        }

        private void setLabel(int start,int next)
        {
            label1.Text = $"第{start + 1}筆-第{start + next}筆，共{totalPages}";
        }
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            currentPage++;
            setDataGridView(Pages[currentPage, 0], Pages[currentPage, 1]);
            setLabel(Pages[currentPage, 0], Pages[currentPage, 1]);
            setButton(false, false, true);
            
        }

        private void ButtonPgup_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPgdn_Click(object sender, EventArgs e)
        {

        }
    }
}
