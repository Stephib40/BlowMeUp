﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermTesting
{
	class BoardJ
	{
			private Random n = new Random();
			public BoardJ()
			{

			}

			public int[,] AddMines(int[,] board, int numMines)
			{
				while (numMines != 0)
				{
					int index1 = n.Next(0, board.GetLength(0));
					int index2 = n.Next(0, board.GetLength(1));
					if (board[index1, index2] == 0)
					{
						board[index1, index2] = 100;
						numMines--;
					}
				}
				// PrintBoard(board);
				return board;
			}
			public int[,] GameBoard(int[,] board)
			{
				for (int i = 0; i < board.GetLength(0); i++)
				{
					for (int j = 0; j < board.GetLength(1); j++)
					{

						if (board[i, j] >= 100)
						{
							//                        Console.WriteLine("I = "+i+" J = "+j);
							// I = Column, J = Row
							if (((i - 1) >= 0) && ((i + 1) < board.GetLength(0)))
							{
								//Middle of the board case
								if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
								{
									board[(i - 1), (j - 1)]++;
									board[(i - 1), j]++;
									board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									board[(i + 1), (j + 1)]++;

								}

								//Top edge case
								else if ((j - 1) >= 0)
								{
									board[(i - 1), (j - 1)]++;
									board[(i - 1), j]++;
									// board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									// board[i, (j + 1)]++;
									board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									// board[(i + 1), (j + 1)]++;
								}

								//Bottom edge case
								else if ((j + 1) < board.GetLength(1))
								{
									//board[(i - 1), (j - 1)]++*/;
									board[(i - 1), j]++;
									board[(i - 1), (j + 1)]++;
									//board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									//board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									board[(i + 1), (j + 1)]++;
								}
							}

							//Working

							else if ((i - 1) >= 0)
							{
								// Right edge case
								if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
								{
									board[(i - 1), (j - 1)]++;
									board[(i - 1), j]++;
									board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									//board[(i + 1), (j - 1)]++;
									//board[(i + 1), j]++;
									//board[(i + 1), (j + 1)]++;
								}
								//Top Right Corner case
								else if ((j - 1) >= 0)
								{
									board[(i - 1), (j - 1)]++;
									board[(i - 1), j]++;
									//board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									//board[i, (j + 1)]++;
									//board[(i + 1), (j - 1)]++;
									//board[(i + 1), j]++;
									//board[(i + 1), (j + 1)]++;
								}
								// Working
								//Top right corner case
								else if ((j + 1) < board.GetLength(1))
								{

									// board[(i - 1), (j - 1)]++;
									board[(i - 1), j]++;
									board[(i - 1), (j + 1)]++;
									//board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									//board[(i + 1), (j - 1)]++;
									//board[(i + 1), j]++;
									//board[(i + 1), (j + 1)]++;
								}
							}
							else if ((i + 1) < board.GetLength(0))

							{// Left edge case
								if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
								{
									//board[(i - 1), (j - 1)]++;
									//board[(i - 1), j]++;
									//board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									board[(i + 1), (j + 1)]++;
								}
								else if ((j + 1) < board.GetLength(1))
								{// Bottom right corner case

									//board[(i - 1), (j - 1)]++;
									//board[(i - 1), j]++;
									//board[(i - 1), (j + 1)]++;
									//board[i, (j - 1)]++;
									board[i, (j + 1)]++;
									//board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									board[(i + 1), (j + 1)]++;
								}
								//bottom left corner case
								else if ((j - 1) >= 0)
								{
									//board[(i - 1), (j - 1)]++;
									//board[(i - 1), j]++;
									//board[(i - 1), (j + 1)]++;
									board[i, (j - 1)]++;
									//board[i, (j + 1)]++;
									board[(i + 1), (j - 1)]++;
									board[(i + 1), j]++;
									//board[(i + 1), (j + 1)]++;
								}
							}

						}

					}
				}


				PrintBoard(board);
				return board;
			}
			public void PrintBoard(int[,] board)
			{
				for (int i = 0; i < board.GetLength(0); i++)
				{
					for (int j = 0; j < board.GetLength(1); j++)
					{
						if ((board[i, j]) < 10)
						{
							Console.Write(board[i, j] + "   ");
						}
						else
						{
							Console.Write(board[i, j] + " ");
						}

					}
					Console.WriteLine();
				}
			}
		}
}
