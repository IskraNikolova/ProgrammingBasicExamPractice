namespace CurrencyCheck
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CurrencyCheck
    {
        public static void Main()
        {
            List<double> data = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                data.Add(double.Parse(Console.ReadLine()));
            }

            data[0] = (data[0]/100)*3.5;
            data[1] = data[1] * 1.5;
            data[2] = data[2] * 1.95;
            data[3] = data[3]/2;

            double minNumber = data.Min();
            Console.WriteLine($"{minNumber:F2}");
        }
    }
}