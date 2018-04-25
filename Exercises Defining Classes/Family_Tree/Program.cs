using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Person> familyTree = new List<Person>();

		string mainPersonString = Console.ReadLine();

		Person mainPerson = new Person();

		if(Char.IsDigit(mainPersonString[0]))
		{
			mainPerson.BirthDay = mainPersonString;
		}
		else
		{
			mainPerson.Name = mainPersonString;
		}

		familyTree.Add(mainPerson);

		while(true)
		{
			string input = Console.ReadLine();

			if (input == "End")
			{
				break;
			}

			string[] args = input.Split(new string[] { " - " },StringSplitOptions.RemoveEmptyEntries).ToArray();

			if (args.Length > 1) 
			{
				// 11/11/1951 - 23/5/1980
				// Penka Pesheva - 23/5/1980
				// 4/4/1961 - Moncho Tonchev
				Person parent;
				Person child;

				// initializing parent
				if(IsBirthDay(args[0]))
				{
					parent = familyTree.SingleOrDefault(p => p.BirthDay == args[0]);

					if (parent == null)
					{
						parent = new Person();

						parent.BirthDay = args[0];
						familyTree.Add(parent);
					}
				}
				else
				{
					parent = familyTree.SingleOrDefault(p => p.Name == args[0]);

					if (parent == null)
					{
						parent = new Person();

						parent.Name = args[0];
						familyTree.Add(parent);
					}

				}

				// Initializing child
				if(IsBirthDay(args[1]))
				{
					child = familyTree.SingleOrDefault(p => p.BirthDay == args[1]);

					if (child == null)
					{
						child = new Person();

						child.BirthDay = args[1];
						familyTree.Add(child);
					}
				}
				else
				{
					child = familyTree.SingleOrDefault(p => p.Name == args[1]);

					if (child == null)
					{
						child = new Person();

						child.Name = args[1];
						familyTree.Add(child);
					}
				}

				parent.Children.Add(child);
				child.Parents.Add(parent);
			}
			else
			{
				string[] argsSecondCase = args[0].Split().ToArray();

				string name = $"{argsSecondCase[0]} {argsSecondCase[1]}";

				string birthDay = argsSecondCase[2];

				Person personWithName = familyTree.SingleOrDefault(p => p.Name == name);
				Person personWithAge = familyTree.SingleOrDefault(p => p.BirthDay == birthDay);

				if (personWithName != null && personWithAge != null)
				{
					

					personWithName.BirthDay = birthDay;
					personWithName.Name = name;
					foreach (var child in personWithAge.Children)
					{
						personWithName.Children.Add(child);
					}
					//personWithName.Children.AddRange(personWithAge.Children);
					foreach (var parent in personWithAge.Parents)
					{
						personWithName.Parents.Add(parent);
					}
					//personWithName.Parents.AddRange(personWithAge.Parents);
					personWithAge.Name = name;
					personWithAge.BirthDay = birthDay;

					if(mainPerson.BirthDay==personWithName.BirthDay||mainPerson.Name==personWithName.Name)
					{
						mainPerson = personWithName;
						familyTree.Remove(personWithName);
					}
				}
				else if (personWithName == null && personWithAge != null)
				{
					personWithAge.Name = name;
				}
				else if (personWithName != null && personWithAge == null)
				{
					personWithName.BirthDay = birthDay;
				}
				
			}
			
		}
		// after while

		Console.WriteLine($"{mainPerson.Name} {mainPerson.BirthDay}");
		Console.WriteLine("Parents:");
		foreach (var parent in mainPerson.Parents)
		{
			Console.WriteLine($"{parent.Name} {parent.BirthDay}");
		}
		Console.WriteLine("Children:");
		foreach (var child in mainPerson.Children)
		{
			Console.WriteLine($"{child.Name} {child.BirthDay}");
		}
	}

	private static bool IsBirthDay(string personInfo)
	{

		return (Char.IsDigit(personInfo[0]));
	}
}
