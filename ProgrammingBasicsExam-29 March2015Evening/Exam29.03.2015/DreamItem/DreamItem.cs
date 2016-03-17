using System;

namespace DreamItem
{
    public class DreamItem
    {
        public static void Main()
        {
            const int LazyDays = 10;
            const decimal BonusCriterion = 700m;

            string[] data = Console.ReadLine().Split('\\');
            string month = data[0];
            decimal moneyPerHour = decimal.Parse(data[1]);
            int hoursPerDay = int.Parse(data[2]);
            decimal priceOfTheItem = decimal.Parse(data[3]);

            int dayOfMonth = GetCountOfDaysForMonth(month) - LazyDays;
            decimal finalMoney = (dayOfMonth * moneyPerHour) * hoursPerDay;
            if (finalMoney >= BonusCriterion)
            {
                finalMoney += finalMoney * 0.10m;
            }

            decimal rest = Math.Abs(finalMoney - priceOfTheItem);
            Console.WriteLine(finalMoney >= priceOfTheItem
                ? $"Money left = {rest:F2} leva."
                : $"Not enough money. {rest:F2} leva needed.");
        }

        private static int GetCountOfDaysForMonth(string month)
        {
            int countOfDays = 0;
            switch (month)
            {
                case "Jan":
                    countOfDays = 31;
                    break;
                case "Feb":
                    countOfDays = 28;
                    break;
                case "March":
                    countOfDays = 31;
                    break;
                case "Apr":
                    countOfDays = 30;
                    break;
                case "May":
                    countOfDays = 31;
                    break;
                case "June":
                    countOfDays = 30;
                    break;
                case "July":
                    countOfDays = 31;
                    break;
                case "Aug":
                    countOfDays = 31;
                    break;
                case "Sept":
                    countOfDays = 30;
                    break;
                case "Oct":
                    countOfDays = 31;
                    break;
                case "Nov":
                    countOfDays = 30;
                    break;
                case "Dec":
                    countOfDays = 31;
                    break;
            }

            return countOfDays;
        }
    }
}