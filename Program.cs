using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowMeUp
{
	class Program
	{
		public static void Main(string[] args)
		{
			BuildArray ba = new BuildArray(5, 5);
			DrawBoard db = new DrawBoard();
			DisplayBoard b = new DisplayBoard();
			string [,] na = db.BuildArray();
			db.Print2DArray(na);
			//grab array from buildarray and feed it into display board


		}
	}
}
