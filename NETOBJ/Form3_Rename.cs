using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETOBJ
{
    public partial class Form3_Rename : Form
    {
        //練習:自定義class 控制 OpenFileDialog
        FolderBrowserDialog FBD = new FolderBrowserDialog();
        public Form3_Rename()
        {
            InitializeComponent();
        }

        //按鈕:選取要重新命名的檔案
        private void button1_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                browseFile(textBox1);
                string[] xa = Directory.GetFiles(FBD.SelectedPath);

                foreach (string filepath in xa)
                {
                    listBox1.Items.Add(filepath);
                }

            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }

            //將資料夾名稱顯示在Listbox1(包含路徑)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                browseFile(textBox2);
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
        }
        //將選取檔案整合進函式中
        private void browseFile(TextBox tb)
        {
            tb.Text = FBD.SelectedPath;
        }
        //複製檔案，並重新命名
        private void button3_Click(object sender, EventArgs e)
        {
            //設定路徑
            FileInfo xa = new FileInfo(textBox1.Text);
            DateTime xb = xa.LastAccessTime;
            string xc = xb.ToString("yyyyMMdd_HH");
            string[] xd = xa.Name.Split('.');
            string xe = $"{xc}.{xd[1]}";
            MessageBox.Show(xe);
            //copy file
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("請選擇目標及來源資料夾");
            }
            else
            {

                foreach (string item in listBox1.Items)
                {
                    FileInfo temp = new FileInfo(item);
                    string fileoldname = temp.Name;
                    string fileTime = temp.LastAccessTime.ToString("yyyyMMdd_HHmmss");

                    string newfileName = string.Concat(fileoldname, "_", fileTime, temp.Extension);

                    string final = Path.Combine(textBox2.Text, newfileName);

                    temp.CopyTo(final);

                    listBox2.Items.Add(final);
                }
            }
        }

        private void Form3_Rename_Load(object sender, EventArgs e)
        {
        }


    }
}
