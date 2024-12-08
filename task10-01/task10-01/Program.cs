using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n;

            if (!TryInputNumber(out n))
            {
                Console.ReadKey();
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Число n должно быть больше 0");
                Console.ReadKey();
                return;
            }

            double sum = 0;

            for (int i = 1; i <= n; i++)
                sum += 1.0/i;

            Console.WriteLine($"n-ная частичная сумма гармонического ряда для n = {n} равна {sum}");

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
