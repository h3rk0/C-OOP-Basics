using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
	private Point topLeftPoint;
	private Point bottomRightPoint;

	public Rectangle(Point topLeftPoint,Point bottomRightPoint)
	{
		this.TopLeftPoint = topLeftPoint;
		this.BottomRightPoint = bottomRightPoint;
	}

	public Point TopLeftPoint
	{
		get { return topLeftPoint; }
		set { topLeftPoint = value; }
	}
	
	public Point BottomRightPoint
	{
		get { return bottomRightPoint; }
		set { bottomRightPoint = value; }
	}

	public bool Contains(Point point)
	{
		if(this.topLeftPoint.X <= point.X && point.X <=this.bottomRightPoint.X
			&& this.topLeftPoint.Y <= point.Y && point.Y <= this.bottomRightPoint.Y)
		{
			return true;
		}
		return false;
		
	}


}

