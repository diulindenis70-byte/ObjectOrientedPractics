using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Тренировочный элемент управления для работы с одним приоритетным заказом.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _priorityOrder;

        /// <summary>
        /// Генератор случайных чисел для добавления случайного товара.
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// Возвращает и задает список доступных товаров магазина.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            deliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimeRanges;
            orderItemsListBox.DisplayMember = "Name";

            CreateNewPriorityOrder();
        }

        /// <summary>
        /// Создает новый объект приоритетного заказа и отображает его данные на форме.
        /// </summary>
        private void CreateNewPriorityOrder()
        {
            _priorityOrder = new PriorityOrder();
            UpdateOrderInfo();
        }

        /// <summary>
        /// Обновляет все элементы управления данными из текущего приоритетного заказа.
        /// </summary>
        private void UpdateOrderInfo()
        {
            idTextBox.Text = _priorityOrder.Id.ToString();
            createdTextBox.Text = _priorityOrder.Date.ToString("g");
            statusComboBox.SelectedItem = _priorityOrder.Status;
            deliveryTimeComboBox.SelectedItem = _priorityOrder.DeliveryTime;
            OrderAddressControl.Address = _priorityOrder.Address;

            UpdateItemsList();
        }

        /// <summary>
        /// Обновляет список товаров и итоговую стоимость заказа.
        /// </summary>
        private void UpdateItemsList()
        {
            int previousIndex = orderItemsListBox.SelectedIndex;
            orderItemsListBox.Items.Clear();

            foreach (var item in _priorityOrder.Items)
            {
                orderItemsListBox.Items.Add(item);
            }

            if (orderItemsListBox.Items.Count > 0)
            {
                orderItemsListBox.SelectedIndex = Math.Min(previousIndex, orderItemsListBox.Items.Count - 1);
            }

            amountValueLabel.Text = $"{_priorityOrder.Amount:F2}";
        }

        /// <summary>
        /// Сохраняет выбранный статус в объект приоритетного заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null && statusComboBox.SelectedItem is OrderStatus newStatus)
            {
                _priorityOrder.Status = newStatus;
            }
        }

        /// <summary>
        /// Сохраняет выбранный диапазон времени доставки в объект приоритетного заказа.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder != null && deliveryTimeComboBox.SelectedItem is string newTime)
            {
                _priorityOrder.DeliveryTime = newTime;
            }
        }

        /// <summary>
        /// Добавляет случайный товар в заказ.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item randomItem;
            if (Items != null && Items.Count > 0)
            {
                randomItem = Items[_random.Next(Items.Count)];
            }
            else
            {
                int number = _random.Next(1, 100);
                double cost = Math.Round(_random.NextDouble() * 5000 + 100, 2);
                var categories = Enum.GetValues(typeof(Category));
                Category category = (Category)categories.GetValue(_random.Next(categories.Length));
                randomItem = new Item($"Sample Item #{number}", "Generated item", cost, category);
            }

            _priorityOrder.Items.Add(randomItem);
            UpdateItemsList();
            orderItemsListBox.SelectedIndex = orderItemsListBox.Items.Count - 1;
        }

        /// <summary>
        /// Удаляет выбранный товар из заказа и сдвигает выделение.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = orderItemsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _priorityOrder.Items.Count)
            {
                return;
            }

            _priorityOrder.Items.RemoveAt(selectedIndex);
            UpdateItemsList();

            if (orderItemsListBox.Items.Count > 0)
            {
                orderItemsListBox.SelectedIndex = selectedIndex < orderItemsListBox.Items.Count
                    ? selectedIndex
                    : orderItemsListBox.Items.Count - 1;
            }
        }

        /// <summary>
        /// Удаляет текущий объект приоритетного заказа и создает новый экземпляр.
        /// </summary>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                _priorityOrder.Address = OrderAddressControl.Address;
            }
            catch
            {
                // Игнорируем ошибки невалидного ввода перед сбросом заказа
            }

            CreateNewPriorityOrder();
        }
    }
}