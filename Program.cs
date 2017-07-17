using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class Program
	{
		static void Main(string[] args)//Ryans code and made the Main()
		{
			BoardJ board = new BoardJ();

			// board.GameBoard()
			PlayGameR newGame = new PlayGameR();
			int[,] arr1 = new int[6, 6];

			int[,] backBoard = board.GameBoard(arr1);
			backBoard = board.AddMines(backBoard, 5);

			string[,] playerBoard = newGame.MakeBoard();
			string[] choices = newGame.GetChoice();

			playerBoard = UpdateBoard(backBoard, playerBoard, choices);

			newGame.PrintBoard(playerBoard);


			//for(int i = 0; i < board.GetLength(0); i++)
			//{
			//    Console.WriteLine();

			//    for(int j = 0; j < board.GetLength(1); j++)
			//    {
			//        Console.WriteLine(board[j, i]);

			//    }
			//}
			//newDraw.Print2DArray(arr1);
		}
		public static string[,] UpdateBoard(int[,] backBoard, string[,] playBoard, string[] choices)
		{
			string coords = string.Join("", choices);
			char[] charChoices = coords.ToCharArray();
			int y = charChoices[0] - 64;
			int x = (int)Char.GetNumericValue(charChoices[1]);
			char flagCheck = charChoices[2];


			if (backBoard[x, y] != 100)
			{
				playBoard[x, y] = "x";
			}
			else if (backBoard[x, y] == 100)
			{
				playBoard[x, y] = "BOOM";
			}
			return playBoard;
		}
	}
}

