using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowMeUp
{
	public class DisplayBoard //will allow up to a 5x5 minefield. 
	{//build method for the
		
		
		public DisplayBoard() { }
		public string [,] Display(string[,] builtArray){
		//pass the array that is full of zeros and pass it the indexs
		for (int i = 0; i<builtArray.GetLength(0);i++)
            {
                Console.Write("_");
			
			for (int j = 0; j<builtArray.GetLength(1);j++)
				{
					Console.Write("|" + builtArray[i,j]);
				}
			}
			return builtArray;
		}
	}	
}
