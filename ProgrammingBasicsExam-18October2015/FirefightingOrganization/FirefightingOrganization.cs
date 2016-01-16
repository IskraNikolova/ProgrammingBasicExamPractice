namespace FirefightingOrganization
{
    using System;

    public class FirefightingOrganization
    {
        public static void Main()
        {
            int numberOfFirefighters = int.Parse(Console.ReadLine());

            string amountOfLetters = Console.ReadLine();

            int kids = 0;
            int adults = 0;
            int seniors = 0;
            while (amountOfLetters != "rain")
            {
                char[] people = amountOfLetters.ToCharArray();
                int firefighters = numberOfFirefighters;
                for (int j = 0; j < numberOfFirefighters; j++)
                {
                    for (int i = 0; i < people.Length; i++)
                    {
                        if (people[i] == 'K' && firefighters > 0)
                        {
                            kids++;
                            people[i] = 'N';
                            firefighters--;
                        }
                    }

                    for (int i = 0; i < people.Length; i++)
                    {
                        if (people[i] == 'A' && firefighters > 0)
                        {
                            adults++;
                            people[i] = 'N';
                            firefighters--;
                        }
                    }

                    for (int i = 0; i < people.Length; i++)
                    {
                        if (people[i] == 'S' && firefighters > 0)
                        {
                            seniors++;
                            people[i] = 'N';
                            firefighters--;
                        }
                    }
                }

                amountOfLetters = Console.ReadLine();
            }

            Console.WriteLine($"Kids: {kids}\nAdults: {adults}\nSeniors: {seniors}");
        }
    }
}

