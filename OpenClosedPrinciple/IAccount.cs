namespace OpenClosedPrinciple
{
    /// <summary>
    /// Определеяет метод расчета процентной ставки
    /// </summary>
    interface IAccount
    {
        /// <summary>
        /// Рассчитать процентную ставку
        /// </summary>
        /// <returns>Процентаня ставка</returns>
        double CalculateInterest();
    }
}
