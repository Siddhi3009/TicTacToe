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
        public void Choice()
        {
            Console.WriteLine("Enter your choice. \nX \n0");
            string userChoice = Console.ReadLine();
            string choice;
            switch (userChoice)
            {
                case "X":
                    choice = "You Chose: X";
                    break;
                case "0":
                    choice = "You Chose: 0";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
        }
        public void ShowBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  1  |  2  |  3");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  4  |  5  |  6");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  7  |  8  |  9");
            Console.WriteLine("     |     |      ");
        }
    }
}
