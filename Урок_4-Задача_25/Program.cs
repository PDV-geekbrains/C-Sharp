using System;

namespace L4_E25
{
    class Program
    {
        static void Main()
        {
            string caption = "\nВозведение числа А в натуральную степень В\n";
            Console.WriteLine(caption.ToUpper());

            Console.Write("Введите число А: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число В: ");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = a;

            if(b !=0)
            {
                for (int i = 1; i < b; i++)
                {
                    result = result * a;
                }
                Console.Write($"{a}, {b} -> {result} ");
            }
            else
            {
                Console.Write($"{a}, {b} -> 1 ");
            }
        }
    }
}