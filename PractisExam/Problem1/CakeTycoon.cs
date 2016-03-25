namespace Problem1
{
    using System;

    public class CakeTycoon
    {
        public static void Main()
        {
            const decimal IncreasedPriceProcent = 1.25m;

            ulong numberOfCakesIvWants = ulong.Parse(Console.ReadLine());
            decimal kilogramOfFlourNeeds = decimal.Parse(Console.ReadLine());
            uint kilogramOfFloorAvailable = uint.Parse(Console.ReadLine());
            uint amountOfTrufflesAvailable = uint.Parse(Console.ReadLine());
            uint priceonTheTruffles = uint.Parse(Console.ReadLine());

            decimal cakes = (kilogramOfFloorAvailable / kilogramOfFlourNeeds);

            if (cakes >= numberOfCakesIvWants)
            {
                decimal trufflesCost = (decimal)amountOfTrufflesAvailable * priceonTheTruffles;
                decimal cakePrice = (trufflesCost / numberOfCakesIvWants) * IncreasedPriceProcent;
                Console.WriteLine($"All products available, price of a cake: {cakePrice:F2}");
            }

            if (cakes < numberOfCakesIvWants)
            {
                decimal roundKilograms = Math.Floor(cakes);
                decimal totalFloor = numberOfCakesIvWants * kilogramOfFlourNeeds;
                decimal kgNeeded = totalFloor - kilogramOfFloorAvailable;
                Console.WriteLine($"Can make only {roundKilograms} cakes, need {kgNeeded:F2} kg more flour");
            }
        }
    }
}
