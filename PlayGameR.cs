using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class PlayGameR
	{
		private int size;
		private int[,] backBoard;

		public PlayGameR()
		{
			size = SetSize();
		}

		public int SetSize()
		{
			string rawChoice;
			int choice;
			int size;
			Console.WriteLine("Please select a board size:\n1) 25\n2) 49\n3)100");

			rawChoice = Console.ReadLine();
			choice = Validator.CheckInts(rawChoice, 1, 3);//need to change in Validator

			if (choice == 1)
			{
				size = 5;
			}
			else if (choice == 2)
			{
				size = 7;
			}
			else
			{
				size = 10;
			}

			return size;
		}

		public int GetSize()
		{
			return size;
		}

		// drawboard draws up the player board.
		public string[,] MakeBoard()
		{
			string[,] playBoard = new string[size + 1, size + 1];
			for (int i = 0; i < playBoard.GetLength(0); i++)
			{
				Console.WriteLine();

				for (int j = 0; j < playBoard.GetLength(1); j++)
				{
					if (i == 0)
					{
						playBoard[j, i] = j.ToString();
					}
					else if (j == 0)
					{
						int letters = 65 + (i - 1);
						playBoard[j, i] = ((char)letters).ToString();
					}
					else
					{
						playBoard[j, i] = "#";
					}
					Console.Write($" {playBoard[j, i]} ");
				}
			}
			Console.WriteLine();
			return playBoard;
		}

		public string[] GetChoice()
		{
			int h = size;
			string choicesString;
			string validString;
			char[] splits = new char[] { ',', '/' };
			List<string> choices = new List<string>();

			char endLetter = (char)(65 + size - 1);

			Console.WriteLine($"Please pick a square to either flag or check.\nPlease enter your" +
				$" input in the following format: A-{endLetter} , y , F/C. F for flag and C for check:\n");
			choicesString = Console.ReadLine();
			validString = Validator.CheckInput(choicesString, endLetter, h);//change this as well 

			validString = validString.Trim();

			choices = validString.Split(splits).ToList();

			string[] formattedChoices = new string[choices.Count];

			for (int i = 0; i < choices.Count; i++)
			{
				formattedChoices[i] = choices[i];

				formattedChoices[i] = formattedChoices[i].Trim().ToUpper();
			}

			return formattedChoices;
		}

		public void PrintBoard(string[,] playBoard)
		{
			for (int i = 0; i < playBoard.GetLength(0); i++)
			{
				Console.WriteLine();

				for (int j = 0; j < playBoard.GetLength(1); j++)
				{
					Console.Write($"   {playBoard[j, i]}   ");
				}
			}
		}
	}
}

