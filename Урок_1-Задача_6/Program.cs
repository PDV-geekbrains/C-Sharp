using System;

namespace _01_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nОпределение чётности числа.\n");

            Console.WriteLine("Введите число и нажмите 'Ввод'");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number%2 != 0)
                Console.WriteLine($"{number} -> нет");
            else
                Console.WriteLine($"{number} -> да");
        }
    }
}