using System.Text;

namespace Problem4
{
    using System;

    public class Problem4
    {
        public static void Main()
        {
            int dailyExpenses = int.Parse(Console.ReadLine());

            string command = Console.ReadLine().Trim();
            decimal tottalMoney = 0;
            int counter = 0;
            while (command != "Season Over")
            {
                counter++;
                string[] commandArray = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int hours = int.Parse(commandArray[0]);
                string lettersForRoad = commandArray[1];
                decimal money = decimal.Parse(commandArray[2]);
         
                StringBuilder result = new StringBuilder();
                while (hours != 0)
                {
                    foreach (var symbol in lettersForRoad)
                    {
                        if (hours > 0)
                        {
                            result.Append(symbol);
                            hours--;
                        }
                    }
                }

                int length = result.ToString().Length;
                string roads = result.ToString();
                int countOfHerb = 0;
                for (int i = 0; i < length; i++)
                {
                    if (roads[i] == 'H')
                    {
                        countOfHerb++;
                    }
                }

                decimal finalResult = money*countOfHerb;
                tottalMoney += finalResult;

                command = Console.ReadLine();
            }

            decimal average = tottalMoney/counter;
            if (average >= dailyExpenses)
            {
                decimal diff = average - dailyExpenses;
                Console.WriteLine($"Times are good. Extra money per day: {diff:F2}.");
            }
            else if(dailyExpenses > average)
            {
                decimal diff = (dailyExpenses * counter) - tottalMoney;
                Console.WriteLine($"We are in the red. Money needed: {Math.Round(diff)}.");
            }
        }
    }
}
