using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"輸入:{textBox1.Text}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
            {
                label1.Text = $"輸入字數不得小於5個字";
            }
            else
            {
                label1.Text = $"字數通過檢核!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("皮卡丘打排球");
        }
    }
}
