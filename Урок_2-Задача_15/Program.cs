using System;

namespace L2_E15
{
    class Program
    {
        static void Main()
        {
            string caption = "\nВведённый день недели - выходной?\n";
            Console.WriteLine(caption.ToUpper());

            Console.WriteLine("Введите порядковый номер дня недели: 1 - Пн. ... 7 - Вс.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Введите число от 1 до 7 включительно");
            }
            else if (number < 6)
            {
                if (number < 6)
                    Console.WriteLine($"{number} -> нет");
            }
            else
            {
                Console.WriteLine($"{number} -> да");
            }
        }
    }
}