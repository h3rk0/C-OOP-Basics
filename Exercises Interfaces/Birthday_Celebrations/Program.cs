using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
	    int count = int.Parse(Console.ReadLine());

		List<Humanoid> humanoids = new List<Humanoid>();

	    for (int personIndex = 0; personIndex < count; personIndex++)
	    {
		    string[] args = System.Console.ReadLine().Split().ToArray();

		    Humanoid humanoid;

		    if (args.Length == 4)
		    {
				humanoid = new Citizen(args[0], int.Parse(args[1]), args[2], args[3]);
		    }
		    else
			{
				humanoid =new Rebel(args[0], int.Parse(args[1]), args[2]);
			}
			
			humanoids.Add(humanoid);
	    }

	    while (true)
	    {
		    string input = Console.ReadLine();

		    if (input == "End")
		    {
			    break;
		    }
			
		    Humanoid humanoid = humanoids.SingleOrDefault(p => p.Name == input);
		    if (humanoid == null)
		    {
				continue;
		    }

		    IBuyer convertedBuyer = (IBuyer) humanoid;
			convertedBuyer.BuyFood();

	    }

	    int totalAmount = humanoids.Select(h => (IBuyer)h).Sum(h => h.Food);
	    Console.WriteLine(totalAmount);
    }
}

