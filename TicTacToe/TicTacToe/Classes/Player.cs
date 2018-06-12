using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Player
    {   //get the name from the user input and store it
        public string Name { get; set; }
        //set the Marker: X or O for each user
        public string Marker { get; set; }

        public Player(string name, string marker)
        {
            Name = name;
            Marker = marker;
        }


    }
}
