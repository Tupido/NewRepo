using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите натуральное число n:");

            if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            int max = 0;
            int min = 9; 

            while (n > 0)
            {
                int digit = n % 10;

                if (digit > max)
                    max = digit;

                if (digit < min)
                    min = digit;

                n /= 10;
            }

            Console.WriteLine($"Максимальная цифра: {max}, Минимальная цифра: {min}");
            Console.WriteLine($"Разница между максимальной и минимальной цифрами: {max - min}");

            Console.ReadKey();
        }
    }
}
