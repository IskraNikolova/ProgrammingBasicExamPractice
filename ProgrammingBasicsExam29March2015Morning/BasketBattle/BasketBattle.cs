namespace BasketBattle
{
    using System;

    public class BasketBattle
    {
        public static void Main()
        {
            const string nakov = "Nakov";
            const string simeon = "Simeon";
            const int finalPoints = 500;

            string startingPlayer = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());

            int round = 0;
            int nakovsPoints = 0;
            int simeonsPoints = 0;
            bool isNakov = nakov == startingPlayer;
            bool isSimeon = simeon == startingPlayer;
            bool isCheck = false;
            for (int i = 0; i < rounds; i++)
            {

                if (nakovsPoints >= finalPoints)
                {
                    break;
                }
                else if (simeonsPoints >= finalPoints)
                {
                    break;
                }
                round++;
                if (isNakov && isCheck)
                {
                    isSimeon = true;
                    isNakov = false;
                }
                else if(isSimeon && isCheck)
                {
                    isSimeon = false;
                    isNakov = true;
                }
           
                for (int j = 0; j < 2; j++)
                {
                    if (nakovsPoints >= finalPoints)
                    {
                        break;
                    }
                    else if (simeonsPoints >= finalPoints)
                    {
                        break;
                    }
                    isCheck = true;
                    int points = int.Parse(Console.ReadLine());
                    string result = Console.ReadLine();

                    if (isNakov)
                    {
                        if (result == "success")
                        {
                            nakovsPoints += points;
                            if (nakovsPoints > 500)
                            {
                                nakovsPoints -= points;
                            }
                        }

                        isNakov = false;
                        isSimeon = true;

                    }
                    else if (isSimeon)
                    {
                        if (result == "success")
                        {
                            simeonsPoints += points;
                            if (simeonsPoints > 500)
                            {
                                simeonsPoints -= points;
                            }
                        }

                        isSimeon = false;
                        isNakov = true;
                    }
                }
            }

            if (simeonsPoints >= finalPoints || nakovsPoints >= finalPoints)
            {
                Console.WriteLine("{0}", simeonsPoints > nakovsPoints ? "Simeon" : "Nakov");
                Console.WriteLine(round);
                Console.WriteLine("{0}", simeonsPoints > nakovsPoints ? nakovsPoints : simeonsPoints);
            }
            else if (simeonsPoints < finalPoints && nakovsPoints < finalPoints && simeonsPoints == nakovsPoints)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(simeonsPoints);
            }
            else
            {
                Console.WriteLine("{0}", nakovsPoints > simeonsPoints ? nakov : simeon);
                int winnerPoint = nakovsPoints > simeonsPoints
                    ? nakovsPoints - simeonsPoints
                    : simeonsPoints - nakovsPoints;
                Console.WriteLine("{0}", winnerPoint);
            }
        }
    }
}
