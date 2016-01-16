using System.Text;

namespace ShuffleBits
{
    using System;

    public class ShuffleBits
    {
        public static void Main()
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            string firstNumberBinary = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
         
            string secondNumberBinary = Convert.ToString(secondNumber, 2).PadLeft(32, '0');
           

            if (firstNumber >= secondNumber)
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < 32; i++)
                {
                    result.Append(firstNumberBinary[i]);               
                    result.Append(secondNumberBinary[i]);                     
                }

                string stringResult = result.ToString();
               
                long res = Convert.ToInt64(stringResult, 2);
                Console.WriteLine(res);
            }
            else
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < 32 - 1; i = i+ 2)
                {
                    result.Append(firstNumberBinary[i]);
                    result.Append(firstNumberBinary[i + 1]);
                  
                    result.Append(secondNumberBinary[i]);
                    result.Append(secondNumberBinary[i + 1]);                  
                }

                string stringResult = result.ToString();
             
                long res = Convert.ToInt64(stringResult, 2);
                Console.WriteLine(res);
            }
        }
    }
}
