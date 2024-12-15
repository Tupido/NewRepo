using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число n");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }

            var digits = GetDigits(n);
            PrintArray(digits);

            TransformArray(digits);
            PrintArray(digits);

            Console.WriteLine("Введите число m (0 <= m <= 9)");
            int m;
            if (!int.TryParse(Console.ReadLine(), out m) || m < 0 || m > 9)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Число {m} встречается {CountOccurrences(digits, m)} раз(а) в массиве.");

            var transformedArray = ReplaceEvenOdd(digits);
            PrintArray(transformedArray);

            Console.ReadKey();
        }

        static int[] GetDigits(int number)
        {
            var digits = number.ToString().ToCharArray();
            int[] result = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                result[i] = int.Parse(digits[i].ToString());
            }

            return result;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TransformArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 9 - array[i];
            }
        }

        static int CountOccurrences(int[] array, int m)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item == m)
                    count++;
            }
            return count;
        }

        static int[] ReplaceEvenOdd(int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (array[i] % 2 == 0) ? 0 : 1;
            }

            return result;
        }
    }
}
