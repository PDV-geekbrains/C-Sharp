using System;

namespace _01_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nСравнение двух чисел.\n");

            Console.WriteLine("Введите первое число и нажмите 'Ввод'");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число и нажмите 'Ввод'");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber == secondNumber)
                Console.WriteLine($"a = {firstNumber}, b = {secondNumber} -> a = b\n");
            else if(firstNumber > secondNumber)
                Console.WriteLine($"a = {firstNumber}, b = {secondNumber} -> max = {firstNumber}\n");
            else
                Console.WriteLine($"a = {firstNumber}, b = {secondNumber} -> max = {secondNumber}\n");
        }
    }
}