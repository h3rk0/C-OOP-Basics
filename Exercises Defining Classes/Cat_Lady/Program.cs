using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		List<Cat> cats = new List<Cat>();

		while (true)
		{
			string input = Console.ReadLine();

			if (input == "End")
			{
				break;
			}


			string[] args = input.Split(' ').ToArray();
			string breed = args[0];
			string name = args[1];

			if (breed == "StreetExtraordinaire")
			{
				StreetExtraordinaire cat = new StreetExtraordinaire(name, int.Parse(args[2]));
				cats.Add(cat);
			}
			else if (breed == "Siamese")
			{
				Siamese cat = new Siamese(name, int.Parse(args[2]));
				cats.Add(cat);
			}
			else if (breed == "Cymric")
			{
				Cymric cat = new Cymric(name, decimal.Parse(args[2]));
				cats.Add(cat);
			}
		}
		// after while

		string resultName = Console.ReadLine();

		Cat resultCat = cats.SingleOrDefault(c => c.Name == resultName);

		Console.WriteLine(resultCat);
	}
}

