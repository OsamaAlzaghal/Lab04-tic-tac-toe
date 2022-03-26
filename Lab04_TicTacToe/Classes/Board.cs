using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
			//TODO: Output the board to the console
			/// <summary>
			/// Tic Tac Toe Gameboard Output to the console app screen.
			/// </summary>
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"|{GameBoard[i, j]}|");
				}
				Console.WriteLine("");
			}

		}
	}
}
