using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form6_LINQ_from : Form
    {
        public Form6_LINQ_from()
        {
            InitializeComponent();
        }

        private void Form6_LINQ_from_Load(object sender, EventArgs e)
        {

        }

        //討論Var的型別，var宣告時會轉型成輸入的資料型態
        private void button1_Click(object sender, EventArgs e)
        {
            var xb = 123;
            var xc = "皮卡丘";

            textBox1.Text = xb.ToString();
            textBox1.Text = xc;
        }
        //Var+List<>
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> xa = new List<int>();
            xa.Add(1);
            xa.Add(2);
            textBox2.Text = string.Join(",",xa)+"\r\n";

            var xb = new List<int>();
            xb.Add(3);
            xb.Add(4);
            textBox2.Text += string.Join(",", xb);
        }

        //LINQ:from 變數 in 集合 select  變數
        //  SQL:select 資料行 from 資料表
        //使用 IEnumerable 介面 + <int> 泛式
        private void button3_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 55,66,77,88};

            IEnumerable<int> xb; //IEnumerable 介面 + <int> 泛式

            xb = from pikachu in xa select pikachu;

            //foreach (int X in xb)
            //{
            //    textBox3.Text += X;
            //}
            textBox3.Text= string.Join(",",xb);
        }

        //只使用var
        private void button4_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 55, 66, 77, 88 };
            var xb = from pikachu in xa select pikachu;
            textBox4.Text = string.Join(",", xb);
        }
    }
}
