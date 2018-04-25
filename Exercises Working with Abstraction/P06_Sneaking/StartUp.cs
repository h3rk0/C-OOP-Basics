using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static char[][] room;
        static void Main()
        {
			// number of rows 
            int rows = int.Parse(Console.ReadLine());
            room = new char[rows][];

			// initiallize matrix
			Matrix matrix = new Matrix(rows);

			// read matrix
			matrix.ReadMatrix();

			// read moves
			char[] moves = Console.ReadLine().ToCharArray();

			// going trought each move
			for (int moveIndex = 0; moveIndex < moves.Length; moveIndex++)
			{
				matrix.MoveEnemies();

				if (matrix.playerAlive == false)
				{
					Console.WriteLine($"Sam died at {matrix.Player.Row}, {matrix.Player.Col}");
					//matrix.PrintCurrentMatrix();
					break;
				}

				matrix.PlayerMove(moves[moveIndex]);

				if (matrix.nikoladzeAlive == false)
				{
					Console.WriteLine($"Nikoladze killed!");
					//matrix.PrintCurrentMatrix();
					break;
				}
				//matrix.PrintCurrentMatrix();
				//Console.WriteLine();
			}

			matrix.PrintCurrentMatrix();

			//matrix.PrintCurrentMatrix();

			//Console.WriteLine(matrix.Nikoladze);

			//Console.WriteLine(matrix.Player);

			//foreach (Enemy enemy in matrix.Enemies)
			//{
			//	Console.WriteLine(enemy);
			//}

		}
	}

}

