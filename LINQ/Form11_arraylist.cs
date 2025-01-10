using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace LINQ
{
    public partial class Form11_arraylist : Form
    {
        public Form11_arraylist()
        {
            InitializeComponent();
        }

        //Oftype<>() 用於回傳Set中指定型態資料
        private void button1_Click(object sender, EventArgs e)
        {
           ArrayList xa =new ArrayList();
            xa.Add(123);
            xa.Add(true);
            xa.Add("皮卡丘");
            xa.Add(false);
            xa.Add(4.567);
            xa.Add("胖丁");
            IEnumerable<string> xb = xa.OfType<string>();
            textBox1.Text = string.Join(",", xa.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList xb =new ArrayList();
            xb.Add("珍珠奶茶");
            xb.Add("蜂蜜奶茶");
            xb.Add("紅茶拿鐵");
            xb.Add("鐵觀音");

            var xc = from string tea  in xb  select tea;
            textBox2.Text = string.Join(",", xc);
        }

        //延後執行實驗
        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList xb = new ArrayList();
            xb.Add("珍珠奶茶");
            xb.Add("蜂蜜奶茶");
            xb.Add("紅茶拿鐵");
            xb.Add("鐵觀音");
            xb.Add("泡沫紅茶");
            xb.Add("檸檬紅茶");

            var xc = from string tea in xb where tea.IndexOf("紅茶") >= 0 select tea;
            textBox3.Text = string.Join(",", xc);
        }

        //LINQ Skip 略過
        //只要是LINQ傘下的函數都有"延遲執行"的特性，此程式中在執行Skip時，實際上是print時(R71)才會執行，
        private void button4_Click(object sender, EventArgs e)
        {
            List<int> xa = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var xb = xa.Skip(3);

            textBox4.Text += "第一次查看"+ string.Join(",", xb)+"\r\n";

            xa.Clear();
            textBox4.Text += "第二次查看" + string.Join(",", xb) + "迷卡秋";
        }
        //Skip後Tolist()，立即保存結果。
        private void button5_Click(object sender, EventArgs e)
        {
            List<int> xa = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var xb = xa.Skip(3).ToList();

            textBox5.Text += "第一次查看" + string.Join(",", xb) + "\r\n";

            xa.Clear();
            textBox5.Text += "第二次查看" + string.Join(",", xb) + "迷卡秋";
        }
    }
}
