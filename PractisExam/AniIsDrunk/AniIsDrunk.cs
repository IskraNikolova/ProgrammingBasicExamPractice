namespace AniIsDrunk
{
    using System;

    public class AniIsDrunk
    {
        public static void Main()
        {
            int numberOfCabins = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int currentPosition = 0;
            long totalLengthCovered = 0;

            while (input != "Found a free one!")
            {
                int steps = int.Parse(input);
                int oldPosition = currentPosition;
                currentPosition = (currentPosition + steps) % numberOfCabins;

                int diff = currentPosition - oldPosition;
                totalLengthCovered += Math.Abs(diff);
                if (diff > 0)
                {
                    Console.WriteLine($"Go {diff} steps to the right, Ani.");
                }
                else if (diff < 0)
                {
                    Console.WriteLine($"Go {Math.Abs(diff)} steps to the left, Ani.");
                }
                else
                {
                    Console.WriteLine("Stay there, Ani.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Moved a total of {totalLengthCovered} steps.");
        }
    }
}
