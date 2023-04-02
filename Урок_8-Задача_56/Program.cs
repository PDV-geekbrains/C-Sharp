using System;
using System.Linq;

namespace L8_E56
{
    class Program
    {
        static void Main()
        {
            PrintCaption();
            int[] arraySize = GetArraySize();
            int[,] rndItemsArray = GetRandomItemsArray(arraySize);
            int rowNumber = GetMinItemsSumRowNumber(rndItemsArray);
            PrintResult(rndItemsArray, rowNumber);
        }
        static  void PrintCaption()
        {
            Console.Clear();
            Console.WriteLine("\nНахождение строки с наименьшей суммой элементов\n");
        }
        static int[] GetArraySize()
        {
            Console.Write("Введите через пробел размер массива (M N): ");
            return Console.ReadLine()
                          .Split(" ")
                          .Select(x => int.Parse(x))
                          .ToArray();
        }
        static int[,] GetRandomItemsArray(int[] arraySize)
        {
            int[,] array = new int[arraySize[0],
                                   arraySize[1]];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = new Random().Next(10, 100);
                }
            }
            return array;
        }
        static int GetMinItemsSumRowNumber(int[,] array)
        {
            int minSum = -1;
            int rowNumber = 0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                int rowSum = 0;
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    rowSum += array[row, column];
                }
                if(minSum == -1)
                    minSum = rowSum;
                else if(minSum > rowSum)
                {
                    minSum = rowSum;
                    rowNumber = row;
                }
            }
            return rowNumber;
        }
        static void PrintResult(int[,] array, int rowNumber)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\n Номер строки с наименьшей суммой элементов: " +
                              $"{rowNumber}");
        }
    }
}