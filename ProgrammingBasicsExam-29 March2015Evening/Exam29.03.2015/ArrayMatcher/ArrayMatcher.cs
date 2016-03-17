using System.Linq;
using System.Text;

namespace ArrayMatcher
{
    using System;

    public class ArrayMatcher
    {
        public static void Main()
        {
            string[] data = Console.ReadLine().Split('\\');
            string firstArray = data[0];
            string secondArray = data[1];
            string command = data[2];
            string output = string.Empty;

            switch (command)
            {
                case "join":
                    output = TakeElementsOfBothArray(firstArray, secondArray);
                    Console.WriteLine(string.Join("", output.OrderBy(c => c)));
                    break;
                case "right exclude":
                    output = TakeElementsOfFirstThatSecondNotContains(firstArray, secondArray);
                    Console.WriteLine(string.Join("", output.OrderBy(c => c)));
                    break;
                case "left exclude":
                    output = TakeElementsOfSecondThatFirstNotContains(firstArray, secondArray);
                    Console.WriteLine(string.Join("", output.OrderBy(c => c)));
                    break;
            }
        }

        private static string TakeElementsOfSecondThatFirstNotContains(string firstArray, string secondArray)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (!firstArray.Contains(secondArray[i].ToString()))
                {
                    builder.Append(secondArray[i]);
                }
            }

            return builder.ToString();
        }

        private static string TakeElementsOfBothArray(string firstArray, string secondArray)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (secondArray.Contains(firstArray[i].ToString()))
                {
                    builder.Append(firstArray[i]);
                }
            }

            return builder.ToString();
        }

        private static string TakeElementsOfFirstThatSecondNotContains(string firstArray, string secondArray)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (!secondArray.Contains(firstArray[i].ToString()))
                {
                    builder.Append(firstArray[i]);
                }
            }

            return builder.ToString();
        }

    }
}