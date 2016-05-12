namespace PiggyBank
{
    using System;

    public class PiggyBank
    {
        public static void Main()
        {
            const int MonthsDay = 30;
            const int YearsMonth = 12;
            const int SavesMoneyForDay = 2;
            const int NeedsMoneyForParty = 5;

            int priceOfTheTank = int.Parse(Console.ReadLine());
            int partyDaysInAMonth = int.Parse(Console.ReadLine());

            int savesMoneyForMonth = ((MonthsDay - partyDaysInAMonth) * SavesMoneyForDay) 
                - (partyDaysInAMonth * NeedsMoneyForParty);
            double monthsAll = (double)priceOfTheTank / savesMoneyForMonth;

            int result = (int)Math.Ceiling(monthsAll);
            int years = result / YearsMonth;
            int months = result % YearsMonth;

            if (years < 0 && months < 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                Console.WriteLine($"{years} years, {months} months");
            }         
        }
    }
}
