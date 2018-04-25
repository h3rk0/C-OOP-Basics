using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
	private string id;
	private double width;
	private double height;
	private double row;
	private double col;

	public Rectangle(string id, double widht, double height, double row, double col)
	{
		this.Id = id;
		this.Width = widht;
		this.Height = height;
		this.Row = row;
		this.Col = col;
	}

	public string Id
	{
		get { return id; }
		set { id = value; }
	}
	
	public double Width
	{
		get { return width; }
		set { width = value; }
	}
	
	public double Height
	{
		get { return height; }
		set { height = value; }
	}
	
	public double Row
	{
		get { return row; }
		set { row = value; }
	}
	
	public double Col
	{
		get { return col; }
		set { col = value; }
	}

	public bool CheckIntersection(Rectangle secondRectangle)
	{
		//this. Rectangle
		double firstX1 = this.Row;
		double firstY1 = this.Col;
		double firstX2 = firstX1 + height;
		double firstY2 = firstY1 + width;

		//other Rectangle
		double secondX1 = secondRectangle.Row;
		double secondY1 = secondRectangle.Col;
		double secondX2 = secondX1 + secondRectangle.Height;
		double secondY2 = secondY1 + secondRectangle.Width;

		if((firstX1 <= secondX2) && (firstX2>= secondX1) && (firstY1<= secondY2) && (firstY2>=secondY1 ))
		{
			return true;
		}
		//if ((secondX2 >= firstX1 && secondX1<= firstX2) && (secondY2 >= firstY1 && secondY1 <=firstY2))
		//{
		//	return true;
		//}
		
		return false;
	}


}

