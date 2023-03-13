using System;

namespace L3_E21
{
    class Program
    {
        static void Main()
        {
            string caption = "\nВычисление расстояния между двумя точками " +
                "в 3-мерном пространстве\n";
            Console.WriteLine(caption.ToUpper());

            Console.WriteLine("Введите координаты точки А:");
            Console.Write(" X = ");
            double ax = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Y = ");
            double ay = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Z = ");
            double az = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите координаты точки B:");
            Console.Write(" X = ");
            double bx = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Y = ");
            double by = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Z = ");
            double bz = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

            Console.WriteLine($"\nA({ax},{ay},{az}); B({bx},{by},{bz}) -> {distance:f2}");
        }
    }
}