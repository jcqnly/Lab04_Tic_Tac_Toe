using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class GameActions
    {
        //get the player move selection
        public int Move { get; set; }

        public GameActions(int move)
        {
            Move = move;
        }
    }
}
