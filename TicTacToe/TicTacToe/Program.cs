using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!TIC TAC TOE!!!");
            PlayerChoose();
            Console.Read();
            Console.Clear();
            DisplayGame();
            Console.Read();
        }

        /// <summary>
        /// Instantiate new players and set the values for their names and markers
        /// </summary>
        public static void PlayerChoose()
        {
            Console.WriteLine("Player 1, enter your name: ");
            //create an instance of the Player class and set values for player 1
            Player Player1 = new Player(Console.ReadLine(), "X");
            
            Console.WriteLine("Player 2, enter your name: ");
            //create an instance of the Player class and set values for player 1
            Player Player2 = new Player(Console.ReadLine(), "O");

            Console.WriteLine($"Player 1 is {Player1.Name}, and you are {Player1.Marker}");
            Console.WriteLine($"Player 2 is {Player2.Name}, and you are {Player2.Marker}");
        }

        /// <summary>
        /// Instantiate a gameboard to display
        /// </summary>
        public static void DisplayGame()
        {
            GameBoard game = new GameBoard();
            PlayerActions();
        }
    }
}
