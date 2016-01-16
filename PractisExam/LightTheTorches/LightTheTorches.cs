using System.Text;

namespace LightTheTorches
{
    using System;

    public class LightTheTorches
    {
        public static void Main()
        {
            int numberOfRooms = int.Parse(Console.ReadLine());
            int currentPosition = numberOfRooms / 2;

            char[] seriesOfCharacters = Console.ReadLine().ToCharArray();
            StringBuilder result = new StringBuilder();
            while (numberOfRooms != 0)
            {
                foreach (var symbol in seriesOfCharacters)
                {
                    if (numberOfRooms > 0)
                    {
                        result.Append(symbol);
                        numberOfRooms--;
                    }
                }
            }

            char[] rooms = result.ToString().ToCharArray();
           
            string input = Console.ReadLine();       
            while (input != "END")
            {
                string[] commands = input.Split();
                int lastPosition = currentPosition;
                string direction = commands[0];
                int index = int.Parse(commands[1]) + 1;

                if (direction == "LEFT")
                {
                    currentPosition = currentPosition - index;
                }
                else if (direction == "RIGHT")
                {
                    currentPosition = currentPosition + index;
                }

                currentPosition = ValidateStartPosition(currentPosition, rooms);

                if (lastPosition == currentPosition)
                {
                    break;
                }

                char symbol = rooms[currentPosition];
                if (symbol == 'L')
                {
                    rooms[currentPosition] = 'D';
                }
                else if (symbol == 'D')
                {
                    rooms[currentPosition] = 'L';
                }

                input = Console.ReadLine();
            }

            int darkRoomsCount = 0;
            foreach (var room in rooms)
            {
                if (room == 'D')
                {
                    darkRoomsCount++;
                }
            }

            int asciiD = 68;
            int productOfDAndCountOfDarkRooms = asciiD * darkRoomsCount;

            Console.WriteLine(productOfDAndCountOfDarkRooms);
        }

        private static int ValidateStartPosition(int startPosition, char[] rooms)
        {
            if (startPosition < 0)
            {
                startPosition = 0;
            }
            else if (startPosition >= rooms.Length)
            {
                startPosition = rooms.Length - 1;
            }

            return startPosition;
        }
    }
}
