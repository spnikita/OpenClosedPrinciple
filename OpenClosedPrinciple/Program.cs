using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularAccaunt = new RegularAccount(AccauntType.Regular, 100);

            var interest = Calculator.CalculateInterest(regularAccaunt);

            Console.WriteLine($"Ставка базового аккаунта: {interest}");

            var salaryAccaunt = new SalaryAccount(AccauntType.Salary, 100);

            interest = Calculator.CalculateInterest(salaryAccaunt);

            Console.WriteLine($"Ставка зарплатного аккаунта: {interest}");

            Console.ReadKey();
        }
    }
}
