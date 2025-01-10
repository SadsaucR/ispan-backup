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
    public partial class Form10_LINQ_test : Form
    {
        public Form10_LINQ_test()
        {
            InitializeComponent();
        }

        private void Form10_LINQ_test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
            foreach (var item in numbers)
            {
                if (item > 8)
                {
                    textBox1.Text += item + "\r";
                    count++;
                }
            }
            textBox1.Text += $"共{count}個";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
            var xb = from pikachu in numbers where pikachu > 8 select pikachu;
            textBox2.Text = string.Join(",", xb) + $"\r共{xb.Count()}個";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 6, 23, 17, 4, 10, 19, 13, 25, 28, 3 };
            IEnumerable<int> xb = numbers.Where(x => x > 8);
            int xx = xb.Count();
            textBox3.Text = string.Join(",", xb)+$"\r共{xx.ToString()}個";
        }
    }
}
