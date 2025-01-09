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
    public partial class Form7_LINQ_where : Form
    {
        public Form7_LINQ_where()
        {
            InitializeComponent();
        }

        //select where
        private void button1_Click(object sender, EventArgs e)
        {
            int[] xa = { 1,2,3,4,5,6,7,8,9,10,11};
            var xb = from apple in xa where apple == 7  select apple;
            textBox1.Text=string.Join(",", xb);
        }

        //select where or 
        private void button2_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var xb = from apple in xa where apple == 7 || apple == 8 select apple;
            textBox2.Text = string.Join(",", xb);
        }

        //select where where (and) 
        private void button3_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var xb = from apple in xa where apple >= 7 where apple <= 8 select apple;
            textBox3.Text = string.Join(",", xb);

        }

        bool Cat(int Dog)
        {
            return !(Dog % 2 == 0);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            IEnumerable<int> xb = from apple in xa where Cat(apple) select apple;
            textBox4.Text = string.Join(",", xb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] xa = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var xb = from apple in xa where apple >= 7 where apple <= 8 select apple;
            textBox5.Text = string.Join(",", xb);
        }
    }
}
