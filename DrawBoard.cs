using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowMeUp//build the array board for "model"
{
	class DrawBoard//drawing out the array of 1,0's
	{
		static void Print2DArray(int[,] arr)
		{
		
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
				}
			}
		}

		static void BuildArray()
		{
			Print2DArray(new int[,] { { 0, 0, 0, 0, 0 } , { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } });
		}
		
	


	}

}
