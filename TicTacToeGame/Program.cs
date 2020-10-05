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
            char userChoice = game.Choice();
            char compChoice;
            if (userChoice == 'X')
                compChoice = '0';
            else
                compChoice = 'X';
            game.ShowBoard();
            game.PlayerMovement(userChoice);
            game.ComputerMovement(compChoice);
        }
    }
}
