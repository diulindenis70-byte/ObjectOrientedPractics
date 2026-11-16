using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет пользовательский элемент для управления корзиной товаров.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает внутренний список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает внутренний список пользователей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает и задает выбранного покупателя из выпадающего списка.
        /// </summary>
        private Customer CurrentCustomer => customersComboBox.SelectedItem as Customer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            itemsListBox.DisplayMember = "Name";
            cartListBox.DisplayMember = "Name";
            customersComboBox.DisplayMember = "Fullname";
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            itemsListBox.Items.Clear();
            if (Items != null)
            {
                foreach (var item in Items)
                {
                    itemsListBox.Items.Add(item);
                }
            }

            customersComboBox.Items.Clear();
            if (Customers != null)
            {
                foreach (var customer in Customers)
                {
                    customersComboBox.Items.Add(customer);
                }
            }

            UpdateCartDisplay();
        }

        /// <summary>
        /// Перерисовывает содержимое корзины текущего покупателя и обновляет общую стоимость.
        /// </summary>
        private void UpdateCartDisplay()
        {
            cartListBox.Items.Clear();
            if (CurrentCustomer != null && CurrentCustomer.Cart != null)
            {
                foreach (var item in CurrentCustomer.Cart.Items)
                {
                    cartListBox.Items.Add(item);
                }
                amountValueLabel.Text = $"{CurrentCustomer.Cart.Amount:F2}";
            }
            else
            {
                amountValueLabel.Text = "0,00";
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного покупателя в выпадающем списке.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCartDisplay();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления выбранного товара в корзину покупателя.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedItem is Item selectedItem && CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Add(selectedItem);
                UpdateCartDisplay();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления выбранного товара из корзины.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem is Item selectedItem && CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Remove(selectedItem);
                UpdateCartDisplay();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки полной очистки текущей корзины покупателя.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                UpdateCartDisplay();
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки оформления заказа на основе товаров в корзине.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                return;
            }

            var order = new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items);
            CurrentCustomer.Orders.Add(order);

            CurrentCustomer.Cart.Items.Clear();
            UpdateCartDisplay();
        }
    }
}
