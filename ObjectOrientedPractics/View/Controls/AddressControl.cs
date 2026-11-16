using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Представляет пользовательский элемент управления для редактирования адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                _address.Index = Convert.ToInt32(PostIndexTextBox.Text);
                _address.Country = CountryTextBox.Text;
                _address.City = CityTextBox.Text;
                _address.Street = StreetTextBox.Text;
                _address.Building = BuildingTextBox.Text;
                _address.Apartment = ApartmentTextBox.Text;

                return _address;
            }
            set
            {
                if (value == null)
                {
                    ClearAddressInfo();
                    return;
                }

                _address = value;
                UpdateAddressInfo();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет текстовые поля данными из объекта адреса.
        /// </summary>
        private void UpdateAddressInfo()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        /// <summary>
        /// Очищает все текстовые поля адреса.
        /// </summary>
        public void ClearAddressInfo()
        {
            _address = new Address();

            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;

            AddressToolTip.RemoveAll();
        }

        /// <summary>
        /// Проверяет текст введённый в строку индекса. 
        /// </summary>
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text))
            {
                PostIndexTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(PostIndexTextBox, "");
                return;
            }

            try
            {
                if (!int.TryParse(PostIndexTextBox.Text, out int index) || index < 100000 || index > 999999)
                {
                    throw new ArgumentException("Index must be a 6-digit number in range [100 000, 999 999]");
                }

                PostIndexTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(PostIndexTextBox, "");
            }
            catch (Exception ex)
            {
                PostIndexTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(PostIndexTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Проверяет текст введённый в строку страны/регион. 
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(CountryTextBox.Text, 50, nameof(Address.Country));
                CountryTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(CountryTextBox, "");
            }
            catch (Exception ex)
            {
                CountryTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(CountryTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Проверяет текст введённый в строку города. 
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(CityTextBox.Text, 50, nameof(Address.City));
                CityTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(CityTextBox, "");
            }
            catch (Exception ex)
            {
                CityTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(CityTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Проверяет текст введённый в строку улицы. 
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(StreetTextBox.Text, 100, nameof(Address.Street));
                StreetTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(StreetTextBox, "");
            }
            catch (Exception ex)
            {
                StreetTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(StreetTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Проверяет текст введённый в строку номера дома. 
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(BuildingTextBox.Text, 10, nameof(Address.Building));
                BuildingTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(BuildingTextBox, "");
            }
            catch (Exception ex)
            {
                BuildingTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(BuildingTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Проверяет текст введённый в строку номера квартиры/помещения. 
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(ApartmentTextBox.Text, 10, nameof(Address.Apartment));
                ApartmentTextBox.BackColor = Color.White;
                AddressToolTip.SetToolTip(ApartmentTextBox, "");
            }
            catch (Exception ex)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
                AddressToolTip.SetToolTip(ApartmentTextBox, ex.Message);
            }
        }

        /// <summary>
        /// Задает режим работы текстовых полей (только для чтения или редактируемые).
        /// </summary>
        /// <param name="isReadOnly">Значение true устанавливает режим "только для чтение".</param>
        public void SetReadOnly(bool isReadOnly)
        {
            PostIndexTextBox.ReadOnly = isReadOnly;
            CountryTextBox.ReadOnly = isReadOnly;
            CityTextBox.ReadOnly = isReadOnly;
            StreetTextBox.ReadOnly = isReadOnly;
            BuildingTextBox.ReadOnly = isReadOnly;
            ApartmentTextBox.ReadOnly = isReadOnly;
        }
    }
}