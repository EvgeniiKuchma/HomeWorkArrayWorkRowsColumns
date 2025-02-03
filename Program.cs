using System;

namespace HomeWorkArrayWorkRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstColumnMultiplication  = 1;
            int secondLineAmount = 0;

            int[,] array = new int[3, 5] {
                { 3, 5, 6, 7, 8 },
                { 3, 3, 3, 3, 3 },
                { 3, 5, 6, 7, 8 }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                    if (j == 0)
                    {
                       firstColumnMultiplication *= array[i, j];
                    }
                    if (i == 1)
                    {
                        secondLineAmount += array[i, j];
                    }
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine(firstColumnMultiplication);
            Console.WriteLine(secondLineAmount);
        }
    }
}
