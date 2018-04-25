using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
		List<IIdentity> identities=new List<IIdentity>();


	    while (true)
	    {
		    string input = Console.ReadLine();

		    if (input == "End")
		    {
				break;
		    }

		    string[] args = input.Split().ToArray(); 

		    IIdentity smthg;

		    if (args.Length == 3)
		    {
			    string name = args[0];
			    int age = int.Parse(args[1]);
			    string id = args[2];
				smthg=new Citizen(name,age,id);
		    }
		    else
		    {
				string name = args[0];
			    string id = args[1];
				smthg= new Robot(name,id);
			}

			identities.Add(smthg);
	    }

	    string hackCode = Console.ReadLine();

	    foreach (var identity in identities)
	    {
		    if (identity.Id.EndsWith(hackCode))
		    {
			    Console.WriteLine(identity.Id);
		    }
	    }
    }
}

