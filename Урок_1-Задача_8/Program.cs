using System;

namespace _01_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВывод всех четных чисел от 1 до N.\n");

            Console.WriteLine("Введите число и нажмите 'Ввод'");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{number} --> ");

            if (number % 2 == 0) {
                do
                {
                    Console.Write($"{number - 2}, ");
                    number -= 2;
                } while (number - 2 > 0);
            }
            else{
                int newNum = number + 1;
                do
                {
                    Console.Write($"{newNum - 2}, ");
                    newNum -= 2;
                } while (newNum - 2 > 0);
            }
        }
    }
}