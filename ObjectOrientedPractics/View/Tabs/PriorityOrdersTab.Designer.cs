namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            selectedOrderLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            createdLabel = new Label();
            createdTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            priorityOptionsLabel = new Label();
            deliveryTimeLabel = new Label();
            deliveryTimeComboBox = new ComboBox();
            OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            orderItemsLabel = new Label();
            orderItemsListBox = new ListBox();
            amountTitleLabel = new Label();
            amountValueLabel = new Label();
            addItemButton = new Button();
            removeItemButton = new Button();
            clearOrderButton = new Button();
            SuspendLayout();
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedOrderLabel.Location = new Point(12, 12);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(105, 17);
            selectedOrderLabel.TabIndex = 0;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(85, 39);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(160, 27);
            idTextBox.TabIndex = 2;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(12, 78);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(64, 20);
            createdLabel.TabIndex = 3;
            createdLabel.Text = "Created:";
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(85, 75);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(160, 27);
            createdTextBox.TabIndex = 4;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(12, 114);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(85, 111);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(160, 28);
            statusComboBox.TabIndex = 6;
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priorityOptionsLabel.Location = new Point(280, 12);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new Size(125, 17);
            priorityOptionsLabel.TabIndex = 7;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(280, 42);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(102, 20);
            deliveryTimeLabel.TabIndex = 8;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Location = new Point(388, 39);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(160, 28);
            deliveryTimeComboBox.TabIndex = 9;
            deliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.BackColor = Color.White;
            OrderAddressControl.Location = new Point(12, 155);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(536, 170);
            OrderAddressControl.TabIndex = 10;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderItemsLabel.Location = new Point(12, 335);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(92, 17);
            orderItemsLabel.TabIndex = 11;
            orderItemsLabel.Text = "Order Items";
            // 
            // orderItemsListBox
            // 
            orderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsListBox.FormattingEnabled = true;
            orderItemsListBox.IntegralHeight = false;
            orderItemsListBox.Location = new Point(12, 358);
            orderItemsListBox.Name = "orderItemsListBox";
            orderItemsListBox.Size = new Size(536, 150);
            orderItemsListBox.TabIndex = 12;
            // 
            // amountTitleLabel
            // 
            amountTitleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountTitleLabel.AutoSize = true;
            amountTitleLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountTitleLabel.Location = new Point(481, 515);
            amountTitleLabel.Name = "amountTitleLabel";
            amountTitleLabel.Size = new Size(67, 17);
            amountTitleLabel.TabIndex = 13;
            amountTitleLabel.Text = "Amount:";
            // 
            // amountValueLabel
            // 
            amountValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountValueLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountValueLabel.Location = new Point(348, 535);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(200, 30);
            amountValueLabel.TabIndex = 14;
            amountValueLabel.Text = "0,00";
            amountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addItemButton.Location = new Point(12, 575);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(110, 32);
            addItemButton.TabIndex = 15;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += AddItemButton_Click;
            // 
            // removeItemButton
            // 
            removeItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeItemButton.Location = new Point(132, 575);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(110, 32);
            removeItemButton.TabIndex = 16;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += RemoveItemButton_Click;
            // 
            // clearOrderButton
            // 
            clearOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearOrderButton.Location = new Point(438, 575);
            clearOrderButton.Name = "clearOrderButton";
            clearOrderButton.Size = new Size(110, 32);
            clearOrderButton.TabIndex = 17;
            clearOrderButton.Text = "Clear Order";
            clearOrderButton.UseVisualStyleBackColor = true;
            clearOrderButton.Click += ClearOrderButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(clearOrderButton);
            Controls.Add(removeItemButton);
            Controls.Add(addItemButton);
            Controls.Add(amountValueLabel);
            Controls.Add(amountTitleLabel);
            Controls.Add(orderItemsListBox);
            Controls.Add(orderItemsLabel);
            Controls.Add(OrderAddressControl);
            Controls.Add(deliveryTimeComboBox);
            Controls.Add(deliveryTimeLabel);
            Controls.Add(priorityOptionsLabel);
            Controls.Add(statusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(createdTextBox);
            Controls.Add(createdLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(selectedOrderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(565, 620);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label selectedOrderLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label createdLabel;
        private TextBox createdTextBox;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private Label priorityOptionsLabel;
        private Label deliveryTimeLabel;
        private ComboBox deliveryTimeComboBox;
        private ObjectOrientedPractics.View.Controls.AddressControl OrderAddressControl;
        private Label orderItemsLabel;
        private ListBox orderItemsListBox;
        private Label amountTitleLabel;
        private Label amountValueLabel;
        private Button addItemButton;
        private Button removeItemButton;
        private Button clearOrderButton;
    }
}
