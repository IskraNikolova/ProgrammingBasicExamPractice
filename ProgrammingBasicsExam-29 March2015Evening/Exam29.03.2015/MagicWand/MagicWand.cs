namespace MagicWand
{
    using System;

    public class MagicWand
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = (3 * n) + 2;
            int lengthOfFirstDots = width / 2;
            string dots = new string('.', lengthOfFirstDots);
            Console.WriteLine($"{dots}*{dots}");

            int lengthOffirstLoop = (n + 1) / 2;
            for (int i = 0; i < lengthOffirstLoop; i++)
            {
                string innerDots = new string('.', 1 + (2 * i));
                string outDots = new string('.', lengthOfFirstDots - 1 - i);

                Console.WriteLine($"{outDots}*{innerDots}*{outDots}");
            }

            int innerDotsLength = width - (n*2);
            string innerDots2 = new string('.', innerDotsLength);
            string outAsterisk = new string('*', n);
            Console.WriteLine($"{outAsterisk}{innerDots2}{outAsterisk}");

            int lengthForSecondLoop = n/2;
            for (int i = 0; i < lengthForSecondLoop; i++)
            {
                string outDots = new string('.', i + 1);
                int length = (width - (outDots.Length*2) - 2);
                string innerDots = new string('.', length);
                Console.WriteLine($"{outDots}*{innerDots}*{outDots}");
            }

            int dotsLength = ((width - 6) - n - ((lengthForSecondLoop - 1) * 2))/2;
            string dots2 = new string('.', dotsLength);
            string innerDots3 = new string('.', n);
            for (int i = lengthForSecondLoop - 1, j = 0; i >= 0; i--, j++)
            {             
                string outDots = new string('.', i);
                string innerOtherDots = new string('.', j);
                Console.WriteLine($"{outDots}*{dots2}*{innerOtherDots}*{innerDots3}*{innerOtherDots}*{dots2}*{outDots}");
            }

            string innerDot = new string('.', n/2);
            int asterisk = (width - (innerDot.Length*2) - innerDots3.Length - 2)/2;
            Console.WriteLine($"{new string('*', asterisk)}{innerDot}*{innerDots3}*{innerDot}{new string('*', asterisk)}");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{innerDots3}*{innerDots3}*{innerDots3}");
            }

            Console.WriteLine($"{innerDots3}*{outAsterisk}*{innerDots3}");
        }
    }
}