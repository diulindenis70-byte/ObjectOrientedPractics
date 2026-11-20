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
        /// Список всех активных заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Список заказов, отображаемых в текущий момент в таблице (с учетом фильтра).
        /// </summary>
        private List<Order> _displayedOrders = new List<Order>();

        /// <summary>
        /// Текущий выбранный заказ в таблице.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Текущий выбранный приоритетный заказ (null, если выбран обычный заказ).
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Возвращает и задает текущий выбранный заказ, обновляя состояние полей приоритетного заказа.
        /// </summary>
        private Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                _selectedOrder = value;

                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    _selectedPriorityOrder = priorityOrder;
                    priorityOptionsPanel.Visible = true;
                    deliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DeliveryTime;
                }
                else
                {
                    _selectedPriorityOrder = null;
                    priorityOptionsPanel.Visible = false;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            SetupDataGridView();
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            deliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimeRanges;

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
            ordersDataGridView.Columns.Add("Priority", "");
            ordersDataGridView.Columns["Priority"].Width = 30;
            ordersDataGridView.Columns["Priority"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
        /// Собирает все заказы у всех покупателей и обновляет таблицу.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();

            if (Customers != null)
            {
                foreach (var customer in Customers)
                {
                    if (customer.Orders == null) continue;

                    foreach (var order in customer.Orders)
                    {
                        _orders.Add(order);
                    }
                }
            }

            DisplayOrders();
        }

        /// <summary>
        /// Заполняет таблицу заказами с учетом активного фильтра приоритетных заказов.
        /// </summary>
        private void DisplayOrders()
        {
            _displayedOrders.Clear();
            ordersDataGridView.Rows.Clear();
            ClearSelectedOrderPanel();

            if (Customers == null) return;

            bool onlyPriority = showOnlyPriorityCheckBox.Checked;

            foreach (var customer in Customers)
            {
                if (customer.Orders == null) continue;

                foreach (var order in customer.Orders)
                {
                    bool isPriority = order is PriorityOrder;
                    if (onlyPriority && !isPriority)
                    {
                        continue;
                    }

                    _displayedOrders.Add(order);

                    string priorityMark = isPriority ? "★" : "";
                    string addressString = order.Address != null
                        ? $"{order.Address.Country}, {order.Address.City}, {order.Address.Street}, {order.Address.Building}"
                        : "";

                    ordersDataGridView.Rows.Add(
                        priorityMark,
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
        /// Обрабатывает переключение флажка отображения только приоритетных заказов.
        /// </summary>
        private void ShowOnlyPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayOrders();
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранной строки в таблице заказов, заполняя форму справа.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow == null ||
                ordersDataGridView.CurrentRow.Index < 0 ||
                ordersDataGridView.CurrentRow.Index >= _displayedOrders.Count)
            {
                ClearSelectedOrderPanel();
                return;
            }

            SelectedOrder = _displayedOrders[ordersDataGridView.CurrentRow.Index];

            idTextBox.Text = SelectedOrder.Id.ToString();
            createdTextBox.Text = SelectedOrder.Date.ToString("g");
            statusComboBox.SelectedItem = SelectedOrder.Status;
            OrderAddressControl.Address = SelectedOrder.Address;

            orderItemsListBox.Items.Clear();
            foreach (var item in SelectedOrder.Items)
            {
                orderItemsListBox.Items.Add(item);
            }

            amountLabelValue.Text = $"{SelectedOrder.Amount:F2}";
        }

        /// <summary>
        /// Обрабатывает изменение статуса заказа пользователем в выпадающем списке.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null && statusComboBox.SelectedItem is OrderStatus newStatus)
            {
                SelectedOrder.Status = newStatus;
                if (ordersDataGridView.CurrentRow != null)
                {
                    ordersDataGridView.CurrentRow.Cells["OrderStatus"].Value = newStatus;
                }
            }
        }

        /// <summary>
        /// Обрабатывает изменение времени доставки для приоритетного заказа.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && deliveryTimeComboBox.SelectedItem is string newTime)
            {
                _selectedPriorityOrder.DeliveryTime = newTime;
            }
        }

        /// <summary>
        /// Очищает все поля на панели детальной информации о выбранном заказе.
        /// </summary>
        private void ClearSelectedOrderPanel()
        {
            SelectedOrder = null;
            idTextBox.Clear();
            createdTextBox.Clear();
            orderItemsListBox.Items.Clear();
            OrderAddressControl.ClearAddressInfo();
            amountLabelValue.Text = "0,00";
        }
    }
}