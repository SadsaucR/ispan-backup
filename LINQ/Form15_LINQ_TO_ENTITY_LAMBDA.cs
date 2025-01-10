using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LINQ.classcontent;

namespace LINQ
{
    public partial class Form15_LINQ_TO_ENTITY_LAMBDA : Form
    {
        public Form15_LINQ_TO_ENTITY_LAMBDA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities NW =new NorthwindEntities();
            dataGridView1.DataSource = NW.Customers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NorthwindEntities NW = new NorthwindEntities();
            var where = NW.Customers.Where(data => data.CustomerID == "ALFKI");
            dataGridView1.DataSource = where.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NorthwindEntities NW = new NorthwindEntities();
            var result = NW.Customers.Where(data => data.CustomerID == "ALFKI").Join(NW.Orders,
               CC => CC.CustomerID,
               OO => OO.CustomerID,
               (CC, OO) => new { CC.ContactName, OO.OrderID }).OrderByDescending(x => x.OrderID);
            dataGridView1.DataSource = result.ToList();
        }
    }
}
