namespace TheFootballSatistician
{
    using System;

    public class TheFootballSatistician
    {
        public static void Main()
        {
            const double euroToLv = 1.94;

            double paymentForEveryMatch = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int countOfMatch = 0;
            int chelseaPoints = 0;
            int arsenalPoints = 0;
            int evertonPoints = 0;
            int liverpoolPoints = 0;
            int manchesterCityPoints = 0;
            int manchesterUnitedPoints = 0;
            int southamptonPoints = 0;
            int tottenhamPoints = 0;

            while (input != "End of the league.")
            {
                countOfMatch++;
                string[] info = input.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < info.Length; i++)
                {
                    if (i == 0)
                    {
                        switch (info[i])
                        {
                            case "Arsenal":
                                AddPointsForTeam1(info[1], ref arsenalPoints);
                                break;
                            case "Chelsea":
                                AddPointsForTeam1(info[1], ref chelseaPoints);
                                break;
                            case "Everton":
                                AddPointsForTeam1(info[1], ref evertonPoints);
                                break;
                            case "Liverpool":
                                AddPointsForTeam1(info[1], ref liverpoolPoints);
                                break;
                            case "ManchesterCity":
                                AddPointsForTeam1(info[1], ref manchesterCityPoints);
                                break;
                            case "ManchesterUnited":
                                AddPointsForTeam1(info[1], ref manchesterUnitedPoints);
                                break;
                            case "Southampton":
                                AddPointsForTeam1(info[1], ref southamptonPoints);
                                break;
                            case "Tottenham":
                                AddPointsForTeam1(info[1], ref tottenhamPoints);
                                break;
                        }
                    }

                    if (i == 2)
                    {
                        switch (info[i])
                        {
                            case "Arsenal":
                                AddPointsForTeam2(info[1], ref arsenalPoints);
                                break;
                            case "Chelsea":
                                AddPointsForTeam2(info[1], ref chelseaPoints);
                                break;
                            case "Everton":
                                AddPointsForTeam2(info[1], ref evertonPoints);
                                break;
                            case "Liverpool":
                                AddPointsForTeam2(info[1], ref liverpoolPoints);
                                break;
                            case "ManchesterCity":
                                AddPointsForTeam2(info[1], ref manchesterCityPoints);
                                break;
                            case "ManchesterUnited":
                                AddPointsForTeam2(info[1], ref manchesterUnitedPoints);
                                break;
                            case "Southampton":
                                AddPointsForTeam2(info[1], ref southamptonPoints);
                                break;
                            case "Tottenham":
                                AddPointsForTeam2(info[1], ref tottenhamPoints);
                                break;
                        }
                    }
                }
               
                input = Console.ReadLine();
            }

            double resultOfLv = (paymentForEveryMatch * euroToLv) * countOfMatch;
            Console.WriteLine($"{resultOfLv:F2}lv.");

            Console.WriteLine($"Arsenal - {arsenalPoints} points.");
            Console.WriteLine($"Chelsea - {chelseaPoints} points.");
            Console.WriteLine($"Everton - {evertonPoints} points.");
            Console.WriteLine($"Liverpool - {liverpoolPoints} points.");
            Console.WriteLine($"Manchester City - {manchesterCityPoints} points.");
            Console.WriteLine($"Manchester United - {manchesterUnitedPoints} points.");
            Console.WriteLine($"Southampton - {southamptonPoints} points.");
            Console.WriteLine($"Tottenham - {tottenhamPoints} points.");
        }

        private static void AddPointsForTeam1(string outcome, ref int points)
        {
            if (outcome == "1")
            {
                points += 3;
            }
            else if(outcome == "X")
            {
                points++;
            }
        }

        private static void AddPointsForTeam2(string outcome, ref int points)
        {
            if (outcome == "2")
            {
                points += 3;
            }
            else if (outcome == "X")
            {
                points++;
            }
        }
    }
}
