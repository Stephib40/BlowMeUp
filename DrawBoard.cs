using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowMeUp//build the array board for "model"
{
	class DrawBoard//drawing out the array of 1,0's
	{
		public DrawBoard() { }
		public void Print2DArray(string[,] arr)
		{
		
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
				}
			}
		}

		public string[,] BuildArray()
		{
			string [,] thing = new string[5, 5];
			for (int i = 0; i < thing.GetLength(0); i++)
			{
				for (int j = 0; j < thing.GetLength(1); j++)
				{
					thing[i, j] = "0";
				}
			}
			//int [,]thing =new int[,] { { 0, 0, 0, 0, 0 } , { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
			return thing; 
		}
		
		
	


	}

}
