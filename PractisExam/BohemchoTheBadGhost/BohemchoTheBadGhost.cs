using System.Linq;

namespace BohemchoTheBadGhost
{
    using System;

    public class BohemchoTheBadGhost
    {
        public static void Main()
        {
            int leftLights = 0;
            long score = 0;
            string input = Console.ReadLine();
            while (input != "Stop, God damn it")
            { 
                uint floor = uint.Parse(input);

                int[] apartments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < apartments.Length; i++)
                {
                    int position = apartments[i];
                    uint mask = 1U << position;
                    floor = floor ^ mask;
                }

                for (int i = 0; i < 32; i++)
                {
                    long nRight = floor >> i;
                    long bit = nRight & 1;

                    if (bit == 1)
                    {
                        leftLights++;
                    }
                }

                score += floor;

                input = Console.ReadLine();
            }
       
            Console.WriteLine($"Bohemcho left {leftLights} lights on and his score is {score}");
        }
    }
}
