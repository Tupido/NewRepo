using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "перевозка";
            var word1 = s;
            word1 = ReverseString(s
                .Remove(5)
                .Remove(0, 1));

            word1 += s
                .Remove(5)
                .Remove(0, 4);

            word1 += s.Substring(7);

            Console.WriteLine(word1);

            var word2 = s
                .Remove(6)
                .Remove(1, 4);

            word2 += s.Substring(4);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}