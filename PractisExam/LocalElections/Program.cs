using System.Globalization;

namespace LocalElections
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int countOfCandidateList = int.Parse(Console.ReadLine());
            int voteOfTheElector = int.Parse(Console.ReadLine());
            string votingSymbol = Console.ReadLine();

            string emptyLine = new string('.', 13);
            string firstAndLastLine = $"...+-----+...";
            for (int i = 0; i < countOfCandidateList; i++)
            {
                Console.WriteLine(emptyLine);
                Console.WriteLine(firstAndLastLine);
                string countOfBuletin = i < 9 ? $"0{i + 1}." : $"{i + 1}.";
                if (i + 1 == voteOfTheElector)
                {
                   
                    if (votingSymbol == "x" || votingSymbol == "X")
                    {
                        Console.WriteLine($"...|.\\./.|...");
                        Console.WriteLine($"{countOfBuletin}|..X..|...");
                        Console.WriteLine($"...|./.\\.|...");
                    }
                    else
                    {
                        Console.WriteLine($"...|\\.../|...");
                        Console.WriteLine($"{countOfBuletin}|.\\./.|...");
                        Console.WriteLine($"...|..V..|...");
                    }                  
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (j != 1)
                        {
                            Console.WriteLine($"...|.....|...");
                        }
                        else
                        {
                            Console.WriteLine($"{countOfBuletin}|.....|...");
                        }
                    }
                }

                Console.WriteLine(firstAndLastLine);
            }

            Console.WriteLine(emptyLine);
        }
    }
}
