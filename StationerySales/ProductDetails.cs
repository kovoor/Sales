using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationerySales
{
    public partial class ProductDetails : Form
    {
        public string Product_Name { get; set; }
        public string Product_ID { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } //Writing Tools, Notebook & Diary, Office Equipment, Files & Folders, Others
        public int Quantity { get; set; }

        public ProductDetails(Sales sales)
        {
            InitializeComponent();
        }
        
        private void ValidateTextBoxes()
        {
            bool emptyCheck = false;
            int value;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("All textbox must be filled");
                        emptyCheck = true;
                        break;
                    }

                    if (c == IDTextBox)
                    {
                        if (Int32.TryParse(IDTextBox.Text, out value))
                        {
                            emptyCheck = false;
                        }

                        else
                        {
                            MessageBox.Show("ID must be in numerical form!");
                            emptyCheck = true;
                            break;
                        }
                    }

                    else
                    {
                        emptyCheck = false;
                    }

                }
            }

            if (!emptyCheck)
            {
                Product_Name = nameTextBox.Text;
                Product_ID = IDTextBox.Text;
                Price = decimal.Parse(priceTextBox.Text);
                Category = cateCB.Text;
                Quantity = int.Parse(qtyTextBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ValidateTextBoxes();
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }


}
