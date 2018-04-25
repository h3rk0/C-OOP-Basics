using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Team> teams = new List<Team>();

		while (true)
		{
			string input = Console.ReadLine();

			if (input == "END")
			{
				break;
			}

			try
			{
				string[] args = input.Split(';',StringSplitOptions.None);

				string command = args[0];

				if (command == "Team")
				{
					string teamName = args[1];

					Team team = new Team(teamName);

					teams.Add(team);
					continue;
				}

				if (command == "Add")
				{
					string teamName = args[1];

					Team team = teams.SingleOrDefault(t => t.Name == teamName);

					if (team == null)
					{
						Console.WriteLine($"Team {teamName} does not exist.");
						continue;
					}

					string playerName = args[2];
					//3 4 5 6 7

					int endurance = int.Parse(args[3]);
					int sprint = int.Parse(args[4]);
					int dribble = int.Parse(args[5]);
					int passing = int.Parse(args[6]);
					int shooting = int.Parse(args[7]);

					Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

					team.AddPlayer(player);

					continue;
				}

				if (command == "Remove")
				{
					string teamName = args[1];

					Team team = teams.SingleOrDefault(t => t.Name == teamName);

					if (team == null)
					{
						Console.WriteLine($"Team {teamName} does not exist.");
						continue;
					}

					string playerName = args[2];

					team.RemovePlayer(playerName);
					continue;
				}

				if (command == "Rating")
				{
					string teamName = args[1];

					Team team = teams.SingleOrDefault(t => t.Name == teamName);

					if (team == null)
					{
						Console.WriteLine($"Team {teamName} does not exist.");
						continue;
					}

					Console.WriteLine($"{teamName} - {team.Rating}");
				}
			}
			catch (Exception e)
			{
				
				Console.WriteLine(e.Message);
				
			}

			
		}
    }
}

