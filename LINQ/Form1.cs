using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void swap1(ref int a ,ref int b)
        {
           int temp = a; 
            a = b; 
            b = temp;
        }

        private void swap2(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        private void swap3<gen>(ref gen a, ref gen b)
        {
            gen temp = a;
            a = b;
            b = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;
            textBox1.Text = $"交換前x:{x}.y:{y}\r\n";
            swap1(ref x,ref y);
            textBox1.Text += $"交換後x:{x}.y:{y}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 1.0;
            double y = 2.0;
            textBox2.Text = $"交換前x:{x:F1}.y:{y:F1}\r\n";
            swap2(ref x, ref y);
            textBox2.Text += $"交換後x:{x:F1}.y:{y:F1}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = "貓";
           string y = "熊";
            textBox3.Text = $"交換前x:{x:F1}.y:{y:F1}\r\n";
            swap3<string>(ref x, ref y);
            textBox3.Text += $"交換後x:{x:F1}.y:{y:F1}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            訓練家 小新=new 訓練家();
            小新.名字 = "野原新之助";
            訓練家 小綠 = new 訓練家();
            小綠.名字 = "吉永綠";

            textBox4.Text = $"小新名字是{小新.名字}，小綠名字是{小綠.名字}\r\n\r\n";
            swap3<訓練家>(ref 小新,ref 小綠);
            textBox4.Text += $"小新名字是{小新.名字}，小綠名字是{小綠.名字}";
        }

        class 訓練家
        {
            public string 名字 { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
