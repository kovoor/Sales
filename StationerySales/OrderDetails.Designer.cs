namespace StationerySales
{
    partial class OrderDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            this.accNameCB = new System.Windows.Forms.ComboBox();
            this.refNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accIDText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productListView = new System.Windows.Forms.DataGridView();
            this.addProductBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.previousBtn1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nextBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.priceTextLabel = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productNameCB = new System.Windows.Forms.ComboBox();
            this.productName = new System.Windows.Forms.Label();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.previousBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.submitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelBtn3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ExpiryYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpiryMonth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chqNoRad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cardCvc = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // accNameCB
            // 
            this.accNameCB.FormattingEnabled = true;
            this.accNameCB.Items.AddRange(new object[] {
            "Kuala Lumpur",
            "Putrajaya",
            "Labuan",
            "Perlis",
            "Kelantan",
            "Kedah",
            "Perak",
            "Penang",
            "Terengganu",
            "Pahang",
            "Selangor",
            "Negeri Sembilan",
            "Melaka",
            "Johor",
            "Sabah",
            "Sarawak"});
            this.accNameCB.Location = new System.Drawing.Point(121, 62);
            this.accNameCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accNameCB.Name = "accNameCB";
            this.accNameCB.Size = new System.Drawing.Size(146, 27);
            this.accNameCB.TabIndex = 28;
            this.accNameCB.SelectedIndexChanged += new System.EventHandler(this.accNameCB_SelectedIndexChanged);
            // 
            // refNoTextBox
            // 
            this.refNoTextBox.Location = new System.Drawing.Point(121, 131);
            this.refNoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refNoTextBox.Name = "refNoTextBox";
            this.refNoTextBox.Size = new System.Drawing.Size(146, 26);
            this.refNoTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Reference No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Account Name";
            // 
            // accIDText
            // 
            this.accIDText.AutoSize = true;
            this.accIDText.ForeColor = System.Drawing.SystemColors.Control;
            this.accIDText.Location = new System.Drawing.Point(121, 98);
            this.accIDText.Name = "accIDText";
            this.accIDText.Size = new System.Drawing.Size(0, 19);
            this.accIDText.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productListView);
            this.panel2.Controls.Add(this.addProductBtn);
            this.panel2.Controls.Add(this.previousBtn1);
            this.panel2.Controls.Add(this.nextBtn2);
            this.panel2.Controls.Add(this.cancelBtn2);
            this.panel2.Controls.Add(this.bunifuSeparator6);
            this.panel2.Controls.Add(this.priceTextLabel);
            this.panel2.Controls.Add(this.qtyTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.productNameCB);
            this.panel2.Controls.Add(this.productName);
            this.panel2.Controls.Add(this.productIDLabel);
            this.panel2.Controls.Add(this.productID);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(80, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 307);
            this.panel2.TabIndex = 30;
            // 
            // productListView
            // 
            this.productListView.AllowUserToAddRows = false;
            this.productListView.AllowUserToDeleteRows = false;
            this.productListView.AllowUserToResizeColumns = false;
            this.productListView.AllowUserToResizeRows = false;
            this.productListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.productListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListView.Location = new System.Drawing.Point(97, 127);
            this.productListView.Name = "productListView";
            this.productListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListView.Size = new System.Drawing.Size(420, 127);
            this.productListView.TabIndex = 57;
            // 
            // addProductBtn
            // 
            this.addProductBtn.ActiveBorderThickness = 1;
            this.addProductBtn.ActiveCornerRadius = 20;
            this.addProductBtn.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.addProductBtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.addProductBtn.ActiveLineColor = System.Drawing.Color.Silver;
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.addProductBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addProductBtn.BackgroundImage")));
            this.addProductBtn.ButtonText = "Add Product";
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addProductBtn.IdleBorderThickness = 1;
            this.addProductBtn.IdleCornerRadius = 20;
            this.addProductBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.addProductBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addProductBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.addProductBtn.Location = new System.Drawing.Point(470, 75);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(98, 37);
            this.addProductBtn.TabIndex = 56;
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // previousBtn1
            // 
            this.previousBtn1.ActiveBorderThickness = 1;
            this.previousBtn1.ActiveCornerRadius = 20;
            this.previousBtn1.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.previousBtn1.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.previousBtn1.ActiveLineColor = System.Drawing.Color.Silver;
            this.previousBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.previousBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousBtn1.BackgroundImage")));
            this.previousBtn1.ButtonText = "Previous";
            this.previousBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn1.ForeColor = System.Drawing.Color.SeaGreen;
            this.previousBtn1.IdleBorderThickness = 1;
            this.previousBtn1.IdleCornerRadius = 20;
            this.previousBtn1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.previousBtn1.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.previousBtn1.IdleLineColor = System.Drawing.Color.Silver;
            this.previousBtn1.Location = new System.Drawing.Point(394, 265);
            this.previousBtn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousBtn1.Name = "previousBtn1";
            this.previousBtn1.Size = new System.Drawing.Size(98, 37);
            this.previousBtn1.TabIndex = 55;
            this.previousBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previousBtn1.Click += new System.EventHandler(this.previousBtn1_Click);
            // 
            // nextBtn2
            // 
            this.nextBtn2.ActiveBorderThickness = 1;
            this.nextBtn2.ActiveCornerRadius = 20;
            this.nextBtn2.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.nextBtn2.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.nextBtn2.ActiveLineColor = System.Drawing.Color.Silver;
            this.nextBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.nextBtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn2.BackgroundImage")));
            this.nextBtn2.ButtonText = "Next";
            this.nextBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn2.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextBtn2.IdleBorderThickness = 1;
            this.nextBtn2.IdleCornerRadius = 20;
            this.nextBtn2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.nextBtn2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextBtn2.IdleLineColor = System.Drawing.Color.Silver;
            this.nextBtn2.Location = new System.Drawing.Point(500, 265);
            this.nextBtn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn2.Name = "nextBtn2";
            this.nextBtn2.Size = new System.Drawing.Size(98, 37);
            this.nextBtn2.TabIndex = 53;
            this.nextBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextBtn2.Click += new System.EventHandler(this.nextBtn2_Click);
            // 
            // cancelBtn2
            // 
            this.cancelBtn2.ActiveBorderThickness = 1;
            this.cancelBtn2.ActiveCornerRadius = 20;
            this.cancelBtn2.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn2.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn2.ActiveLineColor = System.Drawing.Color.Silver;
            this.cancelBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn2.BackgroundImage")));
            this.cancelBtn2.ButtonText = "Cancel";
            this.cancelBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn2.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelBtn2.IdleBorderThickness = 1;
            this.cancelBtn2.IdleCornerRadius = 20;
            this.cancelBtn2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelBtn2.IdleLineColor = System.Drawing.Color.Silver;
            this.cancelBtn2.Location = new System.Drawing.Point(288, 265);
            this.cancelBtn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn2.Name = "cancelBtn2";
            this.cancelBtn2.Size = new System.Drawing.Size(98, 37);
            this.cancelBtn2.TabIndex = 54;
            this.cancelBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn2.Click += new System.EventHandler(this.cancelBtn2_Click);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(21, 42);
            this.bunifuSeparator6.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(447, 19);
            this.bunifuSeparator6.TabIndex = 48;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // priceTextLabel
            // 
            this.priceTextLabel.AutoSize = true;
            this.priceTextLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.priceTextLabel.Location = new System.Drawing.Point(379, 66);
            this.priceTextLabel.Name = "priceTextLabel";
            this.priceTextLabel.Size = new System.Drawing.Size(0, 19);
            this.priceTextLabel.TabIndex = 40;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(371, 95);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(43, 26);
            this.qtyTextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(284, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(284, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Price";
            // 
            // productNameCB
            // 
            this.productNameCB.FormattingEnabled = true;
            this.productNameCB.Location = new System.Drawing.Point(149, 62);
            this.productNameCB.Name = "productNameCB";
            this.productNameCB.Size = new System.Drawing.Size(121, 27);
            this.productNameCB.TabIndex = 36;
            this.productNameCB.SelectedIndexChanged += new System.EventHandler(this.productNameCB_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.ForeColor = System.Drawing.Color.Silver;
            this.productName.Location = new System.Drawing.Point(26, 64);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(97, 19);
            this.productName.TabIndex = 33;
            this.productName.Text = "Product Name";
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.productIDLabel.Location = new System.Drawing.Point(157, 95);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(0, 19);
            this.productIDLabel.TabIndex = 35;
            // 
            // productID
            // 
            this.productID.AutoSize = true;
            this.productID.ForeColor = System.Drawing.Color.Silver;
            this.productID.Location = new System.Drawing.Point(26, 98);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(75, 19);
            this.productID.TabIndex = 34;
            this.productID.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.bunifuSeparator7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.accNameCB);
            this.panel1.Controls.Add(this.accIDText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.refNoTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(80, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 307);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nextBtn
            // 
            this.nextBtn.ActiveBorderThickness = 1;
            this.nextBtn.ActiveCornerRadius = 20;
            this.nextBtn.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.nextBtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.nextBtn.ActiveLineColor = System.Drawing.Color.Silver;
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.ButtonText = "Next";
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextBtn.IdleBorderThickness = 1;
            this.nextBtn.IdleCornerRadius = 20;
            this.nextBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.nextBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.nextBtn.Location = new System.Drawing.Point(503, 256);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(98, 37);
            this.nextBtn.TabIndex = 52;
            this.nextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.ActiveBorderThickness = 1;
            this.cancelBtn.ActiveCornerRadius = 20;
            this.cancelBtn.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn.ActiveLineColor = System.Drawing.Color.Silver;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelBtn.IdleBorderThickness = 1;
            this.cancelBtn.IdleCornerRadius = 20;
            this.cancelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.cancelBtn.Location = new System.Drawing.Point(397, 256);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 37);
            this.cancelBtn.TabIndex = 51;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(12, 42);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(253, 19);
            this.bunifuSeparator7.TabIndex = 49;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.previousBtn2);
            this.panel3.Controls.Add(this.submitBtn);
            this.panel3.Controls.Add(this.cancelBtn3);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.ExpiryYear);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ExpiryMonth);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.bunifuSeparator2);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Controls.Add(this.bunifuSeparator1);
            this.panel3.Controls.Add(this.chqNoRad);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.cardCvc);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.cardNo);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(80, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(611, 307);
            this.panel3.TabIndex = 32;
            // 
            // previousBtn2
            // 
            this.previousBtn2.ActiveBorderThickness = 1;
            this.previousBtn2.ActiveCornerRadius = 20;
            this.previousBtn2.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.previousBtn2.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.previousBtn2.ActiveLineColor = System.Drawing.Color.Silver;
            this.previousBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.previousBtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousBtn2.BackgroundImage")));
            this.previousBtn2.ButtonText = "Previous";
            this.previousBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn2.ForeColor = System.Drawing.Color.SeaGreen;
            this.previousBtn2.IdleBorderThickness = 1;
            this.previousBtn2.IdleCornerRadius = 20;
            this.previousBtn2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.previousBtn2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.previousBtn2.IdleLineColor = System.Drawing.Color.Silver;
            this.previousBtn2.Location = new System.Drawing.Point(397, 265);
            this.previousBtn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousBtn2.Name = "previousBtn2";
            this.previousBtn2.Size = new System.Drawing.Size(98, 37);
            this.previousBtn2.TabIndex = 54;
            this.previousBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previousBtn2.Click += new System.EventHandler(this.previousBtn2_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.ActiveBorderThickness = 1;
            this.submitBtn.ActiveCornerRadius = 20;
            this.submitBtn.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.submitBtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.ActiveLineColor = System.Drawing.Color.Silver;
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.submitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBtn.BackgroundImage")));
            this.submitBtn.ButtonText = "Submit";
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.submitBtn.IdleBorderThickness = 1;
            this.submitBtn.IdleCornerRadius = 20;
            this.submitBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.submitBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.submitBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.submitBtn.Location = new System.Drawing.Point(503, 265);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(98, 37);
            this.submitBtn.TabIndex = 57;
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn3
            // 
            this.cancelBtn3.ActiveBorderThickness = 1;
            this.cancelBtn3.ActiveCornerRadius = 20;
            this.cancelBtn3.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.cancelBtn3.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.cancelBtn3.ActiveLineColor = System.Drawing.Color.Silver;
            this.cancelBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn3.BackgroundImage")));
            this.cancelBtn3.ButtonText = "Cancel";
            this.cancelBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn3.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelBtn3.IdleBorderThickness = 1;
            this.cancelBtn3.IdleCornerRadius = 20;
            this.cancelBtn3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.cancelBtn3.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelBtn3.IdleLineColor = System.Drawing.Color.Silver;
            this.cancelBtn3.Location = new System.Drawing.Point(291, 265);
            this.cancelBtn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn3.Name = "cancelBtn3";
            this.cancelBtn3.Size = new System.Drawing.Size(98, 37);
            this.cancelBtn3.TabIndex = 56;
            this.cancelBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn3.Click += new System.EventHandler(this.cancelBtn3_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(174, 148);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(191, 13);
            this.bunifuCustomLabel2.TabIndex = 55;
            this.bunifuCustomLabel2.Text = "For Year enter the full year (Ex. 2021)";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(177, 189);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(402, 16);
            this.bunifuSeparator3.TabIndex = 54;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // ExpiryYear
            // 
            this.ExpiryYear.Enabled = false;
            this.ExpiryYear.ForeColor = System.Drawing.Color.Black;
            this.ExpiryYear.Location = new System.Drawing.Point(382, 103);
            this.ExpiryYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExpiryYear.Name = "ExpiryYear";
            this.ExpiryYear.Size = new System.Drawing.Size(40, 26);
            this.ExpiryYear.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(335, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Year";
            // 
            // ExpiryMonth
            // 
            this.ExpiryMonth.Enabled = false;
            this.ExpiryMonth.ForeColor = System.Drawing.Color.Black;
            this.ExpiryMonth.Location = new System.Drawing.Point(257, 103);
            this.ExpiryMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExpiryMonth.Name = "ExpiryMonth";
            this.ExpiryMonth.Size = new System.Drawing.Size(32, 26);
            this.ExpiryMonth.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(174, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Month";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(140, 59);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(20, 201);
            this.bunifuSeparator2.TabIndex = 49;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 8);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(108, 25);
            this.bunifuCustomLabel1.TabIndex = 48;
            this.bunifuCustomLabel1.Text = "Transaction";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, 33);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(597, 13);
            this.bunifuSeparator1.TabIndex = 47;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // chqNoRad
            // 
            this.chqNoRad.Enabled = false;
            this.chqNoRad.ForeColor = System.Drawing.Color.Black;
            this.chqNoRad.Location = new System.Drawing.Point(257, 217);
            this.chqNoRad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chqNoRad.Name = "chqNoRad";
            this.chqNoRad.Size = new System.Drawing.Size(322, 26);
            this.chqNoRad.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(174, 221);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "Cheque No";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.Silver;
            this.radioButton2.Location = new System.Drawing.Point(14, 109);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 23);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.Text = "Credit/Debit Card";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cardCvc
            // 
            this.cardCvc.Enabled = false;
            this.cardCvc.ForeColor = System.Drawing.Color.Black;
            this.cardCvc.Location = new System.Drawing.Point(503, 103);
            this.cardCvc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardCvc.Name = "cardCvc";
            this.cardCvc.Size = new System.Drawing.Size(76, 26);
            this.cardCvc.TabIndex = 43;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.DimGray;
            this.radioButton1.Location = new System.Drawing.Point(14, 89);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 23);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(453, 105);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "CVC";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.ForeColor = System.Drawing.Color.Silver;
            this.radioButton3.Location = new System.Drawing.Point(14, 129);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(109, 23);
            this.radioButton3.TabIndex = 38;
            this.radioButton3.Text = "Bank Transfer";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(11, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Payment Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(174, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 41;
            this.label12.Text = "Card No";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.ForeColor = System.Drawing.Color.Silver;
            this.radioButton5.Location = new System.Drawing.Point(14, 170);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(118, 23);
            this.radioButton5.TabIndex = 40;
            this.radioButton5.Text = "Credit Account";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Transparent;
            this.radioButton4.ForeColor = System.Drawing.Color.Silver;
            this.radioButton4.Location = new System.Drawing.Point(14, 150);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 23);
            this.radioButton4.TabIndex = 39;
            this.radioButton4.Text = "Cheque";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // cardNo
            // 
            this.cardNo.Enabled = false;
            this.cardNo.ForeColor = System.Drawing.Color.Black;
            this.cardNo.Location = new System.Drawing.Point(257, 61);
            this.cardNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(322, 26);
            this.cardNo.TabIndex = 42;
            this.cardNo.TextChanged += new System.EventHandler(this.cardNoRad_TextChanged);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(79, 54);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(612, 6);
            this.bunifuSeparator4.TabIndex = 48;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(74, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Order Details";
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(776, 425);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox accNameCB;
        private System.Windows.Forms.TextBox refNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accIDText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label priceTextLabel;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productNameCB;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label productID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.TextBox ExpiryYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ExpiryMonth;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox chqNoRad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox cardCvc;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox cardNo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn2;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 nextBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 nextBtn2;
        private Bunifu.Framework.UI.BunifuThinButton2 submitBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn3;
        private System.Windows.Forms.DataGridView productListView;
        private Bunifu.Framework.UI.BunifuThinButton2 addProductBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 previousBtn1;
        private Bunifu.Framework.UI.BunifuThinButton2 previousBtn2;
    }
}