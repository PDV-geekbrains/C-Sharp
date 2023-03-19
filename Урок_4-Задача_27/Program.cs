using System;

namespace L4_E27
{
    class Program
    {
        static void Main()
        {
            string caption = "\nВычисление суммы цифр в числе\n";
            Console.WriteLine(caption.ToUpper());

            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = number;
            
            while(temp >= 1)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"{number} -> {sum}");
        }
    }
}