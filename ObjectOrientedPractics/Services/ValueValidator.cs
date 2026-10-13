namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Валидатор значений.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка строки по длине.
        /// </summary>
        /// <param name="value">принимаемя строка, должна быть меньше maxLength.</param>
        /// <param name="maxLength">максимальная длина строки.</param>
        /// <param name="propertyName">название переменной.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} chars");
            }
        }
    }
}
