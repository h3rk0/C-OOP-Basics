using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Rectangle> rectangles = new List<Rectangle>();

		int[] args = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToArray();

		int n = args[0];
		int m = args[1];

		for (int i = 0; i < n; i++)
		{
			string[] inputArr = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			string id = inputArr[0];

			double width = double.Parse(inputArr[1]);
			double height = double.Parse(inputArr[2]);
			double row = double.Parse(inputArr[3]);
			double col = double.Parse(inputArr[4]);

			Rectangle rectangle = new Rectangle(id,width,height,row,col);

			if(!rectangles.Contains(rectangle))
			{
				rectangles.Add(rectangle);
			}
			
		}

		for (int i = 0; i < m; i++)
		{
			string[] intersectThoose = Console.ReadLine()
				.Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			string first = intersectThoose[0];
			string second = intersectThoose[1];
			

			Rectangle firstRectangle = rectangles.SingleOrDefault(r => r.Id == first);
			Rectangle secondRectangle = rectangles.SingleOrDefault(r => r.Id == second);

			if(firstRectangle.CheckIntersection(secondRectangle))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
		}
    }
}

