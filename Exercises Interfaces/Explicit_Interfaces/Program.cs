using System;


class Program
{
    static void Main(string[] args)
    {


		while (true)
		{
			string input = Console.ReadLine();

			if(input == "End")
			{
				break;
			}

			string[] inputArgs = input.Split();
			string name = inputArgs[0];
			string country = inputArgs[1];
			int age = int.Parse(inputArgs[2]);
			Citizen citizen = new Citizen(name,country,age);
			Console.WriteLine(((IPerson)citizen).GetName());
			Console.WriteLine(((IResident)citizen).GetName());

		}
    }
}

