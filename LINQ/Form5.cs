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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.StudentName = "Pikachu";
            textBox1.Text=s1.Studyfunc("In the forest")+"\r\n";
            textBox1.Text += s1.resteraunt("Mcdonald") + "\r\n";

            Teacher t1 = new Teacher();
            t1.TeacherName = "Satoshi";
            textBox1.Text += t1.Studyfunc("With the EDM!!!") + "\r\n";
            textBox1.Text += t1.resteraunt("KFC") + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car c1=new Car();
            textBox2.Text =c1.Launch()+"\r\n";
            textBox2.Text += c1.Stop() + "\r\n";

            Car c2=new Audi();
            textBox2.Text +=c2.Launch()+"\r\n";
            textBox2.Text += c2.Stop()+"\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Honda c3 = new Honda();
            textBox3.Text +=c3.Launch()+"\r\n";
            textBox3.Text += c3.Stop() + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Car c4 = new Audi();
            textBox4.Text += c4.Launch() + "\r\n";
            textBox4.Text += c4.Stop() + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Car c5 = new Honda();
            textBox5.Text += c5.Launch() + "\r\n";
            textBox5.Text += c5.Stop() + "\r\n";
        }
    }
}
