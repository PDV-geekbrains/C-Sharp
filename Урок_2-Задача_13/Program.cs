using System;

namespace L2_E13
{
    class Program
    {
        static void Main()
        {
            string caption = "\nВывод на консоль третьей слева цифры введённого числа\n";
            Console.WriteLine(caption.ToUpper());

            Console.WriteLine("Введите число");
            string enteredString = Console.ReadLine();
            int stringLength = enteredString.Length;

            if(stringLength < 3)
            {
                Console.WriteLine($"{enteredString} -> третьей цифры нет");
            }
            else
            {
                int number = Convert.ToInt32(enteredString);

                if (number < 0)
                {
                    number *= -1;
                    stringLength -= 1;
                }
                System.Console.WriteLine(number);

                int result = number;

                for (int i = stringLength - 3; i > 0; i--)
                {
                    result = result / 10;
                }
                result %= 10;

                System.Console.WriteLine($"{number} -> {result}");
            }
        }
    }
}