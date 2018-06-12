using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIC TAC TOE!");
            PlayerChoose();
            Console.Read();
            Console.Clear();
        }

        public static void PlayerChoose()
        {
            Console.WriteLine("Player 1, enter your name: ");
            Player Player1 = new Player(Console.ReadLine(), "X");
            
            Console.WriteLine("Player 2, enter your name: ");
            Player Player2 = new Player(Console.ReadLine(), "O");

            Console.WriteLine($"Player 1 is {Player1.Name}, and you are {Player1.Marker}");
            Console.WriteLine($"Player 2 is {Player2.Name}, and you are {Player2.Marker}");
        }
    }
}
