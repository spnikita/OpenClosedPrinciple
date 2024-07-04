namespace OpenClosedPrinciple
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    internal class SalaryAccount : Account
    {
        /// <inheritdoc />
        public SalaryAccount(AccauntType type, double balance) : base(type, balance)
        {
        }

        /// <inheritdoc />
        public override double CalculateInterest()
        {
            return Balance * 0.5;
        }
    }
}
