using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число m от 5 до 20");
            int m;
            if (!TryInputNumber(out m) || m < 5 || m > 20)
            {
                Console.WriteLine("Ошибка ввода. Значение должно быть от 5 до 20.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите натуральное число n от 5 до 20");
            int n;
            if (!TryInputNumber(out n) || n < 5 || n > 20)
            {
                Console.WriteLine("Ошибка ввода. Значение должно быть от 5 до 20.");
                Console.ReadKey();
                return;
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            PrintMatrix(matrix);
            Console.WriteLine();

            if (!AreColumnsInDescendingOrder(matrix))
            {
                Console.WriteLine("Столбцы массива не упорядочены по убыванию.");
            }
            else
            {
                Console.WriteLine("Столбцы массива упорядочены по убыванию.");
            }

            var averages = GetRowAverages(matrix);
            for (int i = 0; i < averages.Length; i++)
            {
                Console.WriteLine($"Строка {i} - среднее арифметическое равно {averages[i]}");
            }

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

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
        }

        static bool AreColumnsInDescendingOrder(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, j] < matrix[i + 1, j])
                    {
                        Console.WriteLine($"Нарушение порядка в столбце {j}, строки {i} и {i + 1}: {matrix[i, j]} < {matrix[i + 1, j]}");
                        return false;
                    }
                }
            }
            return true;
        }

        static double[] GetRowAverages(int[,] matrix)
        {
            var result = new double[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                result[i] = sum / matrix.GetLength(1);
            }

            return result;
        }
    }
}
