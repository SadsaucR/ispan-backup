using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONET4
{
    public partial class Form3 : Form
    {
        #region 宣告變數
        SqlConnection sqlc;
        SqlDataAdapter sqld;
        DataSet ds;
        #endregion
        public Form3()
        {
            InitializeComponent();
        }
        public void setButton(bool BT1, bool BT2, bool BT3)
        {
            ButtonAll.Enabled = BT1;
            ButtonUpdate.Enabled = BT2;
            ButtonTest.Enabled = BT3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            sqlc = new SqlConnection(ADONET4.Properties.Settings.Default.DW);
            sqld = new SqlDataAdapter();
            ds = new DataSet();

            setButton(true, false, false);
        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            setButton(false, true, true);
            string sql = "select * from DimCurrency";
            sqld.SelectCommand = new SqlCommand(sql, sqlc);
            if (ds.Tables["DimCurrency"] != null) ds.Tables["DimCurrency"].Clear();
            sqld.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];
            //將表單成員綁定至textbox裡面
            this.txtID.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyKey");
            this.txtKey.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyAlternateKey");
            this.txtName.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyName");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //builder()，連接adapter並執行Update指令
            SqlCommandBuilder sqlb = new SqlCommandBuilder(sqld);
            //使用builder.GetUpdateCommand()生成update指令
            SqlCommand update_cmd = sqlb.GetUpdateCommand();
            result.Text=update_cmd.CommandText;
            sqld.UpdateCommand = update_cmd;

            //update(#dataset , #table) 將顯示更新成功的資料數      
            int ud_log = sqld.Update(ds, "DimCurrency");
            result.Text = ud_log.ToString();
        }

        private void ButtonUpdate2_Click(object sender, EventArgs e)
        {
            string sql = $"update DimCurrency set CurrencyAlternateKey=@AK,CurrencyName=@CN where CurrencyKey = @PCK";


            sqld.UpdateCommand = new SqlCommand(sql, sqlc);
            sqld.UpdateCommand.Parameters.AddWithValue("@AK", txtKey.Text);
            sqld.UpdateCommand.Parameters.AddWithValue("@CN", txtName.Text);
            sqld.UpdateCommand.Parameters.AddWithValue("@PCK", txtID.Text);

            sqlc.Open();
            int count = sqld.UpdateCommand.ExecuteNonQuery();
            result.Text = count.ToString();

            MessageBox.Show($"已更新{count}筆資料","標題"
            , MessageBoxButtons.OK
            ,MessageBoxIcon.Information);
            
            sqlc.Close();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
            //先執行查詢
            //
            foreach (DataRow item in ds.Tables["DimCurrency"].Rows)
            {
                result.Text += $" {item.ItemArray[0]} {item.ItemArray[1]} {item.ItemArray[2]} \r\n";
            }
        }

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            result.Text = string.Empty;
            string pre = "";

            foreach (DataRow item in ds.Tables["DimCurrency"].Rows)
            {
                if (item.RowState.ToString() != "Unchanged")
                {
                    result.Text += $" {item.ItemArray[0]} {item.ItemArray[1]} {item.ItemArray[2]} 已修改!!! \r\n";
                }
                if (result.Text == pre)
                {
                    result.Text = $"資料無異動\r\n";
                }
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ds.Tables["DimCurrency"] != null)
            {
                //MessageBox.Show("測試用","標題",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                string temp = "";
                foreach (DataRow row in ds.Tables["DimCurrency"].Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                        temp = string.Join(",", row.ItemArray) + Environment.NewLine;
                }
                if (string.IsNullOrEmpty(temp) == false)
                {
                    temp += Environment.NewLine;
                    temp += Environment.NewLine;
                    temp += "確認:關閉表單\r\n取消:回到表單繼續編輯不關閉視窗";

                    DialogResult cat = MessageBox.Show(temp, "資料尚未存檔", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (cat == DialogResult.OK)
                    {
                        //user select OK Button then Stop the prog
                        e.Cancel = false;
                    }
                    else
                    {
                        //user select Cancel Button then Continue the prog
                        e.Cancel = true;
                    }

                }
            }
        }
        private void ButtonIsnull_Click(object sender, EventArgs e)
        {
            string cat = "";
            bool Isnull = string.IsNullOrEmpty(cat);
            result.Text = Isnull.ToString();
        }

        
    }
}
