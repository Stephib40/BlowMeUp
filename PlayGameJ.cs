﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class PlayGameJ
	{
		public PlayGameJ() { }
		public string[,] MakeAMove(string[,] gameboard, int rowIndex, int columnIndex)
		{
			//ConvertToNum(rowIndex);
			if (gameboard[rowIndex, columnIndex] == "M")
			{
				// YouLose();
			}
			else
			{
				//    RevealIt(playerboard, rowIndex, columnIndex);
			}
			return gameboard;
		}
		public string[,] RevealIt(string[,] playerboard)
		{
			return playerboard;
		}
	}
}
