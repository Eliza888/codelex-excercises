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
                if (x <= 2 && y <= 2 && x >= 0 && y >= 0 && _board[x, y] == ' ') ;
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
            for (var r = 0; r < 3; r++)
            {
                if (_board[r, 0] != ' ' && _board[r, 0] == _board[r, 1] && _board[r, 1] == _board[r, 2])
                {
                    return true;
                }
            }

            for (var c = 0; c < 3; c++)
            {
                if (_board[0, c] != ' ' && _board[0, c] == _board[1, c] && _board[1, c] == _board[2, c])
                {
                    return true;
                }
            }

            if (_board[0, 0] != ' ' && _board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2])
            {
                return true;
            }

            if (_board[0, 2] != ' ' && _board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])
            {
                return true;
            }

            return false;
        }

        private static bool BoardHasAnyEmptyCell()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    if (_board[r, c] == ' ') ;
                    { 
                        return true;
                    } 
                }
                    
            }
            return false;
        }
      
        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    _board[r, c] = ' ';
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