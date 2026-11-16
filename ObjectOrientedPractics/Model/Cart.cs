using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине товаров покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Возвращает общую стоимость товаров в корзине.
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
    }
}
