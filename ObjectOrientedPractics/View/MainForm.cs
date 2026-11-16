using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

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
        /// 
        /// </summary>
        private CartsTab _cartsTab;
        private OrdersTab _ordersTab;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2) // Вкладка Carts (третья по счету, индекс 2)
            {
                cartsTab1.RefreshData();
            }
            else if (tabControl1.SelectedIndex == 3) // Вкладка Orders (четвертая по счету, индекс 3)
            {
                ordersTab1.RefreshData();

            }
        }
    }
}
