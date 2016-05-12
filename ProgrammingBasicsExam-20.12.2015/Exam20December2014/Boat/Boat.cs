using System;

namespace Boat
{
    public class Boat
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
                         
            int countOfLoop = (n/2) - 1;
            int lastCountOfAst = 0;

            string firstAndLastLine = $"{new string('.', n - 1)}*{new string('.', n)}";
            Console.WriteLine(firstAndLastLine);
            for (int i = 0, j = 3; i < countOfLoop; i++, j = j + 2)
            {
                string ast = new string('*', j);
                int nDots = n - j;
                Console.WriteLine($"{new string('.', nDots)}{ast}{new string('.', n)}");
                lastCountOfAst = j;
            }

            Console.WriteLine($"{new string('*', n)}{new string('.', n)}");
            for (int i = 0, j = lastCountOfAst; i < countOfLoop; i++, j = j - 2)
            {
                string ast = new string('*', j);
                int nDots = n - j;
                Console.WriteLine($"{new string('.', nDots)}{ast}{new string('.', n)}");
            }

            Console.WriteLine(firstAndLastLine);
            int bodyOfTheBoad = (n - 1) / 2;
            string firstRowOftheBody = new string('*', n * 2);

            Console.WriteLine(firstRowOftheBody);
            for (int i = 1; i < bodyOfTheBoad; i++)
            {
                string dots = new string('.', i);
                int lengthOfAst = (n * 2) - (dots.Length*2);
                Console.WriteLine($"{dots}{new string('*', lengthOfAst)}{dots}");
            }
        }
    }
}
