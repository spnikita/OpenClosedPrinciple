namespace OpenClosedPrinciple
{
    /// <summary>
    /// Аккаунт
    /// </summary>
    internal abstract class Account : IAccount
    {
        /// <summary>
        /// Тип учетной записи
        /// </summary>
        public AccauntType Type { get; set; }

        /// <summary>
        /// Баланс учетной записи
        /// </summary>
        public double Balance { get; }

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="type"><inheritdoc cref="Type" path="/summary"/></param>
        /// <param name="balance"><inheritdoc cref="Balance" path="/summary"/></param>      
        protected Account(AccauntType type, double balance)
        {
            Type = type;
            Balance = balance;
        }

        /// <inheritdoc />
        public abstract double CalculateInterest();
    }
}
