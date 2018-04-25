using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Person> persons = new List<Person>();

		while (true)
		{
			string input = Console.ReadLine();

			if(input=="End")
			{
				break;
			}

			string[] args = input
				.Split(' ')
				.ToArray();

			// person name
			string personString = args[0];

			// initializing instance of person
			Person person = persons.SingleOrDefault(p => p.Name == personString);
			if(person==null)
			{
				person = new Person(personString);
				persons.Add(person);
			}

			// command
			string command = args[1];

			// company
			if(command=="company")
			{
				string companyName = args[2];
				string companyDepartment = args[3];
				decimal salary = decimal.Parse(args[4]);

				Company company = new Company(companyName, companyDepartment, salary);

				person.Company = company;
			}

			// car 
			if(command == "car")
			{
				string carModel = args[2];
				decimal carSpeed = decimal.Parse(args[3]);

				Car car = new Car(carModel, carSpeed);

				person.Car = car;
			}

			// pokemon
			if (command == "pokemon")
			{
				string pokemonName = args[2];
				string pokemonTypes = args[3];

				Pokemon pokemon = new Pokemon(pokemonName, pokemonTypes);

				if(!person.Pokemons.Contains(pokemon))
				{
					person.Pokemons.Add(pokemon);
				}
				
			}

			// parents
			if (command == "parents")
			{
				string parentName = args[2];
				string parentBirthDay = args[3];

				Parent parent = new Parent(parentName, parentBirthDay);

				if (!person.Parents.Contains(parent))
				{
					person.Parents.Add(parent);
				}

			}

			// children
			if (command == "children")
			{
				string childName = args[2];
				string childBirthDay = args[3];

				Child child = new Child(childName, childBirthDay);

				if (!person.Children.Contains(child))
				{
					person.Children.Add(child);
				}

			}
		}

		string personName = Console.ReadLine();

		Person final = persons.SingleOrDefault(p => p.Name == personName);

		Console.WriteLine(final);
		
    }
}

