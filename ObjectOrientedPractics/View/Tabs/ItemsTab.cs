using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
     /// Представляет пользовательский элемент управления для вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Внутренняя коллекция товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет текстовые поля товара при выборе другого товара в списке.
        /// </summary>
        private void ItemListBox_SelectIndexChange(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            _currentItem = _items[ItemsListBox.SelectedIndex];

            IdTextBox.Text = _currentItem.Id.ToString();
            NameTextBox.Text = _currentItem.Name;
            CostTextBox.Text = _currentItem.Cost.ToString();
            DescriptionTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного товара.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            _currentItem = _items[ItemsListBox.SelectedIndex];

            _currentItem.Name = NameTextBox.Text;
            _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            _currentItem.Info = DescriptionTextBox.Text;
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = NameTextBox.Text;
        }

        /// <summary>
        /// Создает новый товар, добавляет его в списки и делает его активным.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            double newCost = Convert.ToDouble(CostTextBox.Text);
            Item newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, newCost);

            _items.Add(newItem);
            ItemsListBox.Items.Add(newItem.Name);

            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
            IdTextBox.Text = _items[ItemsListBox.SelectedIndex].Id.ToString();
        }

        /// <summary>
        /// Удаляет выбранный товар из списков и обновляет выделение.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;

            int selectedIndex = ItemsListBox.SelectedIndex;

            _items.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);

            if (_items.Count > 0)
            {
                ItemsListBox.SelectedIndex = selectedIndex > 0 ? selectedIndex - 1 : 0;
            }
            else
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Очищает данные о товаре из всех текстовых полей.
        /// </summary>
        private void ClearItemInfo()
        {
            _currentItem = null;
            IdTextBox.Clear();
            NameTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();
        }
    }
}
