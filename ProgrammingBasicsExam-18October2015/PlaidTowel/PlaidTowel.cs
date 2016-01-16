namespace PlaidTowel
{
    using System;

    public class PlaidTowel
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char backgroundSymbol = char.Parse(Console.ReadLine());
            char rhombusSymbol = char.Parse(Console.ReadLine());

            int finalSize = (size * 4) + 1;
            string firstLineOut = new string(backgroundSymbol, size);

            int inSideBackgroundCount = finalSize - (firstLineOut.Length * 2) - 2;
            string middleFirstLine = new string(backgroundSymbol, inSideBackgroundCount);

            string firstLine = $"{firstLineOut}{rhombusSymbol}{middleFirstLine}{rhombusSymbol}{firstLineOut}";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(firstLine);
                for (int j = 0; j < size - 1; j++)
                {
                    int countOfOutBackground = size - j - 1;
                    string outBackground = new string(backgroundSymbol, countOfOutBackground);

                    int countOfMidlleBackGround = (j * 2) + 1;
                    string firstMiddlleBackround = new string(backgroundSymbol, countOfMidlleBackGround);

                    int centerCountOfBackground = finalSize - (countOfOutBackground * 2) - 4 - (countOfMidlleBackGround * 2);
                    string centerBackground = new string(backgroundSymbol, centerCountOfBackground);

                    string lineForPrint = $"{outBackground}{rhombusSymbol}{firstMiddlleBackround}{rhombusSymbol}{centerBackground}" +
                                          $"{rhombusSymbol}{firstMiddlleBackround}{rhombusSymbol}{outBackground}";
                    Console.WriteLine(lineForPrint);
                }

                int midlleBackground = (size * 2) - 1;
                string midBackground = new string(backgroundSymbol, midlleBackground);
                string lineForPrintMiddle = $"{rhombusSymbol}{midBackground}{rhombusSymbol}{midBackground}{rhombusSymbol}";
                Console.WriteLine(lineForPrintMiddle);

                for (int j = 0; j < size - 1; j++)
                {
                    string outBackground = new string(backgroundSymbol, j + 1);

                    int midlleBack = ((size * 2) - 1) - 2 - (j * 2);
                    string backgroundOutMiddle = new string(backgroundSymbol, midlleBack);

                    int countOfCenter = finalSize - (outBackground.Length * 2) - 4 - (midlleBack * 2);
                    string centerBackground = new string(backgroundSymbol, countOfCenter);

                    string forPrint = $"{outBackground}{rhombusSymbol}{backgroundOutMiddle}{rhombusSymbol}{centerBackground}" +
                                      $"{rhombusSymbol}{backgroundOutMiddle}{rhombusSymbol}{outBackground}";

                    Console.WriteLine(forPrint);
                }
            }
            Console.WriteLine(firstLine);
        }
    }
}