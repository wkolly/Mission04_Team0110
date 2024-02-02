// Group 1-10 Alex P, Ryan T, Justin C, Will K
// Tictactoe

using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] board = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        string currentPlayer = "X";
        bool gameWon = false;
        int moves = 0;

        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (!gameWon)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            GameBoard.PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer}, choose a position:");
            int choice = Convert.ToInt32(Console.ReadLine());

            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;

            if (board[row, col] != "X" && board[row, col] != "O")
            {
                board[row, col] = currentPlayer;
                moves++;

                gameWon = GameBoard.CheckForWinner(board);

                if (gameWon)
                {
                    Console.Clear();
                    GameBoard.PrintBoard(board);
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }
                else if (moves == 9)
                {
                    Console.Clear();
                    GameBoard.PrintBoard(board);
                    Console.WriteLine("It's a tie!");
                    break;
                }

                currentPlayer = currentPlayer == "X" ? "O" : "X";
            }
            else
            {
                Console.WriteLine("That position is already taken. Try again.");
            }
        }
    }
}
