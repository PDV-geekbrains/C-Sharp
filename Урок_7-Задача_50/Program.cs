using System;

namespace L7_E50
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("\nВывод зачения элемента двумерного массива\n");

            int[,] array = new int[5, 5];
            PopulateArray(ref array);
            Print(array);

            Console.Write("\nВведите через пробел номер строки и стобца: ");
            int[] coordinats = Console.ReadLine()
                .Split(" ")
                .Select(x => Int32.Parse(x))
                .ToArray();
            
            if(IsCoordinatesValid(coordinats))
                PrintElementValue(array, coordinats);
        }

        static void PrintElementValue(int[,] array, int[] coordinats)
        {
            Console.WriteLine($"\n({coordinats[0]}, " +
                    $"{coordinats[1]}) -> {array[coordinats[0], coordinats[1]]}");
        }

        static bool IsCoordinatesValid(int[] coordinats)
        {
            bool result = false;
            if(coordinats[0] < 5 && coordinats[1] < 5)
                result = true;
            else
                Console.WriteLine($"\n({coordinats[0]}, " +
                    $"{coordinats[1]}) -> Такого элемента нет.");
            return result;
        }

        static void Print(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]}\t");
                }
                Console.WriteLine();
            }
        }

        static int[,] PopulateArray(ref int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = new Random().Next(0, 100);
                }
            }
            return array;
        }
    }
}