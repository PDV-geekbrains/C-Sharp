using System;

namespace L5_E38
{
    class Program
    {
        static void Main()
        {
            double[] randomArray = GetRandomArray();

            double delta = GetMinMaxDelta(randomArray);

            Console.WriteLine($"[{string.Join(", ", randomArray)}] -> {delta}");
        }
        // Генерация массива из 3-значных вещественных чисел.
        static double[] GetRandomArray()
        {
            double[] array = new double[4];

            for (int i = 0; i < array.Length; i++)
            {
                int num1 = new Random().Next(100, 1000);
                double num2 = num1;
                array[i] = num2 / 100;
            }

            return array;
        }

        static double GetMinMaxDelta(double[] array)
        {
            double min = array[0];
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < min)
                    min = array[i];
                else if(array[i] > max)
                    max = array[i];
            }

            return max - min;
        }
    }
}