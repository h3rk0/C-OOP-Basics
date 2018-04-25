using System;
using System.Collections.Generic;
using System.Text;


public class Square
{

	private int size;

	public Square(int size)
	{
		this.Size = size;
	}

	public int Size
	{
		get { return size; }
		set { size = value; }
	}

	public void Draw()
	{
		for (int row = 0; row < this.size; row++)
		{
			Console.Write("|");
			if (row == 0 || row == this.size - 1)
			{
				for (int col = 0; col < this.size; col++)
				{
					Console.Write("-");
				}
			}
			else
			{
				for (int col = 0; col < this.size; col++)
				{
					Console.Write(" ");
				}
			}
			Console.Write("|");
			Console.WriteLine();
		}
	}
}

