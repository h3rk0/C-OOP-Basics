using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
	private int width;

	public int Width
	{
		get { return width; }
		set { width = value; }
	}

	private int height;

	public int Height
	{
		get { return height; }
		set { height = value; }
	}

	public Rectangle(int width,int height)
	{
		this.Width = width;
		this.Height = height;
	}

	public void Draw()
	{
		for (int row = 0; row < this.Height; row++)
		{
			Console.Write("|");
			if (row == 0 || row == this.Height - 1)
			{
				for (int col = 0; col < this.Width; col++)
				{
					Console.Write("-");
				}
			}
			else
			{
				for (int col = 0; col < this.Width; col++)
				{
					Console.Write(" ");
				}
			}
			Console.Write("|");
			Console.WriteLine();
		}
	}
}

