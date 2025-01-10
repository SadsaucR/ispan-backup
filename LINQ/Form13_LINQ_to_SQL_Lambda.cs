using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LINQ
{
    public partial class Form13_LINQ_to_SQL_Lambda : Form
    {
        public Form13_LINQ_to_SQL_Lambda()
        {
            InitializeComponent();
        }
        //Lambda select
        private void button1_Click(object sender, EventArgs e)
        {
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
          var select = pika.Products.Select(data => data);
            dataGridView1.DataSource = select;
        }
        //Lambda where
        private void button2_Click(object sender, EventArgs e)
        {
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
            var where = pika.Products.Where(data => data.ProductID==1);
            dataGridView1 .DataSource = where;
        }
        //Lambda join
        private void button3_Click(object sender, EventArgs e)
        {
            MYDataClasses1DataContext pika = new MYDataClasses1DataContext();
            var join = pika.Order_Details.Join (pika.Products,
                xx => xx.ProductID,
                yy => yy.ProductID,
                
                (xx,yy)=> new { 名=xx.OrderID, 編號=yy.ProductName}
                );

            dataGridView1.DataSource = join;


            /*
                    var query =
                    people.Join(pets,
                    person             => person,
                    pet                    => pet.Owner,
                    (person, pet) => new { OwnerName = person.Name, Pet = pet.Name });
             */
        }
    }
}
