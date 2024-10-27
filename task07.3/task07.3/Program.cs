using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();

            int whitePawnRow, whitePawnColumn;

            DecodePosition(whitePawnPosition, out whitePawnRow, out whitePawnColumn);
            Console.WriteLine($"({whitePawnRow}; {whitePawnColumn})");

            Console.ReadKey();
        }

        static void DecodePosition(string position, out int x, out int y)
        {
            x = int.Parse(position[1].ToString());
            y = (int)position[0] - 0x60;
        }
        static void Main()
        {
            int boardSize;
            while (true)
            {
                Console.WriteLine("Введите размер доски");
                boardSize = int.Parse(Console.ReadLine());
                if (boardSize < 1 || boardSize > 26)
                {
                    Console.WriteLine("Допустисый размер от 1 до 26");
                    continue;
                }
                else
                    break;
            }

            PrintBoard(boardSize);

            Console.ReadKey();
        }

        static void PrintBoard(int size)
        {
            const ConsoleColor Dark = ConsoleColor.DarkRed;
            const ConsoleColor Light = ConsoleColor.Blue;

            PrintHeader(size);

            for (var i = size; i > 0; i--)
            {
                Console.Write($"{i,2}");

                ConsoleColor color;
                if (i % 2 == 0)
                    color = Light;
                else
                    color = Dark;

                for (var j = 0; j < size; j++)
                {
                    PrintSquare(color);

                    if (color == Light)
                        color = Dark;
                    else
                        color = Light;
                }

                Console.WriteLine(i);
            }

            PrintHeader(size);
        }

        static void PrintHeader(int size)
        {
            Console.Write("  ");
            for (int i = 0; i < size; i++)
                Console.Write((char)(0x61 + i));

            Console.WriteLine();
        }

        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = defaultColor;
        }
    }
}
