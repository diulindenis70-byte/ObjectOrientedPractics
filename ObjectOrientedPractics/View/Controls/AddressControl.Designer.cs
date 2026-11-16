namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            StreetLabel = new Label();
            StreetTextBox = new TextBox();
            BuildingLabel = new Label();
            BuildingTextBox = new TextBox();
            ApartmentLabel = new Label();
            ApartmentTextBox = new TextBox();
            AddressToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(3, 2);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(125, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(3, 31);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(78, 20);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(88, 28);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(120, 27);
            PostIndexTextBox.TabIndex = 2;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(3, 64);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(88, 61);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(165, 27);
            CountryTextBox.TabIndex = 4;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(262, 64);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(305, 61);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(160, 27);
            CityTextBox.TabIndex = 6;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(3, 97);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(50, 20);
            StreetLabel.TabIndex = 7;
            StreetLabel.Text = "Street:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(88, 94);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(377, 27);
            StreetTextBox.TabIndex = 8;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(3, 130);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(66, 20);
            BuildingLabel.TabIndex = 9;
            BuildingLabel.Text = "Building:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(88, 127);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(90, 27);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(195, 130);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(82, 20);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(283, 127);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(90, 27);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ApartmentTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingTextBox);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetTextBox);
            Controls.Add(StreetLabel);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(CountryTextBox);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexTextBox);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            Name = "AddressControl";
            Size = new Size(468, 165);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private TextBox PostIndexTextBox;
        private Label CountryLabel;
        private TextBox CountryTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label StreetLabel;
        private TextBox StreetTextBox;
        private Label BuildingLabel;
        private TextBox BuildingTextBox;
        private Label ApartmentLabel;
        private TextBox ApartmentTextBox;
        private ToolTip AddressToolTip;
    }
}