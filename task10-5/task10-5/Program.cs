using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");

            int number;

            if (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            int smallestDivisor = -1;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    smallestDivisor = i;
                    break;
                }
            }

            if (smallestDivisor != -1)
            {
                Console.WriteLine($"Наименьший делитель {number}, отличный от 1: {smallestDivisor}");
            }

            Console.ReadKey();
        }
    }
}
