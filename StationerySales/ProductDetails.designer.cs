namespace StationerySales
{
    partial class ProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetails));
            this.product_id = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.cateCB = new System.Windows.Forms.ComboBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.confirmBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // product_id
            // 
            this.product_id.AutoSize = true;
            this.product_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id.ForeColor = System.Drawing.Color.Silver;
            this.product_id.Location = new System.Drawing.Point(40, 58);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(92, 23);
            this.product_id.TabIndex = 4;
            this.product_id.Text = "Product ID";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.ForeColor = System.Drawing.Color.Silver;
            this.product_name.Location = new System.Drawing.Point(40, 95);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(121, 23);
            this.product_name.TabIndex = 3;
            this.product_name.Text = "Product Name";
            // 
            // cateCB
            // 
            this.cateCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cateCB.FormattingEnabled = true;
            this.cateCB.Items.AddRange(new object[] {
            "Writing Tools",
            "Notebook & Diary",
            "Office Equipment",
            "Files & Folders",
            "Others"});
            this.cateCB.Location = new System.Drawing.Point(178, 134);
            this.cateCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cateCB.Name = "cateCB";
            this.cateCB.Size = new System.Drawing.Size(193, 31);
            this.cateCB.TabIndex = 22;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(178, 219);
            this.qtyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(193, 30);
            this.qtyTextBox.TabIndex = 21;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(178, 176);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(193, 30);
            this.priceTextBox.TabIndex = 20;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Silver;
            this.quantity.Location = new System.Drawing.Point(40, 222);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(76, 23);
            this.quantity.TabIndex = 19;
            this.quantity.Text = "Quantity";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Silver;
            this.price.Location = new System.Drawing.Point(40, 178);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(47, 23);
            this.price.TabIndex = 18;
            this.price.Text = "Price";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.Color.Silver;
            this.category.Location = new System.Drawing.Point(40, 137);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(79, 23);
            this.category.TabIndex = 17;
            this.category.Text = "Category";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(178, 55);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(193, 30);
            this.IDTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(178, 92);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 30);
            this.nameTextBox.TabIndex = 24;
            // 
            // confirmBtn
            // 
            this.confirmBtn.ActiveBorderThickness = 1;
            this.confirmBtn.ActiveCornerRadius = 20;
            this.confirmBtn.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.confirmBtn.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.confirmBtn.ActiveLineColor = System.Drawing.Color.Silver;
            this.confirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.ButtonText = "Confirm";
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirmBtn.IdleBorderThickness = 1;
            this.confirmBtn.IdleCornerRadius = 20;
            this.confirmBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.confirmBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmBtn.IdleLineColor = System.Drawing.Color.Silver;
            this.confirmBtn.Location = new System.Drawing.Point(59, 293);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(130, 45);
            this.confirmBtn.TabIndex = 38;
            this.confirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
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
            this.cancelBtn.Location = new System.Drawing.Point(220, 293);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 45);
            this.cancelBtn.TabIndex = 39;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(408, 380);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.cateCB);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.product_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label product_id;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.ComboBox cateCB;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
    }
}