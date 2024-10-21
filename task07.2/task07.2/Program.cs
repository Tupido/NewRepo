using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки через пробел");
            var input = Console.ReadLine();

            var k = input.IndexOf(" ");
            var x = double.Parse(input.Substring(0, k));
            var y = double.Parse(input.Substring(k + 1));

            Console.WriteLine($"Введена точка({x}; {y})");

            if (PointInArea(x, y))
                Console.WriteLine("Лежит");
            else 
                Console.WriteLine("Не лежит");
        }

        static bool PointInArea(double x,  double y) 
        {
            return ();
        }
    }
}
