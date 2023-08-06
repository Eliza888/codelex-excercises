using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace TicTacToe
{
    class Program
    {
        private static char[,] _board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            var counter = 0;
            char winner = '\0';

            while (BoardHasAnyEmptyCell() && !HasWinner())
            {
                var player = counter % 2 == 0 ? 'x' : 'o';
                Console.WriteLine("Input coordinates in the format X Y.");
                var input = Console.ReadLine();
                var coords = input.Split(' ');
                var x = int.Parse(coords[0]);
                var y = int.Parse(coords[1]);
                if (x <= 2 && y <= 2 && x >= 0 && y >= 0 && _board[x, y] == ' ')
                {
                    _board[x, y] = player;
                }

                counter++;
                DisplayBoard();

                if (HasWinner())
                {
                    winner = player;
                    Console.WriteLine($"{winner} is the winner!");
                }
            }

            if (winner == '\0')
            {
                Console.WriteLine("It's a draw!");
            }
        }

        private static bool HasWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((_board[i, 0] != ' ' && _board[i, 0] == _board[i, 1] && _board[i, 1] == _board[i, 2]) ||
                    (_board[0, i] != ' ' && _board[0, i] == _board[1, i] && _board[1, i] == _board[2, i]))
                {
                    return true;
                }
            }

            return (_board[0, 0] != ' ' && _board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2]) ||
                   (_board[0, 2] != ' ' && _board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0]);
        }

        private static bool BoardHasAnyEmptyCell()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_board[i, j] == ' ')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void InitBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    _board[r, c] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + _board[0, 0] + "|" + _board[0, 1] + "|" + _board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + _board[1, 0] + "|" + _board[1, 1] + "|" + _board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + _board[2, 0] + "|" + _board[2, 1] + "|" + _board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}