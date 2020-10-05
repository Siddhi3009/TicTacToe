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
    }
}
