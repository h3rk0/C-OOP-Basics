using System;
using System.Linq;

class Program
{
    static void Main()
    {

		Team team = new Team("SoftUni");

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string[] args = Console.ReadLine().Split().ToArray();
			try
			{
				Person person = new Person(args[0], args[1], int.Parse(args[2]), decimal.Parse(args[3]));
				team.AddPlayer(person);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
		}
		Console.WriteLine($"First team has {team.FirstTeam.Count} players");

		Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");

	}
}

