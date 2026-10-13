using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    internal class Customer
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
        /// Адресс.
        /// </summary>
        private string _address;

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
        /// Возвращает и задает адресс пользователя.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }
        
        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Имя пользователя должно быть меньше 200 символов.</param>
        /// <param name="adress">Адресс пользователя должен быть меньше 500 символов.</param>
        public Customer(string fullname, string adress)
        {
            _fullname = fullname;
            _address = adress;
            _id = IdGenerator.GetNextId();
        }
    }
}
