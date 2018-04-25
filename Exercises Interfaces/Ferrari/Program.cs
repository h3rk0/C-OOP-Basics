using System;


class Program
{
    static void Main(string[] args)
    {
	    string driver = Console.ReadLine();

		Icar ferrari = new Ferrari("488-Spider",driver);

	    Console.WriteLine(ferrari);
    }
}

