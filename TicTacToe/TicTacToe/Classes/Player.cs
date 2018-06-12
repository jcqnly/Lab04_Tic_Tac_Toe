using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Player
    {   
        //set the Marker: X or O for each user
        public string Marker { get; set; }

        public bool IsTurn { get; set; }

        public Player(string marker, bool isTurn)
        {
            Marker = marker;
            IsTurn = isTurn;
        }
    }
}
