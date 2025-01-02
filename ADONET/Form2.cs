using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //method 1
            comboBox1.Items.Add(textBox1.Text);
            //method 2
            string[] xb = new string[] { "新竹" };
            comboBox1.Items.AddRange(xb);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control xb in this.Controls)
            {
                comboBox1.Items.Add(xb.Name);
            }
        }
    }
}
