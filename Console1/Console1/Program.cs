using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Некрасов");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ходит он меланхолически,");
            Console.WriteLine("Одевается цинически,");
            Console.WriteLine("Говорит метафорически,");
            Console.WriteLine("Надувает методически,");
            Console.WriteLine("И ворует артистически.");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
