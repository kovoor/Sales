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
    public partial class Sales : Form
    {
        static DateTime dt = DateTime.Now;
        string dateTime = dt.ToString("dd/MM/yyyy   hh:mm:ss tt");
        public static List<Product> products = new List<Product>(); //Writing Tools, Notebook & Diary, Office Equipment, Files & Folders, Others
        public static List<Account> customers = new List<Account>();
        public static List<Order> orders = new List<Order>();

        Product[] initProducts =
        {
            new Product("Pen","P100", 1.99M, "Writing Tools", 1000),
            new Product("Notebook","N100", 4.99M, "Notebook & Diary", 50),
            new Product("Tape","E100", 3.99M, "Office Equipment", 90),
            new Product("File","F100", 2.99M, "Files & Folders", 100),
            new Product("Pencil Case","D100", 10.99M, "Others", 50)
        };

        Account[] initAccounts =
       {
            new Account("C101", "John Smith", "Jalan Petaling", "Selangor", "2-12-2012", "Premium"),
            new Account("C102", "Alex Lee", "Jalan Alor", "Melaka", "3-5-2012", "Premium"),
            new Account("C103", "Michael Twain", "Jalan Klang", "Kuala Lumpur", "1-2-2012", "Premium")

        };

        Order[] initOrders =
        {
            new Order("C102","Alex Lee","5-2-2012", new List<Product> {
                new Product("Pen","P100", 1.99M, 10),
            new Product("Notebook","N100", 4.99M, 5),
            },"D10011")
        };

        public Sales()
        {
            InitializeComponent();

        }

        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Product p in initProducts)
            {
                products.Add(p);
            }
            loadproductdata();

            foreach (Account acc in initAccounts)
            {
                customers.Add(acc);
            }
            loadcustomerdata();

            foreach (Order od in initOrders)
            {
                orders.Add(od);
            }
            loadorderdata();

            //AcceptButton = lgnBtn;

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nxt1Lab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //START PRODUCTS TAB

        private void AddProduct_Click(object sender, EventArgs e)
        {
            ProductDetails pd = new ProductDetails(this);
            if (pd.ShowDialog() == DialogResult.OK)
            {
                Product p = new Product(pd.Product_Name, pd.Product_ID, pd.Price, pd.Category, pd.Quantity);
                products.Add(p);
                loadproductdata();
                ProductView.Update();
                ProductView.Refresh();
            }
        }

        private void PurchaseStockBtn_Click(object sender, EventArgs e)
        {
            int row = ProductView.CurrentCell.RowIndex;
            string nm = Convert.ToString(ProductView.Rows[row].Cells[0].Value);
            string id = Convert.ToString(ProductView.Rows[row].Cells[1].Value);
            this.NotificationView.Rows.Add("Purchase Department", "Item " + nm + "(" + id + ")" + " of stock and needs to be restocked!", dateTime);

            DialogResult StockUp = MessageBox.Show("The Purchase Department has been notified to stock up this particular item.", "Notified", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProductView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadproductdata()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = products;
            ProductView.DataSource = bSource;
        }

        //END PRODUCTS TAB

        //START CUSTOMERS TAB

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails(this);
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Account ac = new Account(cd.Cust_ID,cd.Cust_Name, cd.Address, cd.State, cd.Date, cd.Type);
                customers.Add(ac);
                loadcustomerdata();
                CustomerView.Update();
                CustomerView.Refresh();
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in CustomerView.SelectedCells)
            {
                if (oneCell.Selected)
                    CustomerView.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void editCustomer_Click_1(object sender, EventArgs e)
        {

        }

        public void loadcustomerdata()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = customers;
            CustomerView.DataSource = bSource;
        }

        //END CUSTOMERS TAB

        //START ORDERS TAB

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            OrderDetails od = new OrderDetails(this);
            if (od.ShowDialog() == DialogResult.OK)
            {
                loadorderdata();
            }
        }

        private void editOrderBtn_Click(object sender, EventArgs e)
        {

        }

        public void loadorderdata()
        {
            BindingSource bSource = new BindingSource();
            bSource.DataSource = orders;
            OrderView.DataSource = bSource;
            OrderView.Update();
            OrderView.Refresh();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(orders, OrderView.CurrentCell.RowIndex);
            bill.ShowDialog();
        }

       /* private void updateButton()
        {
            OrderPickingBtn.Enabled = ;
            billBtn.Enabled = ;
        }*/

        //END ORDERS TAB

        private void prodSearch_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void closeIcon1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon4_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeIcon2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(userNTextBox.Text, pwTextBox.Text);

            if (user.valid == true)
            {
                LoginPanel.Visible = false;
                SalesPanel.Visible = true;
            }
            else
                MessageBox.Show("Username or Password is incorrect!");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        

        private void OrderPickingBtn_Click(object sender, EventArgs e)
        {
            int row = OrderView.CurrentCell.RowIndex;
            string refNo = Convert.ToString(OrderView.Rows[row].Cells[0].Value);
            string accNm = Convert.ToString(OrderView.Rows[row].Cells[1].Value);
            string accID = Convert.ToString(OrderView.Rows[row].Cells[2].Value);
            this.NotificationView.Rows.Add("Warehouse Department", "Order " + refNo + "for customer" + accNm + "(" + accID + ")" + " can be dispatched.", dateTime);

            DialogResult StockUp = MessageBox.Show("The Warehouse Department has been notified to pick up this particular order.", "Notified", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            User user = new User(userNTextBox.Text, pwTextBox.Text);

            if (user.valid == true)
            {
                LoginPanel.Visible = false;
                SalesPanel.Visible = true;
            }
            else
                MessageBox.Show("Username or Password is incorrect!");
        }

        private void userNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void closeIcon2_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon3_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon4_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon1_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeIcon5_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in ProductView.SelectedCells)
            {
                if (oneCell.Selected)
                    ProductView.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void ProductView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var query = from Order o in orders
                        where o.Reference_Num == "12345"//the reference num in the row selected
                        select o;

            Order billorder = query.FirstOrDefault();
            foreach(Product pr in billorder.Product)
            {
                decimal[] productTotal = billorder.getProductTotal();

            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
