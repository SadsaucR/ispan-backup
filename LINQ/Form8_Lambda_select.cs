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

namespace LINQ
{
    public partial class Form8_Lambda_select : Form
    {
        public Form8_Lambda_select()
        {
            InitializeComponent();
        }

        //First : 挑選符合條件的第一個->沒有指定的話就是位置0
        //Select : 將序列的元素規畫成一個新表單
        private void button1_Click(object sender, EventArgs e)
        {
            int[] xa = { 1,2,3,4,5,6,7,8,9,10,11};
            Func<int, int> lion = (int apple) => { return 5566; };
            var xb =xa.Select(lion);
            textBox1.Text = string.Join(Environment.NewLine, xb);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var xb = xa.Select((int fish) => { return 100; });
            textBox2.Text = string.Join(Environment.NewLine, xb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] xa = { "1", "2", "3", "4", "5" };
            Func<string, int> lion = (string apple) => { return Convert.ToInt32(apple); };
            var xb = xa.Select(lion);
            textBox3.Text = string.Join(Environment.NewLine, xb);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] xa = { "1", "2", "3", "4", "5" };
            foreach (var item in xa)
                textBox4.Text += Convert.ToInt32(item);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
