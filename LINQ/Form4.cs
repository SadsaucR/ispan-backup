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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //First() 函式 傳回序列中第一項元素
        private void button1_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 5,6,7,8};

            int xb =xa.First();
            textBox1.Text = xb.ToString(); //5
        }

        //First() 應用 追加函式
        private void button2_Click(object sender, EventArgs e)
        {
          
            int[] xa = new int[] { 5, 6, 7, 8 };

            bool myfunc(int apple)
            {
                if (apple > 6)
                    return true;
                else 
                    return false;
            }
            //myfunc 用於追加篩選條件  First() 會逐一檢查 xa 中的元素，直到找到第一個使 myfunc 返回 true 的元素。
            int xb = xa.First(myfunc); 
            textBox2.Text = xb.ToString(); //7
        }

        //First() + 箭頭函數 Func<> 應用
        private void button3_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 1,10, 15, 25 };

            Func<int, bool> bee = (int cat) =>
            {
                if(cat>16)
                    return true;
                else 
                    return false;
            };

            int xb = xa.First(bee);

            textBox3.Text = xb.ToString(); 

        }

        //First() + 箭頭函數 Func<> 應用 Ver.精簡版!!
        private void button4_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 1, 10, 15, 25 };

            Func<int, bool> bee = (int cat) => { return (cat > 16); };

            int xb = xa.First(bee);

            textBox4.Text = xb.ToString();
        }

        //First() + 箭頭函數 Func<> 應用 Ver.超究極精簡版!!

        private void button5_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 1, 10, 15, 25 };

            Func<int, bool> bee = cat => (cat > 16);

            int xb = xa.First(bee);

            textBox5.Text = xb.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] xa = new int[] { 1, 10, 15, 25 };

            int xb = xa.First(cat => cat >16);

            textBox6.Text = xb.ToString();
        }
    }
}
