using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETOBJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //目前時間
            textBox1.Text = DateTime.Now.ToLongDateString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.DataBindings.Add("Text", textBox1, "Text");
            button2.Enabled = false;
            //將comboBox1的值綁定到label2
            //label2.DataBindings.Add("Text", comboBox1, "Text");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;

            //方式1 使用字典key,value
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("TPE", "台北");
            dict.Add("TCH", "台中");
            dict.Add("KHH", "高雄");

            comboBox2.DataSource = new BindingSource(dict, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
            //label1  顯示 key
            label1.DataBindings.Add("Text", comboBox2, "SelectedValue");
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Key; 
            label4.Text = ((KeyValuePair<string, string>)comboBox2.SelectedItem).Value;
        }
    }
}
