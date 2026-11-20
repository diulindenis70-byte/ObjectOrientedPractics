using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет пользовательский элемент управления для вкладки покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Внутренняя коллекция покупателей.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value ?? new List<Customer>();
                CustomersListBox.Items.Clear();
                foreach (var customer in _customers)
                {
                    CustomersListBox.Items.Add(customer.Fullname);
                }
                ClearCustomerInfo();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет текстовые поля покупателя при выборе другого покупателя в списке.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];

            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            CustomerAddressControl.Address = _currentCustomer.Address;
        }

        /// <summary>
        /// Обновляет свойство приоритетности выбранного покупателя при изменении флажка.
        /// </summary>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;

            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        /// <summary>
        /// Обновляет поля выбранного покупателя.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            _currentCustomer = _customers[CustomersListBox.SelectedIndex];

            _currentCustomer.Fullname = FullNameTextBox.Text;
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
            _currentCustomer.Address = CustomerAddressControl.Address;

            CustomersListBox.Items[CustomersListBox.SelectedIndex] = _currentCustomer.Fullname;
        }

        /// <summary>
        /// Создает нового покупателя, добавляет его в списки и делает его активным.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Address currentInputAddress = CustomerAddressControl.Address;
            Address newAddress = new Address(
                currentInputAddress.Index,
                currentInputAddress.Country,
                currentInputAddress.City,
                currentInputAddress.Street,
                currentInputAddress.Building,
                currentInputAddress.Apartment);

            Customer newCustomer = new Customer(FullNameTextBox.Text, newAddress)
            {
                IsPriority = IsPriorityCheckBox.Checked
            };

            _customers.Add(newCustomer);
            CustomersListBox.Items.Add(newCustomer.Fullname);

            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
            IdTextBox.Text = _customers[CustomersListBox.SelectedIndex].Id.ToString();
        }

        /// <summary>
        /// Удаляет выбранного покупателя из списков и обновляет выделение.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;

            int selectedIndex = CustomersListBox.SelectedIndex;

            _customers.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);

            if (_customers.Count > 0)
            {
                CustomersListBox.SelectedIndex = selectedIndex > 0 ? selectedIndex - 1 : 0;
            }
            else
            {
                ClearCustomerInfo();
            }
        }

        /// <summary>
        /// Очищает данные о покупателе из всех текстовых полей.
        /// </summary>
        private void ClearCustomerInfo()
        {
            _currentCustomer = null;
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            IsPriorityCheckBox.Checked = false;
            CustomerAddressControl.ClearAddressInfo();
        }
    }
}