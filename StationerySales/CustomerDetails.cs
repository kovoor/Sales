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
    public partial class CustomerDetails : Form
    {
        public string Cust_Name { get; set; }
        public string Cust_ID { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }


        public CustomerDetails(Sales sales)
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {


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
                Cust_Name = nameTextBox.Text;
                Cust_ID = IDTextBox.Text;
                Address = addressTextBox.Text;
                State = stateCB.Text;
                Date = DateTime.Now.ToString("M/d/yyyy");
                Type = typeCB.Text;
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
