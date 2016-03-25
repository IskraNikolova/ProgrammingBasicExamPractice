namespace Problem2
{
    using System;

    public class Problem2
    {
        public static void Main()
        {
            const int BeersInCasses = 24;
            const int BeersInPacks = 6;

            long reservedBeer = int.Parse(Console.ReadLine());

            string command = Console.ReadLine().Trim();
            long finallyBeers = 0;
            while (command != "Exam Over")
            {
                string[] commandArray = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                long number = int.Parse(commandArray[0]);
                string type = commandArray[1];
                switch (type)
                {
                    case "cases":
                        finallyBeers += number*BeersInCasses;
                        break;
                    case "beers":
                        finallyBeers += number;
                        break;
                    case "sixpacks":
                        finallyBeers += number*BeersInPacks;
                        break;
                }

                command = Console.ReadLine().Trim();
            }

            if (finallyBeers >= 100)
            {
                finallyBeers = finallyBeers - (finallyBeers/100);
            }

            if (finallyBeers >= reservedBeer)
            {
                long diff = finallyBeers - reservedBeer;
                if (diff == 0)
                {
                    Console.WriteLine($"Cheers! Beer left: 0 cases, 0 sixpacks and 0 beers.");
                }
                else
                {
                    long casses = diff / BeersInCasses;
                    long diffCasses = diff % BeersInCasses;
                    long packs = diffCasses / BeersInPacks;                
                    long diffPacks = diffCasses % BeersInPacks;
                    long beers = diffPacks;

                    Console.WriteLine($"Cheers! Beer left: {casses} cases, {packs} sixpacks and {beers} beers.");
                }
   
            }
            else if(reservedBeer > finallyBeers)
            {
                long diff = reservedBeer - finallyBeers;
                long casses = diff / BeersInCasses;
                long diffCasses = diff % BeersInCasses;
                long packs = diffCasses / BeersInPacks;
                long diffPacks = diffCasses % BeersInPacks;
                long beers = diffPacks;

                Console.WriteLine($"Not enough beer. Beer needed: {casses} cases, {packs} sixpacks and {beers} beers.");
            }
        }
    }
}
