using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Player
    {   //get the name from the user input
        public string Name { get; set; }
        //set the Marker: X or O for each user
        public string Marker { get; set; }

        public bool IsTurn { get; set; }

        public Player(string name, string marker, bool isTurn)
        {
            Name = name;
            Marker = marker;
            IsTurn = isTurn;
        }
    }
}
