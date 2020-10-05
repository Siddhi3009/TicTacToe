using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            Console.WriteLine("Enter your choice. \nX \n0");
            char userSign = Convert.ToChar(Console.ReadLine());
            game.Choice(userSign);
            game.ShowBoard();
            game.PlayerMovement();
        }
    }
}
