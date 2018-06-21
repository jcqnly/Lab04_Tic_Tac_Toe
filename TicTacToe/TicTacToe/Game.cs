using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{ 
    public class Game
    {
        //a game involves 2 players and a board
        //a game will determine a winner
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Board Board { get; set; }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
            Board = new Board();
        }

        public Player Play()
        {
            Board.DisplayBoard();
        }

        public Player NexPlayer()
        {
            return ((Player1.IsTurn) ? Player1 : Player2);
        }

        //check for winner

    }
}
