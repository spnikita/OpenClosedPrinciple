namespace OpenClosedPrinciple
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    internal static class Calculator
    {
        /// <summary>
        /// Рассчитать процентную ставку
        /// </summary>
        /// <param name="account">Аккаунт</param>
        /// <returns>Процентная ставка</returns>
        public static double CalculateInterest(IAccount account)
        {
            return account.CalculateInterest();
        }
    }
}
