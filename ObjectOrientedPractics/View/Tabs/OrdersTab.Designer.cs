namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            ordersLabel = new Label();
            ordersDataGridView = new DataGridView();
            showOnlyPriorityCheckBox = new CheckBox();
            selectedOrderLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            createdLabel = new Label();
            createdTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            priorityOptionsPanel = new Panel();
            priorityOptionsLabel = new Label();
            deliveryTimeLabel = new Label();
            deliveryTimeComboBox = new ComboBox();
            OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            orderItemsLabel = new Label();
            orderItemsListBox = new ListBox();
            amountTitleLabel = new Label();
            amountLabelValue = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            priorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ordersLabel.Location = new Point(4, 15);
            ordersLabel.Margin = new Padding(4, 0, 4, 0);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(63, 17);
            ordersLabel.TabIndex = 0;
            ordersLabel.Text = "Orders:";
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(8, 40);
            ordersDataGridView.Margin = new Padding(4, 5, 4, 5);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(480, 645);
            ordersDataGridView.TabIndex = 1;
            ordersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // showOnlyPriorityCheckBox
            // 
            showOnlyPriorityCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            showOnlyPriorityCheckBox.AutoSize = true;
            showOnlyPriorityCheckBox.Location = new Point(8, 693);
            showOnlyPriorityCheckBox.Name = "showOnlyPriorityCheckBox";
            showOnlyPriorityCheckBox.Size = new Size(203, 24);
            showOnlyPriorityCheckBox.TabIndex = 14;
            showOnlyPriorityCheckBox.Text = "Show Only Priority Orders";
            showOnlyPriorityCheckBox.UseVisualStyleBackColor = true;
            showOnlyPriorityCheckBox.CheckedChanged += ShowOnlyPriorityCheckBox_CheckedChanged;
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedOrderLabel.Location = new Point(507, 15);
            selectedOrderLabel.Margin = new Padding(4, 0, 4, 0);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(123, 17);
            selectedOrderLabel.TabIndex = 2;
            selectedOrderLabel.Text = "Selected Order:";
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(507, 54);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 3;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            idTextBox.Location = new Point(587, 49);
            idTextBox.Margin = new Padding(4, 5, 4, 5);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(155, 27);
            idTextBox.TabIndex = 4;
            // 
            // createdLabel
            // 
            createdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(507, 100);
            createdLabel.Margin = new Padding(4, 0, 4, 0);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(64, 20);
            createdLabel.TabIndex = 5;
            createdLabel.Text = "Created:";
            // 
            // createdTextBox
            // 
            createdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            createdTextBox.Location = new Point(587, 95);
            createdTextBox.Margin = new Padding(4, 5, 4, 5);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(155, 27);
            createdTextBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(507, 146);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(587, 142);
            statusComboBox.Margin = new Padding(4, 5, 4, 5);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(155, 28);
            statusComboBox.TabIndex = 8;
            statusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // priorityOptionsPanel
            // 
            priorityOptionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priorityOptionsPanel.Controls.Add(deliveryTimeComboBox);
            priorityOptionsPanel.Controls.Add(deliveryTimeLabel);
            priorityOptionsPanel.Controls.Add(priorityOptionsLabel);
            priorityOptionsPanel.Location = new Point(752, 15);
            priorityOptionsPanel.Name = "priorityOptionsPanel";
            priorityOptionsPanel.Size = new Size(250, 90);
            priorityOptionsPanel.TabIndex = 15;
            priorityOptionsPanel.Visible = false;
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priorityOptionsLabel.Location = new Point(3, 0);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new Size(125, 17);
            priorityOptionsLabel.TabIndex = 0;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(3, 39);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(102, 20);
            deliveryTimeLabel.TabIndex = 1;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Location = new Point(111, 35);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(134, 28);
            deliveryTimeComboBox.TabIndex = 2;
            deliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // OrderAddressControl
            // 
            OrderAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderAddressControl.BackColor = Color.White;
            OrderAddressControl.Location = new Point(507, 192);
            OrderAddressControl.Margin = new Padding(4, 5, 4, 5);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(493, 223);
            OrderAddressControl.TabIndex = 9;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderItemsLabel.Location = new Point(507, 431);
            orderItemsLabel.Margin = new Padding(4, 0, 4, 0);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(98, 17);
            orderItemsLabel.TabIndex = 10;
            orderItemsLabel.Text = "Order Items:";
            //
            // orderItemsListBox
            //
            orderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            orderItemsListBox.FormattingEnabled = true;
            orderItemsListBox.IntegralHeight = false;
            orderItemsListBox.Location = new Point(507, 458);
            orderItemsListBox.Margin = new Padding(4, 5, 4, 5);
            orderItemsListBox.Name = "orderItemsListBox";
            orderItemsListBox.SelectionMode = SelectionMode.None;
            orderItemsListBox.Size = new Size(492, 259);
            orderItemsListBox.TabIndex = 11;
            //
            // amountTitleLabel
            //
            amountTitleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountTitleLabel.AutoSize = true;
            amountTitleLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountTitleLabel.Location = new Point(927, 738);
            amountTitleLabel.Margin = new Padding(4, 0, 4, 0);
            amountTitleLabel.Name = "amountTitleLabel";
            amountTitleLabel.Size = new Size(67, 17);
            amountTitleLabel.TabIndex = 12;
            amountTitleLabel.Text = "Amount:";
            //
            // amountLabelValue
            //
            amountLabelValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabelValue.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabelValue.Location = new Point(731, 769);
            amountLabelValue.Margin = new Padding(4, 0, 4, 0);
            amountLabelValue.Name = "amountLabelValue";
            amountLabelValue.Size = new Size(267, 38);
            amountLabelValue.TabIndex = 13;
            amountLabelValue.Text = "0,00";
            amountLabelValue.TextAlign = ContentAlignment.MiddleRight;
            //
            // OrdersTab
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(priorityOptionsPanel);
            Controls.Add(showOnlyPriorityCheckBox);
            Controls.Add(amountLabelValue);
            Controls.Add(amountTitleLabel);
            Controls.Add(orderItemsListBox);
            Controls.Add(orderItemsLabel);
            Controls.Add(OrderAddressControl);
            Controls.Add(statusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(createdTextBox);
            Controls.Add(createdLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(selectedOrderLabel);
            Controls.Add(ordersDataGridView);
            Controls.Add(ordersLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrdersTab";
            Size = new Size(1013, 862);
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            priorityOptionsPanel.ResumeLayout(false);
            priorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.CheckBox showOnlyPriorityCheckBox;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Panel priorityOptionsPanel;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private ObjectOrientedPractics.View.Controls.AddressControl OrderAddressControl;
        private System.Windows.Forms.Label orderItemsLabel;
        private System.Windows.Forms.ListBox orderItemsListBox;
        private System.Windows.Forms.Label amountTitleLabel;
        private System.Windows.Forms.Label amountLabelValue;
    }
}