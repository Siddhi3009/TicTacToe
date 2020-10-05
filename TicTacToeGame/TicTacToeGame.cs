using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
        public char[] board;
        public TicTacToeGame()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {
            TicTacToeGame game = new TicTacToeGame();
            for (int position = 1; position < 10; position++)
            {
                game.board[position] = ' ';
            }
        }
        public string Choice()
        {
            Console.WriteLine("Enter your choice. \n1. X \n2. 0");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return "You Chose: X";
                case 2:
                    return "You Chose: 0";
                default:
                    return "Invalid Choice";
            }
        }
    }
}
