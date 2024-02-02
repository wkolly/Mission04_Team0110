// Group 1-10 Alex P, Ryan T, Justin C, Will K
// Tictactoe

using System;

class Program
{
    static void Main(string[] args)
    {
        // creating a string to display the board, setting the current player, and the game. 
        string[,] board = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        string currentPlayer = "X";
        bool gameWon = false;
        int moves = 0;

        // welcome the user 
        Console.WriteLine("Welcome to Tic-Tac-Toe!");


        // play the game if the gamewon is false 
        while (!gameWon)
        {
            // clear the console, welcome the user, print the board, and tell which player is up
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            GameBoard.PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer}, choose a position:");


            // account for invalid inputs 
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            }

            // allowing the user to choose a place on the board 
            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;


            // if statement that will allow each user to to place their "X" or "O" on the board depending on whos turn it is 
            if (board[row, col] != "X" && board[row, col] != "O")
            {
                board[row, col] = currentPlayer;
                moves++;

                gameWon = GameBoard.CheckForWinner(board);

                // if a player wins the game clear the console and print out which player won 
                if (gameWon)
                {
                    Console.Clear();
                    GameBoard.PrintBoard(board);
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }
                // if no one wins the game print out that it is a tie
                else if (moves == 9)
                {
                    Console.Clear();
                    GameBoard.PrintBoard(board);
                    Console.WriteLine("It's a tie!");
                    break;
                }
                // initializing the current player
                currentPlayer = currentPlayer == "X" ? "O" : "X";
            }
            // if a user tries to enter into a space that is already taken it will tell you to try again. 
            else
            {
                Console.WriteLine("That position is already taken. Try again.");
            }
        }
    }
}