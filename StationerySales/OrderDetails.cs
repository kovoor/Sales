using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StationerySales
{
    public partial class OrderDetails : Form
    {
        List<Panel> listPanel = new List<Panel>();
        List<Product> productList = new List<Product>();
        int index;

        public OrderDetails(Sales sales)
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel[index].BringToFront();

            List<String> accName =
                (from account in Sales.customers
                 select account.Cust_Name).ToList();

            accNameCB.DataSource = accName;
            accIDText.Text = "";
            accNameCB.SelectedIndex = -1;

            List<String> productName =
                (from product in Sales.products
                 select product.Product_Name).ToList();

            productNameCB.DataSource = productName;
            productIDLabel.Text = "";
            productNameCB.SelectedIndex = -1;
        }

        //START ORDER PANEL

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var accID =
                from acc in Sales.customers
                where acc.Cust_Name == accNameCB.Text
                select acc.Cust_ID;

            accIDText.Text = accID.FirstOrDefault();
        }
        //END ORDER PANEL

        //START PRODUCTS PANEL

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

        private void addProductBtn_Click(object sender, EventArgs e)
        {
           
            Product p = new Product(productNameCB.Text, productIDLabel.Text, decimal.Parse(priceTextLabel.Text), int.Parse(qtyTextBox.Text));
            productList.Add(p);
            loadProductList();
            
        }

        private void cancelBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadProductList()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = productList;
            productListView.DataSource = bSource;
            productListView.Update();
            productListView.Refresh();
            productListView.Columns["Category"].Visible = false;
        }



        private void nextBtn2_Click(object sender, EventArgs e)
        {
            if (productListView.Rows.Count == 0)
            {
                DialogResult iProceed = MessageBox.Show("Don't forget to add a product!", "Product not added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                if (index < listPanel.Count - 1)
                    listPanel[++index].BringToFront();
            }
        }

        private void previousBtn1_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void updateBtn()
        {
            nextBtn2.Enabled = productListView.Rows.Count == 0;
        }

        //END PRODUCTS PANEL

        //START TRANSACTIONS PANEL

        private void cancelBtn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardNoRad_TextChanged(object sender, EventArgs e)
        {

        }

        //Checkout Button - Transactions Page
        private void submitBtn_Click(object sender, EventArgs e)
        {
            Boolean checker = true;
            if (radioButton2.Checked)
            {
                checker = IsCreditCardInfoValid(cardNo.Text, ExpiryMonth.Text, ExpiryYear.Text, cardCvc.Text);
            }
            DialogResult iProceed;


            if (checker == true)
            {
                iProceed = MessageBox.Show("Order successful!", "Proceed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iProceed == DialogResult.OK)
                {
                    //Enter next page
                    //tabControl1.SelectedIndex = 4;
                    Order o = new Order(accIDText.Text, accNameCB.Text, DateTime.Now.ToString("M/d/yyyy"), productList, refNoTextBox.Text);
                    Sales.orders.Add(o);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }

            else
            {
                MessageBox.Show("Please check your credit/debit card details again!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Credit Card Authentication
        public static bool IsCreditCardInfoValid(string cardNo, string expiryMonth, string expiryYear, string cvv)
        {
            //the first 4 digits must be one of these: 1298, 1267, 4512, 4567, 8901, 8933
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            if (!monthCheck.IsMatch(expiryMonth) || !yearCheck.IsMatch(expiryYear)) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(expiryYear);
            var month = int.Parse(expiryMonth);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cardNo.Enabled = true;
            cardCvc.Enabled = true;
            ExpiryMonth.Enabled = true;
            ExpiryYear.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void previousBtn2_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        //END TRANSACTIONS PANEL
    }
}
