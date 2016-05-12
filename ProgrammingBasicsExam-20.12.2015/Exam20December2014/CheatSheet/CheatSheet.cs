namespace CheatSheet
{
    using System;

    public class CheatSheet
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            
            long startVerticalNumber = int.Parse(Console.ReadLine());
            long startHiorizontaNumber = int.Parse(Console.ReadLine());
            long oldStartHorizontalNumber = startHiorizontaNumber;

            long[,] matrix = new long[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = startVerticalNumber * startHiorizontaNumber;
                    Console.Write(matrix[row, column] + " ");
                    startHiorizontaNumber++;
                }

                startHiorizontaNumber = oldStartHorizontalNumber;
                Console.WriteLine();
                startVerticalNumber++;
            }
        }
    }
}
