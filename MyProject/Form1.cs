using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//引用myClassLibrary.dll (類別庫)
namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text= MyClassLibrary.MSIT62.classroom;
            label2.Text = MyClassLibrary.MSIT62.hours;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //呼叫myClassLibrary中的pokemon class
            MyClassLibrary.Pokemon p = new MyClassLibrary.Pokemon();
            label3.Text = p.sayhi();
        }
    }
}
