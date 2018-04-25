using System;


class Program
{
    static void Main(string[] args)
    {
		string shape = Console.ReadLine();

		if(shape=="Square")
		{
			int size = int.Parse(Console.ReadLine());

			Square square = new Square(size);

			square.Draw();
		}
		if (shape == "Rectangle")
		{
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			Rectangle rectangle = new Rectangle(width,height);

			rectangle.Draw();
		}
	}
}
