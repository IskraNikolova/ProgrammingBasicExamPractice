namespace SudokuResults
{
    using System;

    public class SudokuResults
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int counterOfGame = 0;
            int totalSeconds = 0;
       
            while (input != "Quit")
            {
                string[] array = input.Split(':');

                int min = int.Parse(array[0]);
                int seconds = int.Parse(array[1]);
                totalSeconds += 60 * min + seconds;
                      
                counterOfGame++;

                input = Console.ReadLine();
            }

            double resultForTitle = (double)totalSeconds / counterOfGame;
            string title = GetTitle(resultForTitle);

            Console.WriteLine(title);
            Console.WriteLine($"Games - {counterOfGame} \\ Average seconds - {Math.Ceiling(resultForTitle)}");
        }

        private static string GetTitle(double secondsAvarage)
        {
            string star = string.Empty;
            if (secondsAvarage < 720)
            {
                star = "Gold Star";
            }
            else if (secondsAvarage >= 720 && secondsAvarage <= 1440)
            {
                star = "Silver Star";
            }
            else if (secondsAvarage > 1440)
            {
                star = "Bronze Star";
            }

            return star;
        }
    }
}
