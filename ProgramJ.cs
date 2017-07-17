using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class ProgramJ
	{
		public void ProJ(string[] args)//transfered main to Ryan remaned ProJ
		{
			int[,] guh = new int[15, 15];
			for (int i = 0; i < guh.GetLength(0); i++)
			{
				for (int j = 0; j < guh.GetLength(1); j++)
				{
					guh[i, j] = 0;
				}
			}
			BoardJ f = new BoardJ();
			guh = f.AddMines(guh, 50);
			guh = f.GameBoard(guh);
		}
	}
}
