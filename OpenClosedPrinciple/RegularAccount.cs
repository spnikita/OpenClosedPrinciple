namespace OpenClosedPrinciple
{
    /// <summary>
    /// Обычный аккаунт
    /// </summary>
    internal class RegularAccount : Account
    {
        /// <inheritdoc />
        public RegularAccount(AccauntType type, double balance) : base(type, balance)
        {
        }

        /// <inheritdoc />
        public override double CalculateInterest()
        {
            var interest = Balance * 0.4;

            if (Balance < 1000)
                interest -= Balance * 0.2;

            if (Balance >= 1000)
                interest -= Balance * 0.4;

            return interest;
        }
    }
}
