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
            string computerChoice = "Computer:" + game.Choice();
            string userChoice = "User:" + game.Choice();
        }
    }
}
