using System;
using System.Collections.Generic;
using System.Text;


public class DrawingTool
{
	private Rectangle rectangle;

	public Rectangle Rectangle
	{
		get { return rectangle; }
		set { rectangle = value; }
	}

	private Square square;

	public Square Square
	{
		get { return square; }
		set { square = value; }
	}



	public DrawingTool(Rectangle rectangle)
	{
		this.Rectangle = rectangle;
	}

	public DrawingTool(Square square)
	{
		this.Square = square;
	}
}

