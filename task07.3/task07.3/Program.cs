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
            Console.WriteLine("Введите позицию белого короля:");
            var whiteKing = Console.ReadLine();
            Console.WriteLine("Введите позицию чёрного ферзя:");
            var blackQueen = Console.ReadLine();

            if (whiteKing == blackQueen || IsWhiteKingUnderAttack(whiteKing, blackQueen))
            {
                Console.WriteLine("Король не должен стоять под боем или на той же клетке, что и ферзь.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию хода белого короля:");
            var move = Console.ReadLine();
            bool isValidMove = IsMoveCorrect(move, whiteKing, blackQueen);
            Console.WriteLine(isValidMove ? "Ход возможен" : "Ход невозможен");

            Console.ReadKey();
        }

        static bool IsWhiteKingUnderAttack(string whiteKing, string blackQueen)
        {
            return IsSameRowOrColumn(whiteKing, blackQueen) || IsDiagonalAttack(whiteKing, blackQueen);
        }

        static bool IsSameRowOrColumn(string pos1, string pos2)
        {
            int r1, c1, r2, c2;
            DecodePosition(pos1, out c1, out r1);
            DecodePosition(pos2, out c2, out r2);

            return r1 == r2 || c1 == c2; 
        }
        static bool IsDiagonalAttack(string pos1, string pos2)
        {
            int r1, c1, r2, c2;
            DecodePosition(pos1, out c1, out r1);
            DecodePosition(pos2, out c2, out r2);

            return Math.Abs(r1 - r2) == Math.Abs(c1 - c2); 
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = position[0] - 'a' + 1;
        }

        static bool IsMoveCorrect(string move, string whiteKingPosition, string blackQueenPosition)
        {
            int wc, wr, mc, mr;
            DecodePosition(whiteKingPosition, out wc, out wr);
            DecodePosition(move, out mc, out mr);

            bool isInBounds = mc >= 1 && mc <= 8 && mr >= 1 && mr <= 8;
            bool isOneStepMove = Math.Abs(wc - mc) <= 1 && Math.Abs(wr - mr) <= 1; 
            bool isUnderAttack = IsWhiteKingUnderAttack(move, blackQueenPosition);

            return isInBounds && isOneStepMove && (move != blackQueenPosition) && !isUnderAttack;
        }
    }
}
