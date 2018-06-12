using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!TIC TAC TOE!!!");
            PlayerInfo();
            Console.Read();  
            Console.Clear();
        }

        /// <summary>
        /// Instantiate new players and set the values for their names and markers
        /// </summary>
        public static void PlayerInfo()
        {
            //create an instance of the Player class and set values for player 1
            Player Player1 = new Player("X", true);
            
            //create an instance of the Player class and set values for player 1
            Player Player2 = new Player("O", false);

            Console.WriteLine($"Player 1 you are {Player1.Marker}");
            Console.WriteLine($"Player 2 you are {Player2.Marker}");
            Console.Read();
            Console.Clear();
            DisplayGame();
        }

        /// <summary>
        /// Instantiate a gameboard to display
        /// </summary>
        public static void DisplayGame()
        {
            GameBoard game = new GameBoard();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"| {game.board[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.Read();
            PlayerActions();
        }

        public static void PlayerActions()
        {
            Console.WriteLine($"Player1, select a number: \n");
            GameActions Player1Moves = new GameActions(int.Parse(Console.ReadLine()));

            //call UpdateBoard to add moves
            UpdateBoard(Player1Moves.Move);

            Console.WriteLine($"Player2, select a number: \n");
            GameActions Player2Moves = new GameActions(int.Parse(Console.ReadLine()));

            //call UpdateBoard to add moves
            UpdateBoard(Player2Moves.Move);

            Console.WriteLine($"Player1 chose {Player1Moves.Move}");
            Console.WriteLine($"Player2 chose {Player2Moves.Move}");
        }

        public static void UpdateBoard(int move)
        {
            //Console.WriteLine($"UpdateBoard with {move}");
        }
    }
}
