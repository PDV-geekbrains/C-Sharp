using System;

namespace L5_E34
{
    class Program
    {
        static void Main()
        {
            int[] randomArray = GetRandom3DigitArray();

            int evenNumbers = GetNumberOfEvenNumbers(randomArray);

            Console.WriteLine($"[{string.Join(", ", randomArray)}] -> {evenNumbers}");
        }

        static int[] GetRandom3DigitArray()
        {
            int[] array = new int[4];

            for (int i = 0; i < 4; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }

            return array;
        }

        static int GetNumberOfEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                    count++;
            }
            return count;
        }
    }
}