using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADONET2
{
    public partial class Form1 : Form
    {
        private string test;
        Pokemon pokemon = new Pokemon();
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("jigglypuff");
            textBox1.Text += "jigglypuff";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Employees' 資料表。您可以視需要進行移動或移除。
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
            Console.WriteLine("pikachu");
            textBox1.Text += "pikachu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //更改資料行標題
            //方法一
            //this.employeeIDDataGridViewTextBoxColumn.HeaderText = "幹";
            //this.lastNameDataGridViewTextBoxColumn.HeaderText = "三小";
            //this.firstNameDataGridViewTextBoxColumn.HeaderText = "操";

            //方法二
            //this.dataGridView1.Columns[0].HeaderText = "幹";
            //this.dataGridView1.Columns[1].HeaderText =  "三小";
            //this.dataGridView1.Columns[2].HeaderText = "操";

            //方法三 豬頭在用的
            //this.dataGridView1.Columns["employeeIDDataGridViewTextBoxColumn"].HeaderText = "幹";
            //this.dataGridView1.Columns["lastNameDataGridViewTextBoxColumn"].HeaderText = "三小";
            //this.dataGridView1.Columns["firstNameDataGridViewTextBoxColumn"].HeaderText = "操";

            //資料行很多的時候用
            //使用迴圈:依照你修改的資料數(length)，進行批次修改。
            string[] xa = { "幹", "三小", "操" ,"78"};
            for (int i = 0; i < xa.Length; i++)
            {
                this.dataGridView1.Columns[i].HeaderText = xa[i];
            }
        }
        class Pokemon
        {
            public Pokemon()
            {

            }
        }
    }
}
