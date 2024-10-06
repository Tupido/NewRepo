using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskTeams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны правильного икосаэдра");
            double a = double.Parse(Console.ReadLine());

            double x = Math.Pow(a, 2);
            double c = 3;
            double y = Math.Sqrt(c);
            double s = 5 * x * y;
            double k = Math.Pow(a, 3);
            double b = 5;
            double z = Math.Sqrt(b);
            double v = (5 * k * (3 + z)) / 12;

            Console.WriteLine("Площадь икосаэдра: " + Math.Round(s, 2));
            Console.WriteLine("Объём икосаэдра: " + Math.Round(v, 2));

            Console.ReadKey();
        }
    }
}
