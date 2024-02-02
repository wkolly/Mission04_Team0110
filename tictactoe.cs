using System;

public class GameBoard
{

    // This method prints the board 3 by 3 and writes out all the numbers
    public static void PrintBoard(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    // This method checks for the winner by going through each row and seeing if they are all in row. If it is then 
    // it will return a winner. If there is no winner it will return false. 
    public static bool CheckForWinner(string[,] board)
    {
        // Check rows
        for (int row = 0; row < 3; row++)
        {
            if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
            {
                return true;
            }
        }

        // Check columns
        for (int col = 0; col < 3; col++)
        {
            if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
            board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return true;
        }

        return false;
    }
}
