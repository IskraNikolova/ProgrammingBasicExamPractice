namespace ChristmasTree
{
    using System;

    public class ChristmasTree
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int lengthOfLoop = (n + 1)/2;

            for (int i = 0; i < lengthOfLoop; i++)
            {
               
                string dots = new string('\'', n - i);
                int diffForTree = (n * 2) + 1 - dots.Length*2;
                string treeUp = new string('^', diffForTree);
                string line = dots + treeUp + dots;
                Console.WriteLine(line);
            }

            for (int i = 0; i < lengthOfLoop; i++)
            {
                string dots = new string('\'', (n - 1) - i);
                int diffForTree = (n * 2) + 1 - dots.Length * 2;
                string treeUp = new string('^', diffForTree);
                string line = dots + treeUp + dots;
                Console.WriteLine(line);
            }

            for (int i = 0; i < lengthOfLoop; i++)
            {
                string dots = new string('\'', n - 1);
                string line = dots + "| |" + dots;
                Console.WriteLine(line);
            }

            Console.WriteLine(new string('-', (n*2)+ 1));
        }
    }
}
