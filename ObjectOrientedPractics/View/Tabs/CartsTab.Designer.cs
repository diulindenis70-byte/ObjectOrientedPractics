namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.amountTitleLabel = new System.Windows.Forms.Label();
            this.amountValueLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(3, 10);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(41, 13);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.IntegralHeight = false;
            this.itemsListBox.Location = new System.Drawing.Point(6, 26);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(260, 480);
            this.itemsListBox.TabIndex = 1;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Location = new System.Drawing.Point(6, 515);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 35);
            this.addToCartButton.TabIndex = 2;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(280, 10);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(63, 13);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customer:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(349, 7);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(350, 21);
            this.customersComboBox.TabIndex = 4;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(280, 45);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 5;
            this.cartLabel.Text = "Cart:";
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.IntegralHeight = false;
            this.cartListBox.Location = new System.Drawing.Point(283, 64);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(416, 200);
            this.cartListBox.TabIndex = 6;
            // 
            // amountTitleLabel
            // 
            this.amountTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTitleLabel.AutoSize = true;
            this.amountTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountTitleLabel.Location = new System.Drawing.Point(645, 275);
            this.amountTitleLabel.Name = "amountTitleLabel";
            this.amountTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.amountTitleLabel.TabIndex = 7;
            this.amountTitleLabel.Text = "Amount:";
            // 
            // amountValueLabel
            // 
            this.amountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountValueLabel.Location = new System.Drawing.Point(499, 295);
            this.amountValueLabel.Name = "amountValueLabel";
            this.amountValueLabel.Size = new System.Drawing.Size(200, 25);
            this.amountValueLabel.TabIndex = 8;
            this.amountValueLabel.Text = "0,00";
            this.amountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createOrderButton.Location = new System.Drawing.Point(283, 335);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(95, 30);
            this.createOrderButton.TabIndex = 9;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Location = new System.Drawing.Point(509, 335);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(90, 30);
            this.removeItemButton.TabIndex = 10;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartButton.Location = new System.Drawing.Point(609, 335);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(90, 30);
            this.clearCartButton.TabIndex = 11;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.amountValueLabel);
            this.Controls.Add(this.amountTitleLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.itemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(710, 560);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label amountTitleLabel;
        private System.Windows.Forms.Label amountValueLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
    }
}