using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:");
            if (!TryInputNumber(out int n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода. Введите натуральное число.");
                Console.ReadKey();
                return;
            }

            int a = 0, b = 1, fib = 0;

            while (fib <= n)
            {
                fib = a + b;
                a = b;
                b = fib;
            }

            Console.WriteLine($"Первое число в последовательности Фибоначчи, большее {n}, это {fib}");
            Console.ReadKey();
        }

        static bool TryInputNumber(out int number)
        {
            number = 0;
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Ошибка ввода");
                return false;
            }

            number = n;
            return true;
        }
    }
}
