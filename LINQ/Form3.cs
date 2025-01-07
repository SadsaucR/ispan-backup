using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string Reg_Passport(string pfp,string pf,int price)
        {
            return "護照好囉，10天後過來拿。";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //自己取辦護照。
            textBox1.Text = Reg_Passport("我的帥照","個人資料",1300);

        }


        //旅行社幫你辦護照 (委派) delegateeeee
        public delegate string 旅行社(string pfp,string pf, int price);
        private void button2_Click(object sender, EventArgs e)
        {
            旅行社 太平洋 = Reg_Passport;
            string xa = 太平洋("我的帥照", "個人資料", 1300 + 800);
            textBox2.Text= xa;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
