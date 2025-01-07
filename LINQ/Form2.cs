using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool[] arr = new bool[26];
            bool[] arr2 = new bool[] { true,true,false,true };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            手鍊 小綠=new 手鍊();
            小綠.材質 = "塑膠";
        }
        class 手鍊
        {
            public string 材質 { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //匿名類別 
            var xa = new {Cat ="PIKACHU" , Dog="DOGGO" };
            textBox3.Text += $"{xa.Cat} \r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
