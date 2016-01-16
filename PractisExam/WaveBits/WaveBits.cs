using System.Text.RegularExpressions;

namespace WaveBits
{
    using System;

    public class WaveBits
    {
        public static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            string numberInString = Convert.ToString((long) number, 2);
            string pattern = @"((10){1,}1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(numberInString);

            int maxCount = 0;
            int index = 0;
            int length = 0;
            string substring = string.Empty;
            bool isWave = false;
            foreach (Match match in matches)
            {
                isWave = match.Success;
                length = match.Groups[1].Length;             
                if (maxCount < length)
                {
                    maxCount = length;
                    index = match.Groups[1].Index;
                    substring = match.Groups[1].ToString();
                }
            }

            if (isWave)
            {
                string result = numberInString.Remove(index, substring.Length);
                if (result.Length > 1)
                {
                    ulong resultInNum = Convert.ToUInt64(result, 2);
                    Console.WriteLine(resultInNum);
                }
                else
                {
                    Console.WriteLine(0);
                }
           
            }
            else
            {
                Console.WriteLine("No waves found!");
            }
        }
    }
}
