using System.Text;

namespace StripedTowel
{
    using System;

    public class StripedTowel
    {
        public static void Main()
        {
            int width = int.Parse(Console.ReadLine());

            int height = (int) (width * 1.5);

            string firstSymbol = "#";
            string secondSymbols = "..";

            var result = PushStringBuilder(width, height, firstSymbol, secondSymbols);

            string resultToString = result.ToString();
            char[] resultToArray = resultToString.ToCharArray();

            PrintResult(height, width, resultToArray);
        }

        private static StringBuilder PushStringBuilder(int width, int height, string firstSymbol, string secondSymbols)
        {
            StringBuilder result = new StringBuilder();

            int lengthOfBuilder = width*height;
            for (int i = 0; i < lengthOfBuilder; i++)
            {
                if (i%2 == 0)
                {
                    result.Append(firstSymbol);
                }
                else
                {
                    result.Append(secondSymbols);
                }
            }
            return result;
        }

        private static void PrintResult(int height, int width, char[] resultToArray)
        {
            int index = 0;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(resultToArray[index]);
                    index++;
                }

                Console.WriteLine();
            }
        }
    }
}
