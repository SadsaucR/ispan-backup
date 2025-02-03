using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace 資料庫測試
{
    public partial class Form3_產品類別 : Form
    {
        public Form3_產品類別()
        {
            InitializeComponent();
        }
        private void Form3_產品類別_Load(object sender, EventArgs e)
        {
        }

//        select ProductCategoryKey, EnglishProductCategoryName from DimProductCategory

//select ProductSubcategoryKey ID ,
//EnglishProductSubcategoryName English,
//FrenchProductSubcategoryName French
//from DimProductSubcategory
//where ProductCategoryKey = 2 
        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            MyDB db = new MyDB(connstring);
            string sqlcmd = "select ProductCategoryKey,EnglishProductCategoryName from DimProductCategory";
            Dictionary<string, string> dt = db.GetDictionary(sqlcmd);

            comboBox1.DataSource = new BindingSource(dt, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            string key = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key;
        }
    }
}
