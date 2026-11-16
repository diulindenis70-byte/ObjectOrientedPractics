using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Представляет пользовательский элемент управления для программы.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранилище данных магазина.
        /// </summary>
        private Store _store = new();

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}