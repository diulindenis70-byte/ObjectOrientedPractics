using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет пользовательский интерфейс для управления корзиной покупателя и оформления заказов.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список доступных товаров магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список товаров магазина.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                UpdateItemsListBox();
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей магазина.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                UpdateCustomersComboBox();
            }
        }

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
        /// Обновляет данные на вкладке при переключении на нее.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
        }

        /// <summary>
        /// Обновляет список доступных товаров.
        /// </summary>
        private void UpdateItemsListBox()
        {
            itemsListBox.Items.Clear();
            if (_items == null) return;

            foreach (var item in _items)
            {
                itemsListBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Обновляет выпадающий список покупателей.
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            customersComboBox.Items.Clear();
            _currentCustomer = null;
            UpdateCartListBox();

            if (_customers == null) return;

            foreach (var customer in _customers)
            {
                customersComboBox.Items.Add(customer);
            }

            if (customersComboBox.Items.Count > 0)
            {
                customersComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обновляет список товаров в корзине и общую стоимость.
        /// </summary>
        private void UpdateCartListBox()
        {
            cartListBox.Items.Clear();

            if (_currentCustomer == null || _currentCustomer.Cart == null)
            {
                amountValueLabel.Text = "0,00";
                return;
            }

            foreach (var item in _currentCustomer.Cart.Items)
            {
                cartListBox.Items.Add(item);
            }

            amountValueLabel.Text = $"{_currentCustomer.Cart.Amount:F2}";
        }

        /// <summary>
        /// Обрабатывает выбор другого покупателя в выпадающем списке.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = customersComboBox.SelectedItem as Customer;
            UpdateCartListBox();
        }

        /// <summary>
        /// Добавляет выбранный товар из каталога в корзину покупателя.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || itemsListBox.SelectedItem is not Item selectedItem)
            {
                return;
            }

            _currentCustomer.Cart.Items.Add(selectedItem);
            UpdateCartListBox();
        }

        /// <summary>
        /// Удаляет выбранный товар из корзины покупателя.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || cartListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentCustomer.Cart.Items.RemoveAt(cartListBox.SelectedIndex);
            UpdateCartListBox();
        }

        /// <summary>
        /// Полностью очищает корзину текущего покупателя.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }

        /// <summary>
        /// Создает обычный или приоритетный заказ из товаров в корзине текущего покупателя.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                return;
            }

            Address orderAddress = new Address(
                _currentCustomer.Address.Index,
                _currentCustomer.Address.Country,
                _currentCustomer.Address.City,
                _currentCustomer.Address.Street,
                _currentCustomer.Address.Building,
                _currentCustomer.Address.Apartment);

            Order newOrder;
            if (_currentCustomer.IsPriority)
            {
                newOrder = new PriorityOrder(
                    orderAddress,
                    _currentCustomer.Cart.Items,
                    DateTime.Now.Date.AddDays(1),
                    PriorityOrder.DeliveryTimeRanges[0]);
            }
            else
            {
                newOrder = new Order(orderAddress, _currentCustomer.Cart.Items);
            }

            _currentCustomer.Orders.Add(newOrder);
            _currentCustomer.Cart.Items.Clear();
            UpdateCartListBox();
        }
    }
}
