using System;

namespace L3_E23
{
    class Program
    {
        static void Main()
        {
            string caption = "\nТаблица кубов чисел от 1 до N для числа N\n";
            Console.WriteLine(caption.ToUpper());

            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{number} -> ");
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{Math.Pow(i, 3)} ");
            }

        }
    }
}