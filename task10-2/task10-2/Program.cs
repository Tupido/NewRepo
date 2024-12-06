using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество студентов");
            int m;

            if (!TryInputNumber(out m) || m <= 0)
            {
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Введите количество экзаменов");
            int k;

            if (!TryInputNumber(out k) || k <= 0)
            {
                Console.ReadKey();
                return;
            }

            for (int i = 1; i <= m; i++)
            {
                int totalScore = 0;
                Console.WriteLine($"Введите оценки студента {i} через пробел:");

                for (int j = 1; j <= k; j++)
                {
                    int score;
                    if (!TryInputNumber(out score) || score < 0 || score > 100)
                    {
                        Console.WriteLine("Оценка должна соответствовать 100 бальной шкале");
                        Console.ReadKey();
                        return;
                    }
                    totalScore += score;
                }
                Console.WriteLine($"Сумма баллов студента {i} составляет {totalScore}");
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
    }
}
