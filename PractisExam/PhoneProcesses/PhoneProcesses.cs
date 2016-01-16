namespace PhoneProcesses
{
    using System;

    public class PhoneProcesses
    {
        public static void Main()
        {
            string batteryPercentage = Console.ReadLine().Trim();
            int batPercentage = int.Parse(batteryPercentage.Substring(0, batteryPercentage.Length - 1));

            string input = Console.ReadLine().ToLower().Trim();
            int count = 0;
            bool isPrint = false;
            while (input != "end")
            {
                string[] inputArr = input.Split('_');
                string nextPercentage = inputArr[1];
                int intPercentage = int.Parse(nextPercentage.Substring(0, nextPercentage.Length - 1));
                if (!isPrint && batPercentage > 15)
                {
                    batPercentage = batPercentage - intPercentage;
                }
                else
                {
                    count++;
                }
               
                if (batPercentage <= 15 && batPercentage > 0 && !isPrint)
                {                  
                    Console.WriteLine($"Connect charger -> {batPercentage}%");
                    isPrint = true;                              
                }

                input = Console.ReadLine().ToLower().Trim();
            }
            if (batPercentage > 15)
            {
                Console.WriteLine($"Successful complete -> {batPercentage}%");
            }
            else if(batPercentage <= 15 && batPercentage > 0)
            {
                Console.WriteLine($"Programs left -> {count}");
            }
            else
            {
                Console.WriteLine("Phone Off");
            }           
        }
    }
}
