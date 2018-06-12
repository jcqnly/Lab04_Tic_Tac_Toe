using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class GameActions
    {
        //get the player move selection
        public string Move { get; set; }

        public GameActions(string move)
        {
            Move = move;
        }
    }
}
