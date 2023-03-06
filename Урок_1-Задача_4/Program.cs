using System;

namespace _01_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nОпределение максимального из трёх чисел.\n");

            Console.WriteLine("Введите первое число и нажмите 'Ввод'");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число и нажмите 'Ввод'");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число и нажмите 'Ввод'");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber == secondNumber && firstNumber == thirdNumber)
                Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} " +
                    $"-> {firstNumber}");
            
            if(firstNumber > secondNumber){
                if(firstNumber > thirdNumber)
                    Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} " +
                        $"-> {firstNumber}");
                else
                    Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} " +
                        $"-> {thirdNumber}");
            }
            else{
                if(secondNumber > thirdNumber)
                    Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} " +
                        $"-> {secondNumber}");
                else
                    Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} " +
                        $"-> {thirdNumber}");
            }
        }
    }
}