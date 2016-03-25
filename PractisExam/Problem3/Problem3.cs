using System;

namespace Problem3
{
    public class Problem3
    {
        public static void Main()
        {
            const char Dot = '.';
            const char Sign = '#';

            int N = int.Parse(Console.ReadLine());
            string firstAndLastLine = new string(Dot, N) + new string(Sign, N) + new string(Dot, N);
            Console.WriteLine(firstAndLastLine);

            /////
            int length = N/2;
            string middleDots = new string(Dot, N - 2);
            for (int i = 0, j = 0; i < length; i++, j = j + 2)
            { 
                string outMiddleDots = new string(Dot, j);
                int outDots = ((((N * 3) - 6) - (N - 2))  - outMiddleDots.Length * 2)/2;
                string outDotsStr = new string(Dot, outDots);
                string line = $"{outDotsStr}##{outMiddleDots}#{middleDots}#{outMiddleDots}##{outDotsStr}";
                Console.WriteLine(line);
            }

            for (int i = 0, j = 1; i < length; i++, j = j + 2)
            {
                string outDots = new string(Dot, j);
                int outMiddleDotsSize = (((N*3) - (outDots.Length*2) - middleDots.Length) - 6)/2;
                string dotsInM = new string(Dot, outMiddleDotsSize);
                string line = $"{outDots}##{dotsInM}#{middleDots}#{dotsInM}##{outDots}";
                Console.WriteLine(line);
            }

            Console.WriteLine(firstAndLastLine);
        }
    }
}
