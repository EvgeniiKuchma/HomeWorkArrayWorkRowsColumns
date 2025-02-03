using System;

namespace HomeWorkArrayWorkRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columnNumber = 0;
            int rowNumber = 1;
            int columnMultiplication = 1;
            int lineAmount = 0;

            int[,] numberesMatrixArray = new int[3, 5] {
                { 3, 5, 6, 7, 8 },
                { 3, 3, 3, 3, 3 },
                { 3, 5, 6, 7, 8 }
            };

            for (int i = 0; i < numberesMatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberesMatrixArray.GetLength(1); j++)
                {
                    Console.Write(numberesMatrixArray[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < numberesMatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberesMatrixArray.GetLength(1); j++)
                {
                    if (j == columnNumber)
                    {
                        columnMultiplication *= numberesMatrixArray[i, j];
                    }
                }
            }
            for (int i = 0; i < numberesMatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < numberesMatrixArray.GetLength(1); j++)
                {
                    if (i == rowNumber)
                    {
                        lineAmount += numberesMatrixArray[i, j];
                    }
                }
            }
            Console.WriteLine(columnMultiplication);
            Console.WriteLine(lineAmount);
        }
    }
}
