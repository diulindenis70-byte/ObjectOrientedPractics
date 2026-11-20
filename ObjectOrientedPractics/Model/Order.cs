using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// Список товаров заказа.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает дату и время создания заказа.
        /// </summary>
        public DateTime Date => _date;

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров заказа.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Возвращает общую стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                double sum = 0.0;
                foreach (var item in _items)
                {
                    if (item != null)
                    {
                        sum += item.Cost;
                    }
                }
                return sum;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/> без параметров.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список купленных товаров.</param>
        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items != null ? new List<Item>(items) : new List<Item>();
            Status = OrderStatus.New;
        }
    }
}
