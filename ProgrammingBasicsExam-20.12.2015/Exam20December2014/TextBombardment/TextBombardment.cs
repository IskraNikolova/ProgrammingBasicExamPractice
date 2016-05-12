namespace TextBombardment
{
    using System;
    using System.Linq;
    using System.Text;

    public class TextBombardment
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int columns = int.Parse(Console.ReadLine());
            int[] columnsForBomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double rows = (double)input.Length / columns;
            int resultRow = (int)Math.Ceiling(rows);

            int tottalLength = columns * resultRow - input.Length;
            string stringForMatrix = input + new string(' ', tottalLength);

            char[,] matrix = new char[resultRow, columns];
            int index = 0;
            for (int i = 0; i < resultRow; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = stringForMatrix[index++];
                }
            }

            bool isFirst = true;

            for (int col = 0; col < columns; col++)
            {
                if (columnsForBomb.Contains(col))
                {
                    for (int row = 0; row < resultRow; row++)
                    {
                        if (matrix[row, col] != ' ')
                        {
                            matrix[row, col] = ' ';
                            isFirst = false;
                        }
                        else if(matrix[row, col] == ' ' && !isFirst)
                        {
                            break;
                        }
                    }

                    isFirst = true;
                }             
            }

            PrintResult(matrix);
        }

        private static void PrintResult(char[,] matrix)
        {
            StringBuilder output = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    output.Append(matrix[row, column]);
                }
            }

            Console.WriteLine(output);
        }
    }
}
