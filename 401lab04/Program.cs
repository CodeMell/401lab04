using _401lab04;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            StartGame();
        }

        public static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Welcome to Tic Tac Toe!");

            Console.Write("Enter Player 1 name: ");
            string p1Name = Console.ReadLine();
            Player p1 = new Player { Name = p1Name, Marker = "X", IsTurn = true };

            Console.Write("Enter Player 2 name: ");
            string p2Name = Console.ReadLine();
            Player p2 = new Player { Name = p2Name, Marker = "O", IsTurn = false };

            Game game = new Game(p1, p2);
            game.Board.DisplayBoard();

            Player winner = game.Play();

            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }


    }
}
