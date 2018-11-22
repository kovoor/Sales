using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StationerySales
{
    public partial class ProductForm : Form
    {
        private Sales sales;
        public ProductForm(Sales sales)
        {
            InitializeComponent();
            this.sales = sales;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            List<String> productName =
                (from product in Sales.products
                 select product.Product_Name).ToList();

            productNameCB.DataSource = productName;
            productIDLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productID =
                from product in Sales.products
                where product.Product_Name == productNameCB.Text
                select product.Product_ID;

            var productPrice =
                from product in Sales.products
                where product.Product_Name == productNameCB.Text
                select product.Price;

            productIDLabel.Text = productID.FirstOrDefault();
            priceTextLabel.Text = productPrice.FirstOrDefault().ToString();
        }

        
    }
}
