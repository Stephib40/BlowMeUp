using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class Validator
	{
			static Validator()
			{

			}

			public static int CheckInts(string x, int min, int max)
			{
				int z;
				string y = x;
				while (!Int32.TryParse(y, out z) || z < min || z > max)
				{
					Console.WriteLine("Please select a board size:\n1) 25\n2) 49\n3)100");
					y = Console.ReadLine();
				}

				return z;
			}

			public static double CheckDubs(string x)
			{
				double z;
				string y = x;

				while (!Double.TryParse(y, out z) || z <= 0)
				{
					Console.WriteLine("That is not a valid input, please enter a positive number\n");
					y = Console.ReadLine();
				}

				return z;
			}

			public static string CheckInput(string x, char a, int h)
			{
				string b = a.ToString().ToLower();
				Regex reg = new Regex($@"\s?[aA-{b}{a}]\s?,\s?[1-{h}]\s?,\s?[fFcC]");


				while (!reg.IsMatch(x))
				{
					Console.WriteLine("Invalid entry. Please enter your move in the form x , y , F/C. F for Flag, C for Check: \n");
					x = Console.ReadLine();
				}


				return x;

			}
		}
	}

