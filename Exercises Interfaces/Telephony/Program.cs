using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
		Smartphone phone = new Smartphone();


	    string[] numbers = Console.ReadLine()
		    .Split()
		    .ToArray();

	    string[] links = Console.ReadLine()
		    .Split()
		    .ToArray();

	    foreach (var number in numbers)
	    {
		    Console.WriteLine(phone.Call(number));
	    }

	    foreach (var link in links)
	    {
		    Console.WriteLine(phone.Browse(link));
	    }
    }
}

