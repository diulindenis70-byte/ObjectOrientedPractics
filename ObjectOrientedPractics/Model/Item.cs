using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Товар.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость.
        /// </summary>
        private double _cost;

        /// <summary>
        /// 
        /// </summary>
        private bool _isBroken;

        /// <summary>
        /// Возвращает ID товара.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает имя товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));

                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает описание товара.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));

                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Cost must be in range [0, 100 000]");
                }

                _cost = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Имя товара должно быть меньше 200 символов.</param>
        /// <param name="info">Описание товара должно быть меньше 1000 символов.</param>
        /// <param name="cost">Стомиость товара должна быть в диапазоне от 0 до 100 000</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }
    }
}
