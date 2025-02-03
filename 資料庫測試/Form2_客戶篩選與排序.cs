using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 資料庫測試
{
    public partial class Form2_客戶篩選與排序 : Form
    {
        public Form2_客戶篩選與排序()
        {
            InitializeComponent();
        }

        DataTable Pikachu;

        private void Form2_客戶篩選與排序_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            MyDB db = new MyDB(connstr);
            string sqlcmd = "select CustomerKey,FirstName,LastName,BirthDate,Gender,EnglishEducation from DimCustomer";

            Pikachu = db.GetDataTable(sqlcmd);
            dataGridView1.DataSource = Pikachu;
        }
        //排序
        private void radiobutton_orderby_changed(object sender, EventArgs e)
        {
            RadioButton xa = (RadioButton)sender;

            if (xa.Checked == true)
            {
                //MessageBox.Show("開工了" + xa.Name);
                switch (xa.Text)
                {

                    case "FirstName":
                        #region 查詢語法
                        //var apple = from bee in Pikachu.AsEnumerable() 
                        //            orderby bee.Field<string>("FirstName"), 
                        //            bee.Field<string>("LastName") 
                        //            select bee;
                        //dataGridView1.DataSource = apple.CopyToDataTable();
                        #endregion

                        #region 方法語法
                        var dog = Pikachu.AsEnumerable()
                            .OrderBy(xb => xb.Field<string>("FirstName"))
                            .ThenBy(xc => xc.Field<string>("LastName"));

                        dataGridView1.DataSource = dog.CopyToDataTable();
                        //兩個orderby要改成orderby+thenby(這是三小)
                        #endregion
                        break;

                    case "BirthDate":
                        #region 查詢語法
                        //MessageBox.Show("生日被選到");
                        //var cat = from bee in Pikachu.AsEnumerable()
                        //          orderby bee.Field<DateTime>("BirthDate")
                        //          select bee;
                        //dataGridView1.DataSource = cat.CopyToDataTable();
                        #endregion

                        #region 方法語法
                        var elephant = Pikachu.AsEnumerable()
                            .OrderBy(xb => xb.Field<DateTime>("BirthDate"));
                        dataGridView1.DataSource = elephant.CopyToDataTable();
                        #endregion
                        break;

                    default:
                        break;
                }
            }
        }
        //篩選
        private void radiobutton_fillter_changed(object sender, EventArgs e)
        {
            RadioButton xa = (RadioButton)sender;
            if (xa.Checked == true)
            {
                #region 查詢語法
                //var data = from row in Pikachu.AsEnumerable()
                //           where row.Field<string>("EnglishEducation") == xa.Text
                //            select row;
                //dataGridView1.DataSource = data.CopyToDataTable();
                #endregion

                #region 方法語法
                var elephant = Pikachu.AsEnumerable()
                    .Where(xb => xb.Field<string>("EnglishEducation") == xa.Text);
                dataGridView1.DataSource = elephant.CopyToDataTable();
                #endregion
            }
        }
    }
}
