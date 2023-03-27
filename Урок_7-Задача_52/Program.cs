using System;
using System.Linq;

namespace L7_E52
{
    class Program
    {
        static void Main()
        {
            PrintCaption();
            int[] matrixSize = GetMatrixSize();
            int[,] matrix = GetMatrix(matrixSize);
            int[] arithmeticMeanForEachColumn = GetArithmeticMean(matrix);
            PrintResult(matrix, arithmeticMeanForEachColumn);
        }

        static void PrintCaption()
        {
            Console.Clear();
            Console.WriteLine("Вычисление среднего арифметического " +
            "элементов каждого столбца матрицы.\n");
        }
        static int[] GetMatrixSize()
        {
            Console.Write("Введите через пробел размер матрицы: ");
            return Console.ReadLine()
                    .Split(" ")
                    .Select(x => Int32.Parse(x))
                    .ToArray();
        }
        static int[,] GetMatrix(int[] matrixSize)
        {
            int[,] randomIntagers = new int[matrixSize[0], matrixSize[1]];
            for (int row = 0; row < randomIntagers.GetLength(0); row++)
            {
                for (int column = 0; column < randomIntagers.GetLength(1); column++)
                {
                    randomIntagers[row, column] = new Random().Next(10, 100);
                }
            }
            return randomIntagers;
        }
        static int[] GetArithmeticMean(int[,] matrix)
        {
            int[] result = new int[matrix.GetLength(1)];
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, column];
                }
                result[column] = sum;
            }
            return result;
        }
        static void PrintResult(int[,] matrix, int[] arithmeticMean)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Среднее арифметическое каждого столбца: " +
                $"{string.Join(", ", arithmeticMean)}");
        }
    }
}