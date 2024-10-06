using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            var number = int.Parse(Console.ReadLine());

            var last = number % 100;
            var third = last / 10;
            var cut = number / 10;
            var result = third * 1000 + cut;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}