using System;


class Program
{
    static void Main(string[] args)
    {
		string firstDate = Console.ReadLine();
		string secondDate = Console.ReadLine();

		int days = DateModifier.CalculateDifference(firstDate, secondDate);

		Console.WriteLine(days);
    }
}

