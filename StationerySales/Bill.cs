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
    public partial class Bill : Form
    {
        static Sales sales = new Sales();

        public Bill(List<Order> ord, int row)
        {
            InitializeComponent();
            refNoLabel.Text = ord[row].Reference_Num;
            dateLabel.Text = ord[row].Date;
            custNmLabel.Text = ord[row].Account_Name;
            accIDLabel.Text = ord[row].Account_ID;


            var query = from Order o in ord
                        where o.Reference_Num.Equals(refNoLabel.Text)//the reference num in the row selected
                        select o;

            Order billorder = query.FirstOrDefault();
            foreach (Product pr in billorder.Product)
            {
                string prodName = pr.Product_Name;
                decimal price = pr.Price;
                int qty = pr.Quantity;
                decimal prodTotal = pr.Quantity * pr.Price;
                decimal totalPrice = billorder.getTotal();

                BillView.Rows.Add(prodName, price, qty, prodTotal);
                subTotalValueLabel.Text = Convert.ToString(totalPrice);
            }



        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
