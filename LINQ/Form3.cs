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

        public string Reg_Passport(string pfp,string name,int price)
        {
            return $"{name}護照受理囉，10天後過來拿，費用是{price}";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //自己取辦護照。
            textBox1.Text = Reg_Passport("我的帥照","力勤",1300);

        }


        //旅行社幫你辦護照 (委派) delegateeeee
        public delegate string Travel(string pfp,string name, int price);
        private void button2_Click(object sender, EventArgs e)
        {
            Travel pacific = Reg_Passport;
            string a = pacific("我的帥照", "力勤", 1300 + 800);
            textBox2.Text= a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Travel Lion = Reg_Passport;
            string a = Lion("我的帥照", "力勤", 1300 + 400);
            textBox3.Text = a;
        }

        //lambda ver 箭頭函數
        private void button4_Click(object sender, EventArgs e)
        {
            Travel Lion = (string pfp, string name, int price) => {return $"{name}護照受理囉，10天後過來拿，費用是{price}<=>Lambda ver"; };
            string a = Lion("我的帥照", "力勤", 1300 + 400);
            textBox4.Text= a;
        }

        //lambda ver 箭頭函數 精簡版
        private void button5_Click(object sender, EventArgs e)
        {
            Travel Lion = (string pfp, string name, int price) => $"{name}護照受理囉，10天後過來拿，費用是{price}<=>Lambda 精簡版!! V2.16 " ;
            string a = Lion("我的帥照", "力勤", 1300 + 400);
            textBox5.Text = a;
        }

        //lambda func ver 
        //func 函式如同代理人，將資料型態，內容丟入，使其回傳所需資料
        //func語法: func<,傳入1,傳入2,傳入3,傳入4...,回傳型態>
        private void button6_Click(object sender, EventArgs e)
        {
            Func<string, string, int, string> Lion = (string pfp, string name, int price) => $"{name}護照受理囉，10天後過來拿，費用是{price}<=>Lambda func ver";
            string a = Lion("我的帥照", "P", 1300 + 400);
            textBox6.Text = a;
        }





        

    }
}
