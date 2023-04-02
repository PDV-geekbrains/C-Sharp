using System;
using System.Linq;

namespace L8_E54
{
    class Program
    {
        static void Main()
        {
            PrintCaption();
            int[] arraySize = GetArraySize();
            int[,] array = GetRandomItemsArray(arraySize);
            int[,] newArray = NormalizeArray(array);
            PrintResult(array, newArray);
        }
        static void PrintCaption()
        {
            Console.Clear();
            Console.WriteLine("Упорядочивание по убыванию элементов " +
                "каждой строки двумерного массива.\n");
        }
        static int[] GetArraySize()
        {
            Console.Write("Введите размер массива через пробел (N M): ");
            return Console.ReadLine()
                          .Split(" ")
                          .Select(x => int.Parse(x))
                          .ToArray();
        }
        static int[,] GetRandomItemsArray(int[] arraySize)
        {
            int[,] array = new int[arraySize[0], arraySize[1]];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = new Random().Next(10, 100);
                }
            }
            //
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]} ");
                }
                Console.WriteLine();
            }
            //
            return array;
        }
        static int[,] NormalizeArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    int minItem = array[row, column];
                    int minItemIndex = column;
                    for (int index = column; index < array.GetLength(1); index++)
                    {
                        if(minItem > array[row, index])
                        {
                            minItem = array[row, index];
                            minItemIndex = index;
                        }
                    }
                    array[row, minItemIndex] = array[row, column];
                    array[row, column] = minItem;
                    //System.Console.WriteLine($"minItem = {minItem}, minItemIndex = {minItemIndex}");
                }
            }
            return array;
        }
        static void PrintResult(int[,] array, int[,] newArray)
        {
            /*for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]} ");
                }
                Console.WriteLine();
            }*/
            Console.WriteLine("\nМассив с упорядоченными элементами:\n");
            for (int row = 0; row < newArray.GetLength(0); row++)
            {
                for (int column = 0; column < newArray.GetLength(1); column++)
                {
                    Console.Write($"{newArray[row, column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}