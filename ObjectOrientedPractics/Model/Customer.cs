using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает ID пользователя.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает полное имя пользователя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес пользователя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину пользователя.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов пользователя.
        /// </summary>
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            _address = new Address();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Имя пользователя должно быть меньше 200 символов.</param>
        /// <param name="address">Адрес доставки пользователя.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
