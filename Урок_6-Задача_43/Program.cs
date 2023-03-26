using System;
using System.Linq;

namespace L6_E43
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string header = "Определение точки пересечения двух " +
                "прямых на плоскости:\n" +
                "y1 = k1*x1 + b1\n" +
                "y2 = k2*x2 + b2";
            Console.WriteLine($"{header.ToUpper()}\n");

            Console.Write("Введите значение k1: ");
            double k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            double k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            if(k1 == k2 && b1 == b2)
                Console.WriteLine("\nПрямые совпадают.");
            else if(b1 == b2)
                Console.WriteLine("\nПрямые не пересекаются.");
            else
            {
                double crosspointX = (b2 - b1) / (k1 - k2);
                double crosspointY = k1 * crosspointX + b1;

                Console.WriteLine($"\nk1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> " +
                $"({crosspointX}, {crosspointY})");
            }
        }
    }
}