using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowMeUp
{
	class BuildArray
	{
		int length;
		int width;

		//string[,] board = new string[5, 5];
		//for(int i = 0; i < board.GetLength(0); i++)
		public BuildArray(int width, int length)
		{
			this.length = length;//sets the local length to the passed length
			this.width = width;//sets the local width to the passed width
		}

		public string[,] MyArray(int width, int length)
		{
			string[,] builtArray = new string[width, length];
			for (int i = 0; i < builtArray.GetLength(0); i++)//for columns
			{
				for (int j = 0; j < builtArray.GetLength(1); j++)//for rows
				{
					builtArray[i, j] = "0";
				}
			}
			return builtArray;
		}
	}
}
