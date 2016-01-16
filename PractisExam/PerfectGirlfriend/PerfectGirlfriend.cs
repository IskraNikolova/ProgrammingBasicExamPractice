namespace PerfectGirlfriend
{
    using System;

    public class PerfectGirlfriend
    {
        public static void Main()
        {
            string inputData = Console.ReadLine();
            int count = 0;

            while (inputData != "Enough dates!")
            {
                string[] arrayData = inputData.Split('\\');

                string dayOfWeek = arrayData[0];
                string telephoneNumber = arrayData[1];
                string sizeOfBra = arrayData[2];
                string girlName = arrayData[3];
       
                int dayOfWeekNumber = TakeNumberOfDayOfWeek(dayOfWeek);
                int numberOfTelephone = TakeNumberOfTelephoneNumber(telephoneNumber);
                int numberOfBra = TakeNumberOfBra(sizeOfBra);
                int numberOfName = TakeNumberOfName(girlName);

                int tottalPoints = dayOfWeekNumber + numberOfTelephone + numberOfBra;
                int tottalPoint = tottalPoints - numberOfName;
              
                if (tottalPoint <= 6000)
                {
                    Console.WriteLine($"Keep searching, {girlName} is not for you.");
                }
                else
                {
                    Console.WriteLine($"{girlName} is perfect for you.");
                    count++;
                }

                inputData = Console.ReadLine();
            }

            Console.WriteLine(count);
        }

        public static int TakeNumberOfDayOfWeek(string dOfWeek)
        {
            int numberOfDayOfWeek = 0;
            switch (dOfWeek)
            {
                case "Monday":
                    numberOfDayOfWeek = 1;
                    break;
                case "Tuesday":
                    numberOfDayOfWeek = 2;
                    break;
                case "Wednesday":
                    numberOfDayOfWeek = 3;
                    break;
                case "Thursday":
                    numberOfDayOfWeek = 4;
                    break;
                case "Friday":
                    numberOfDayOfWeek = 5;
                    break;
                case "Saturday":
                    numberOfDayOfWeek = 6;
                    break;
                case "Sunday":
                    numberOfDayOfWeek = 7;
                    break;
            }

            return numberOfDayOfWeek;
        }

        private static int TakeNumberOfTelephoneNumber(string telephonNumber)
        {
            int resultNumber = 0;
            char[] arrayOfDigits = telephonNumber.ToCharArray();
            int sum = 0;
            for (int i = 0; i < arrayOfDigits.Length; i++)
            {
                string symbol = arrayOfDigits[i].ToString();
                sum += int.Parse(symbol);
            }

            resultNumber = sum;

            return resultNumber;
        }

        private static int TakeNumberOfBra(string sizeOfBra)
        {
            int resultNumber = 0;
            string symbol = sizeOfBra.Substring(sizeOfBra.Length - 1, 1);
            string number = sizeOfBra.Substring(0, sizeOfBra.Length - 1);
            int numberInInt = int.Parse(number);
            int numberOfAscii = char.Parse(symbol);
        
            resultNumber = numberOfAscii*numberInInt;

            return resultNumber;
        }

        private static int TakeNumberOfName(string name)
        {
            int result = 0;

            string firstLetter = name.Substring(0, 1);
            int length = name.Length;
            int numerOfAscii = char.Parse(firstLetter);

            result = length*numerOfAscii;
            return result;
        }
    }
}
