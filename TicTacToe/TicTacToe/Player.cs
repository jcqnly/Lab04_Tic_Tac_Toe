using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Player
    {   //set the properties of the Player class
        public string Name { get; set; }
        public string Marker { get; set; }
        public bool IsTurn { get; set; }
        //each instance of this Player class will have a name
        //a marker, and it's their turn
        public Player(string name, string marker, bool isTurn)
        {
            Name = name;
            Marker = marker;
            IsTurn = isTurn;
        }

        //Figure out position of where the player wants to go
    }
}
