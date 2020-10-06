using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTacToeGame game = new TicTacToeGame();
            int playAnotherGame = 1;
            while (playAnotherGame == 1)
            {
                game.CreateBoard();
                char userChoice = game.Choice();
                char compChoice;
                if (userChoice == 'X')
                    compChoice = '0';
                else
                    compChoice = 'X';
                game.ShowBoard();
                game.Play(userChoice, compChoice);
                Console.WriteLine("Do you want to play another game? \n1. Yes\n2. No");
                playAnotherGame = int.Parse(Console.ReadLine());
            }
        }
    }
}
