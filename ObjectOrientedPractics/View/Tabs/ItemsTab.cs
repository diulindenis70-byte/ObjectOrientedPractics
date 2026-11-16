using System.ComponentModel;
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
        /// Возвращает и задает список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value ?? new List<Item>();
                ItemsListBox.Items.Clear();
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
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
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        /// <summary>
        /// Обновляет категорию выбранного товара при изменении значения в выпадающем списке.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == null || CategoryComboBox.SelectedItem == null) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
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
            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
            ItemsListBox.Items[ItemsListBox.SelectedIndex] = NameTextBox.Text;
        }

        /// <summary>
        /// Создает новый товар, добавляет его в списки и делает его активным.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            double newCost = double.TryParse(CostTextBox.Text, out double parsedCost) ? parsedCost : 0;
            Category selectedCategory = CategoryComboBox.SelectedItem != null
                ? (Category)CategoryComboBox.SelectedItem
                : Category.Electronics;

            Item newItem = new Item(NameTextBox.Text, DescriptionTextBox.Text, newCost, selectedCategory);

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
            CategoryComboBox.SelectedIndex = -1;
        }
    }
}
