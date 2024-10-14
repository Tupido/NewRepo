using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace task6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "перевозка";
            var word1 = s
                .Remove(5)
                .Remove(0, 1)
                .Remove(0, 0);

            word1 += s.Substring(6); 

            Console.WriteLine(word1);



            Console.ReadKey();
        }
    }
}
