using System;

namespace test
{
    class Program
    {
        static void Main()
        {
            string caption = "\nЯвляется ли число палиндромом\n";
            Console.WriteLine(caption.ToUpper());

            Console.WriteLine("Введите число: ");
            string inputString = Console.ReadLine();

            int inputNumber = Convert.ToInt32(inputString);
            int inputLength = inputString.Length;

            // Переместить цифры в ячейки массива.
            int[] splitNumber = new int[inputLength];
            int number = inputNumber;
            for (int i = 0; i < inputLength; i++)
            {
                splitNumber[i] = (int)(number % 10);
                number = (int)(number / 10);
            }

            // Собрать число в обратном порядке.
            int newNumber = 0;
            for (int i = 0; i < inputLength; i++)
            {
                newNumber += splitNumber[i];
                if(i < inputLength - 1)
                    newNumber *= 10;
            }

            //Сравнить числа.
            if(inputNumber - newNumber == 0)
                System.Console.WriteLine("Это палиндром");
            else
                System.Console.WriteLine("Это не палиндром");
        }
    }
}