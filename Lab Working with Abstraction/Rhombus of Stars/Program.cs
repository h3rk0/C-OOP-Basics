using System;


class Program
{
    static void Main(string[] args)
    {
		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= n; i++)
		{
			PrintRow(i, n);
		}
		for (int j = n-1; j >=0; j--)
		{
			PrintRow(j, n);
		}
    }
		
	private static void PrintRow(int i, int n)
	{
		// TOP 

		// printing spaces before stars on the i row
		for (int j=1; j <= n-i; j++)
		{
			Console.Write(" ");
		}
			

		// printing stars after spaces 
		for (int k = 0; k < i; k++)
		{
			Console.Write("* ");
		}
		Console.WriteLine();
			
	}
}

