using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    class Program
    {
        static void Main()
        {
	        List<IBirthDate> creatures = new List<IBirthDate>();

	        while (true)
	        {
		        string input = Console.ReadLine();

		        if (input == "End")
		        {
			        break;
		        }

		        string[] args = input.Split().ToArray();
		        IBirthDate person;

		        if (args[0] == "Citizen")
		        {
			        person = new Citizen(args[1], int.Parse(args[2]), args[3], args[4]);
			        creatures.Add(person);
		        }
		        else if (args[0] == "Pet")
		        {
			        person = new Pet(args[1], args[2]);
			        creatures.Add(person);
		        }


	        }

	        string birthDate = Console.ReadLine();

	        foreach (var creature in creatures)
	        {
		        if (creature.BirthDate.EndsWith(birthDate))
			        Console.WriteLine(creature.BirthDate);
	        }
		}
    }
}
