using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
		int[] rectangleArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

		Point rectangleTopLeft = new Point(rectangleArgs[0], rectangleArgs[1]);

		Point rectangleBottomRight = new Point(rectangleArgs[2], rectangleArgs[3]);

		Rectangle rectangle = new Rectangle(rectangleTopLeft, rectangleBottomRight);

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			int[] pointArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Point point = new Point(pointArgs[0], pointArgs[1]);

			Console.WriteLine(rectangle.Contains(point));
		}
    }
}

