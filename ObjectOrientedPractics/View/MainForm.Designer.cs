namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            tabPage1 = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(910, 563);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(itemsTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(902, 530);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.BackColor = Color.White;
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(896, 524);
            itemsTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(customersTab1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(902, 530);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Customers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(896, 524);
            customersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cartsTab1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(902, 530);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Cart";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(ordersTab1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(902, 530);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Orders";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(3, 3);
            cartsTab1.Margin = new Padding(4, 5, 4, 5);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(896, 524);
            cartsTab1.TabIndex = 0;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Margin = new Padding(4, 5, 4, 5);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(896, 524);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 563);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage tabPage1;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private View.Tabs.CartsTab cartsTab1;
        private View.Tabs.OrdersTab ordersTab1;
    }
}
