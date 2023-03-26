using System;

namespace L7_E47
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nЗаполнение двумерного массива N x M случайнвми " +
                "вещественными числами.\n");

            Console.Write("Введите размер массива, разделив размерности " +
                "пробелом: ");
            int[] arrayDimension = Console.ReadLine()
                .Split(" ")
                .Select(x => Int32.Parse(x))
                .ToArray();

            double[,] array = new double[arrayDimension[0], arrayDimension[1]];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    array[row, column] = new Random().NextDouble();
                }
            }

            Console.WriteLine($"\nN = {arrayDimension[0]}, M = {arrayDimension[1]}.\n");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write($"{array[row, column]} ");
                }
                Console.WriteLine();
            }
        }
    }
}