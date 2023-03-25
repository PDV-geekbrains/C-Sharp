using System;
using System.Linq;

namespace L6_E41
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Введите несколько целых чисел через пробел");

            int[] numbers = Console.ReadLine().Split(" ").Select(x => Int32.Parse(x)).ToArray();

            int count = 0;
            foreach(int item in numbers)
            {
                if(item > 0)
                    count++;
            }

            Console.WriteLine($"{string.Join(", ", numbers)} -> {count}");
        }
    }
}