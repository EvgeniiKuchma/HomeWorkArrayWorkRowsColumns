using System;

namespace HomeWorkArrayWorkRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columnIndex = 0;
            int rowIndex = 1;
            int columnMultiplication = 1;
            int lineSum = 0;

            int[,] numberes = new int[3, 5] {
                { 3, 5, 6, 7, 8 },
                { 3, 3, 3, 3, 3 },
                { 3, 5, 6, 7, 8 }
            };

            for (int i = 0; i < numberes.GetLength(0); i++)
            {
                for (int j = 0; j < numberes.GetLength(1); j++)
                {
                    Console.Write(numberes[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < numberes.GetLength(0); i++)
            {
                columnMultiplication *= numberes[i, columnIndex];
            }

            for (int i = 0; i < numberes.GetLength(1); i++)
            {
                lineSum += numberes[rowIndex, i];
            }

            Console.WriteLine(columnMultiplication);
            Console.WriteLine(lineSum);
        }
    }
}
