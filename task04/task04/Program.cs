using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());

            var y = MyFuncion(x);

            Console.WriteLine("f(x) = " + y);

            Console.ReadKey();
        }
        static double MyFuncion(double x)
        {
            return Math.Abs(2 * Math.Sin((-3) * Math.Abs((x + 1) / 2)));
        }
    }
}
