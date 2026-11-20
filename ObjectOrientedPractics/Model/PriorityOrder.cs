using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Допустимые диапазоны времени доставки.
        /// </summary>
        public static readonly string[] DeliveryTimeRanges =
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает и задает желаемую дату доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задает желаемое время доставки из допустимых диапазонов.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set
            {
                if (!DeliveryTimeRanges.Contains(value))
                {
                    throw new ArgumentException("Указан недопустимый диапазон времени доставки.");
                }
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/> без параметров.
        /// </summary>
        public PriorityOrder() : base()
        {
            DeliveryDate = DateTime.Now.Date.AddDays(1);
            DeliveryTime = DeliveryTimeRanges[0];
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/> со всеми параметрами.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список купленных товаров.</param>
        /// <param name="deliveryDate">Желаемая дата доставки.</param>
        /// <param name="deliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, DateTime deliveryDate, string deliveryTime)
            : base(address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
