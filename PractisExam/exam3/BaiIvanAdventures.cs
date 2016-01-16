namespace exam3
{
    using System;

    public class BaiIvanAdventures
    {
        public static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            double money = double.Parse(Console.ReadLine());

            double litersOfAlcoWant = double.Parse(Console.ReadLine());

            double litersCanDrink = HowCanAfford(dayOfWeek, money);

            string status = string.Empty;
            if (litersCanDrink > 1.5)
            {
                status = "very drunk";
            }
            else if (litersCanDrink >= 1.0 && litersCanDrink <= 1.5)
            {
                status = "drunk";
            }
            else if (litersCanDrink < 1.0)
            {
                status = "sober";
            }

            PrintResult(litersOfAlcoWant, litersCanDrink, status);
        }

        private static void PrintResult(double litersOfAlcoWant, double litersCanDrink, string status)
        {
            if (litersOfAlcoWant > litersCanDrink)
            {
                double diff = litersOfAlcoWant - litersCanDrink;
                Console.WriteLine($"Bai Ivan is {status} and quite sad. He wanted to drink another"
                                  +
                                  $" {diff:F2} l. of alcohol");
            }
            else if (litersOfAlcoWant == litersCanDrink)
            {
                Console.WriteLine($"Bai Ivan is {status} and happy. He is as drunk as he wanted");
            }
            else if (litersCanDrink > litersOfAlcoWant)
            {
                double diff = litersCanDrink - litersOfAlcoWant;

                Console.WriteLine($"Bai Ivan is {status} and very happy and he shared {diff:F2} l. of alcohol with his friends");
            }
        }

        private static double HowCanAfford(int numberOfDay, double money)
        {
            double price = 0;

            switch (numberOfDay)
            {
                case 0:
                    price = 25.0;
                    break;
                case 1:
                    price = 21.0;
                    break;
                case 2:
                    price = 14.0;
                    break;
                case 3:
                    price = 17.0;
                    break;
                case 4:
                    price = 45.0;
                    break;
                case 5:
                    price = 59.0;
                    break;
                case 6:
                    price = 42.0;
                    break;
            }
            double litersCanDrink = money/price;
            return litersCanDrink;
        }
    }
}
