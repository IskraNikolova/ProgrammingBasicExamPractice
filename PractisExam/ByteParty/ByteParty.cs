using System;
using System.Collections.Generic;

namespace ByteParty
{
    public class ByteParty
    {
        public static void Main(string[] args)
        {
            int countOfIntegers = int.Parse(Console.ReadLine());

            List<int> integers = new List<int>();
            for (int i = 0; i < countOfIntegers; i++)
            {
                integers.Add(int.Parse(Console.ReadLine()));
            }

            string command = Console.ReadLine().Trim();
     
            while (command != "party over")
            {
                string[] commands = command.Split();
                string firstCommand = commands[0];
                int position = int.Parse(commands[1]);

                for (int i = 0; i < countOfIntegers; i++)
                {
                    switch (firstCommand)
                    {
                        case "-1":
                            integers[i] = integers[i] ^ 1 << position;
                            break;
                        case "0":
                            integers[i] = integers[i] & ~(1 << position);
                            break;
                        case "1":
                            int mask = 1 << position;
                            integers[i] |= mask;
                            break;
                    }
                }
                  
                command = Console.ReadLine().Trim();
            }

            Console.WriteLine(string.Join("\n", integers));
        }
    }
}
