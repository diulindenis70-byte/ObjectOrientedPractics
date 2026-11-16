using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет пользовательский интерфейс для отображения и изменения статуса заказов всех покупателей.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает список покупателей для извлечения информации об их заказах.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список всех активных заказов, отображаемых в таблице.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Текущий выбранный заказ в таблице.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            SetupDataGridView();
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            orderItemsListBox.DisplayMember = "Name";
            OrderAddressControl.SetReadOnly(true);
        }

        /// <summary>
        /// Выполняет начальную конфигурацию столбцов и режимов выбора в <see cref="DataGridView"/>.
        /// </summary>
        private void SetupDataGridView()
        {
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.AllowUserToOrderColumns = false;

            ordersDataGridView.Columns.Clear();
            ordersDataGridView.Columns.Add("Id", "Id");
            ordersDataGridView.Columns.Add("Created", "Created");
            ordersDataGridView.Columns.Add("OrderStatus", "Order Status");
            ordersDataGridView.Columns.Add("CustomerFullName", "Customer Full Name");
            ordersDataGridView.Columns.Add("DeliveryAddress", "Delivery Address");
            ordersDataGridView.Columns.Add("Amount", "Amount");

            foreach (DataGridViewColumn col in ordersDataGridView.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Публичный метод для принудительного обновления списка заказов на вкладке.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Собирает все заказы у всех покупателей, объединяет их в один список и выводит в таблицу.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            ordersDataGridView.Rows.Clear();
            ClearSelectedOrderPanel();

            if (Customers == null) return;

            foreach (var customer in Customers)
            {
                if (customer.Orders == null) continue;

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    string addressString = customer.Address != null
                        ? $"{customer.Address.Country}, {customer.Address.City}, {customer.Address.Street}, {customer.Address.Building}"
                        : "";

                    ordersDataGridView.Rows.Add(
                        order.Id,
                        order.Date.ToString("g"),
                        order.Status,
                        customer.Fullname,
                        addressString,
                        $"{order.Amount:F2}"
                    );
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранной строки в таблице заказов, заполняя форму справа.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow == null || ordersDataGridView.CurrentRow.Index < 0 || ordersDataGridView.CurrentRow.Index >= _orders.Count)
            {
                ClearSelectedOrderPanel();
                return;
            }

            _selectedOrder = _orders[ordersDataGridView.CurrentRow.Index];
            idTextBox.Text = _selectedOrder.Id.ToString();
            createdTextBox.Text = _selectedOrder.Date.ToString("g");
            statusComboBox.SelectedItem = _selectedOrder.Status;
            OrderAddressControl.Address = _selectedOrder.Address;

            orderItemsListBox.Items.Clear();
            foreach (var item in _selectedOrder.Items)
            {
                orderItemsListBox.Items.Add(item);
            }

            amountLabelValue.Text = $"{_selectedOrder.Amount:F2}";
        }

        /// <summary>
        /// Обрабатывает изменение статуса заказа пользователем в выпадающем списке.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedOrder != null && statusComboBox.SelectedItem is OrderStatus newStatus)
            {
                _selectedOrder.Status = newStatus;
                if (ordersDataGridView.CurrentRow != null)
                {
                    ordersDataGridView.CurrentRow.Cells["OrderStatus"].Value = newStatus;
                }
            }
        }

        /// <summary>
        /// Очищает все поля на панели детальной информации о выбранном заказе.
        /// </summary>
        private void ClearSelectedOrderPanel()
        {
            _selectedOrder = null;
            idTextBox.Clear();
            createdTextBox.Clear();
            orderItemsListBox.Items.Clear();
            OrderAddressControl.ClearAddressInfo();
            amountLabelValue.Text = "0,00";
        }
    }
}