using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = F(1, 2) + F(2, 2) + F(3, 5) + F(4, 3);
            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }
        static double F(double a, double b)
        {
            return (a+Math.Exp(-a))/b;
        }
    }
}
