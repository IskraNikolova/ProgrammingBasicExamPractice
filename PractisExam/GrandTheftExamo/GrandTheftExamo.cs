namespace GrandTheftExamo
{
    using System;

    public class GrandTheftExamo
    {
        public static void Main()
        {
            int numberOfEscapeAttempts = int.Parse(Console.ReadLine().Trim());

            long thieves = 0;
            long thievesSlapped = 0;
            long thievesEscaped = 0;
          
            long beers = 0;
            for (int i = 0; i < numberOfEscapeAttempts; i++)
            {
                int amountOfThieves = int.Parse(Console.ReadLine().Trim());
                int amountOfBeer = int.Parse(Console.ReadLine().Trim());

                thieves += amountOfThieves;
                thievesSlapped += 5;
                thievesEscaped += (amountOfThieves - 5);
                beers += amountOfBeer;
            }

            long packs = beers / 6;
            long beersOutOfPacks = beers % 6;

            if (thievesSlapped > thieves)
            {
                thievesSlapped = thieves;
                thievesEscaped = 0;
            }

            Console.WriteLine($"{thievesSlapped} thieves slapped." +
                              $"\n{thievesEscaped} thieves escaped." +
                              $"\n{packs} packs, {beersOutOfPacks} bottles.");
        }
    }
}
