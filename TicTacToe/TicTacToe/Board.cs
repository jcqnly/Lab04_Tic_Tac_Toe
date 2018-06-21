using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        //initial board
        public string[,] GameBoard = new string[,]
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };

        public void DisplayBoard()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                for (int j = 0; j < GameBoard.Length; j++)
                {
                    Console.WriteLine($"| {GameBoard[i,j]} |");
                }
                Console.WriteLine();
            }
        }

    }
}
