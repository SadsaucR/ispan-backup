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
    public partial class Form2_openfile : Form
    {
        public Form2_openfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //預設目錄設為C:\
            openFileDialog1.InitialDirectory = "c:\\";
            //視窗標題
            openFileDialog1.Title = "選取檔案";
            //設定檔案類型
            openFileDialog1.Filter = "jpg(*.jpg)|*jpg|我要選不|*.*";
             //filter 語法 :"文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"'
            //透過視窗選取檔案

            //攔截錯誤訊息
            //try
            //{
            //    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //}
            //catch (Exception nofile)
            //{
            //    MessageBox.Show("未選擇檔案");
            //}

            //方法1 if判斷視窗是否回傳OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
                //圖片縮放
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //預設目錄設為C:\
            openFileDialog1.InitialDirectory = "c:\\";
            //視窗標題
            openFileDialog1.Title = "選取檔案";
            //設定檔案類型
            openFileDialog1.Filter = "文字檔 (*.txt)|*.txt|選不 (*.*)|*.*";
            //filter 語法 :"文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"'

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox2.Text=File.ReadAllText(openFileDialog1.FileName);
                textBox2.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("未選擇檔案");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //textBox1.Text = openFileDialog1.FileName;
        }


        //功能1:點擊超連結後開啟瀏覽器
        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //點擊超連結後開啟瀏覽器
            System.Diagnostics.Process.Start(e.LinkText);
        }

        //功能2:選取文字後變紅色
        private void richTextBox2_SelectionChanged(object sender, EventArgs e)
        {
            //選取文字後變色
            richTextBox2.SelectionColor = Color.Red;

        }


        //功能3:滑鼠放開後變回黑色
        private void richTextBox2_MouseUp(object sender, MouseEventArgs e)
        {
            richTextBox2.SelectionColor = Color.Black;
        }
    }
}
