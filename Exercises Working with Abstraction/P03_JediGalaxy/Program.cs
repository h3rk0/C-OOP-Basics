using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
			// read dimensions
            int[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimensions[0];
            int y = dimensions[1];

			// result
			long sum = 0;
			
			// initialize matrix
			int[,] matrix = new int[x, y];
			matrix = Initialize(matrix);
            
			// read command
            
            

            while (true)
            {
				// read command
				string command = Console.ReadLine();

				if(command == "Let the Force be with you")
				{
					break;
				}


				// jedi cooords array
				int[] playerCoords = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

				// evil coords
				int[] evilCoords = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int evilRow = evilCoords[0];
                int evilCol = evilCoords[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (evilRow >= 0 && evilRow < matrix.GetLength(0) && evilCol >= 0 && evilCol < matrix.GetLength(1))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }
                    evilRow--;
                    evilCol--;
                }

				// player coords
                int playerRow = playerCoords[0];
                int playerCol = playerCoords[1];

                while (playerRow >= 0 && playerCol < matrix.GetLength(1))
                {
                    if (playerRow >= 0 && playerRow < matrix.GetLength(0) && playerCol >= 0 && playerCol < matrix.GetLength(1))
                    {
                        sum += matrix[playerRow, playerCol];
                    }

                    playerCol++;
                    playerRow--;
                }
				
            }

            Console.WriteLine(sum);

        }

		private static int[,] Initialize(int[,] matrix)
		{
			int value = 0;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = value++;
				}
			}

			return matrix;
		}
	}
}
