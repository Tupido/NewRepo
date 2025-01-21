using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экзамен
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                if (IsHarshad(i))
                {
                    count++;
                }
            }

            Console.WriteLine("Количество чисел харшад, не превышающих 1 миллион: " + count);
            Console.ReadKey();
        }

        static bool IsHarshad(int number)
        {
            int sumOfDigits = GetSumOfDigits(number);
            return number % sumOfDigits == 0;
        }

        static int GetSumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
