using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETOBJ
{
    public partial class Cockulator : Form
    {
        public Cockulator()
        {
            InitializeComponent();
        }

        private void num_input(object sender, EventArgs e)
        {
            //將button中的數字加入label1
            //先將sender轉型成Button，再取得Text
            label1.Text += ((Button)sender).Text;

            //0開頭的數字，只能輸入一次
            //如果label1的內容是0，且不是小數點，則不顯示0
            //switch (label1.Text)
            //{
            //    case "0":
            //        label1.Text = "";
            //        break;
            //    case "00":
            //        label1.Text = "0";
            //        break;
            //}


        }
        private void Cockulator_Load(object sender, EventArgs e)
        {

        }

        //此函數trigger為按下運算子按鈕 + - * /
        private void oper(object sender, EventArgs e)
        {
            //將label1的內容存放到label2
            //將label1的值存放到num1

            label2.Text = label1.Text + $"{((Button)sender).Text}";
    

            //清空label1
            label1.Text = "";
        }

        private void padequal_Click(object sender, EventArgs e)
        {
            string input = label2.Text;
            string pattern = @"(\d+)(\+|\-|\*|\/)";
            Match match = Regex.Match(input, pattern);
            string number = "";
            string symbol = "";
            if (match.Success)
            {
                number = match.Groups[1].Value; //數字
                symbol = match.Groups[2].Value; //運算子
            }
            //label1 = label B label2=label A
            int first = Convert.ToInt32(number);
            int second = Convert.ToInt32(label2.Text);
            int result = 0;


            switch (symbol)
            {
                case "+":
                    result = first + second;
                    break;
            }
            label1.Text = result.ToString();
            label2.Text = ""; // 清空 label2

        }

    }
}
