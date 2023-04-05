using System;

namespace L9_E64
{
    class Program
    {
        static void Main()
        {
            PrintCaption();
            int maxNumber = GetNumber();
            string numberSequence = GetNumberSequence(maxNumber);
            PrintResult(maxNumber, numberSequence);
        }
        static void PrintCaption()
        {
            Console.Clear();
            Console.WriteLine("Вывод натуральных чисел в промежутке от N до 1\n");
        }
        static int GetNumber()
        {
            Console.Write("Введите натуральное число: ");
            return int.Parse(Console.ReadLine());
        }
        static string GetNumberSequence(int number)
        {
            if(number == 0)
                return 0.ToString();
            else if(number == 1)
                return 1.ToString();
                
            return $"{number}, {GetNumberSequence(number - 1)}";
        }
        static void PrintResult(int maxNumber, string numberSequence)
        {
            Console.WriteLine($"N = {maxNumber} -> {numberSequence}");
        }
    }
}