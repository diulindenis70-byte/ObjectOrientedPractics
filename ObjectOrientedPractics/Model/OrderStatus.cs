namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Перечисление статусов заказа.
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Заказ обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен покупателю.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат заказа.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ отменен магазином.
        /// </summary>
        Abandoned
    }
}
