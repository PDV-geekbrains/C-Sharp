using System;

namespace L4_E29
{
    class Program
    {
        static void Main()
        {
            string caption = "\nЗаполнение массива числами пользователя\n";
            Console.WriteLine(caption.ToUpper());

            int[] arr = new int[8];

            for (int i = 0; i < 8; i++)
            {
                if(i == 7)
                    Console.WriteLine("Введите последнее число");
                else
                    Console.WriteLine("Введите число");

                int inputNumber = Convert.ToInt32(Console.ReadLine());
                arr[i] = inputNumber;

                PrintArray(i);
            }

            void PrintArray(int maxIndex)
            {
                for (int i = 0; i <= maxIndex; i++)
                {
                    if(i == 0)
                        Console.Write($"{arr[i]}");
                    else
                        Console.Write($", {arr[i]}");
                }

                Console.Write(" -> [");

                for (int i = 0; i <= maxIndex; i++)
                {
                    if(i == 0)
                        Console.Write($"{arr[i]}");
                    else
                        Console.Write($", {arr[i]}");
                }
                Console.Write("]\n");
            }
            //Console.Write($"-> [{string.Join(", ", arr)}]");
        }
    }
}