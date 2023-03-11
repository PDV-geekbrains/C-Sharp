using System;

namespace L2_E10
{
    class Program
    {
        static void Main()
        {
          string caption = "\nВывод второй цифры 3-значного числа\n";
          Console.WriteLine(caption.ToUpper());

          Console.WriteLine("Введите трёхзначное число");
          int num = Convert.ToInt32(Console.ReadLine());
          if(num <0)
              num *= -1;

            Console.WriteLine($"{num} -> {(num % 100) / 10}");
        }
    }
}
