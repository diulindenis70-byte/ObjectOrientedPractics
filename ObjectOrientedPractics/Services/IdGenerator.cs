namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор Id.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Id.
        /// </summary>
        private static int _id = 1;

        /// <summary>
        /// Возвращает следующий Id.
        /// </summary>
        /// <returns><see cref="_id"/>+1</returns>
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
