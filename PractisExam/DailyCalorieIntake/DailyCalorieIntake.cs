namespace DailyCalorieIntake
{
    using System;

    public class DailyCalorieIntake
    {
        public static void Main()
        {
            const double oneInchInCm = 2.54;
            const double oneKgInLbs = 2.2;

            const double constForMan = 66.5;
            const double constForWoman = 655;

            const double dailyCalorieIntakeNoWork = 1.2;
            const double dailyCalorieIntakeOneToTree = 1.375;
            const double dailyCalorieIntakeFourToSix = 1.55;
            const double dailyCalorieIntakeSeveToNine = 1.725;
            const double dailyCalorieIntakeExtraHeavy = 1.9;


            double weightInPounds = double.Parse(Console.ReadLine());
            double convertPoundsToKg = weightInPounds / oneKgInLbs;

            double heightInInches = double.Parse(Console.ReadLine());
            double convertToCm = heightInInches * oneInchInCm;

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int workoutsPerWeek = int.Parse(Console.ReadLine());

            double bMR = 0;
            if (gender == "m")
            {
                bMR = constForMan + (13.75 * convertPoundsToKg) + (5.003 * convertToCm) - (6.755 * age);
            }
            else if (gender == "f")
            {
                bMR = constForWoman + (9.563 * convertPoundsToKg) + (1.850 * convertToCm) - (4.676 * age);
            }

            double result = 0;
      
            if (workoutsPerWeek <= 0)
            {
                result = bMR * dailyCalorieIntakeNoWork;
            }
            else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
            {
                result = bMR * dailyCalorieIntakeOneToTree;
            }
            else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
            {
                result = bMR * dailyCalorieIntakeFourToSix;
            }
            else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
            {
                result = bMR * dailyCalorieIntakeSeveToNine;
            }
            else if (workoutsPerWeek > 9)
            {
                result = bMR * dailyCalorieIntakeExtraHeavy;
            }

            Console.WriteLine(Math.Floor(result));
        }
    }
}
