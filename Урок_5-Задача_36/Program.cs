using System;

namespace L5_E36
{
    class Program
    {
        static void Main()
        {
            int[] randomArray = GetRandomNumbersArray();

            int sum = GetSum(randomArray);

            Console.WriteLine($"[{string.Join(", ", randomArray)}] -> {sum}");
        }

        static int[] GetRandomNumbersArray()
        {
            int[] array = new int[4];

            for (int i = 0; i < 4; i++)
            {
                array[i] = new Random().Next(1, 100);
            }

            return array;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            int i = 1;
            while( i < 4)
            {
                sum += array[i];
                i += 2;
            }

            return sum;
        }
    }
}