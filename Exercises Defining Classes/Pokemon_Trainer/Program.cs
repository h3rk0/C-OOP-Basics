using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

		List<Trainer> trainers = new List<Trainer>();
		while (true)
		{
			string command = Console.ReadLine();

			if(command=="Tournament")
			{
				break;
			}

			string[] commandArgs = command.Split(' ').ToArray();

			if (commandArgs.Length == 1)
			{

			}
			else
			{
				string trainerName = commandArgs[0];

				Trainer trainer = trainers.SingleOrDefault(t => t.Name == trainerName);

				if(trainer == null)
				{
					trainer = new Trainer(trainerName);
					trainers.Add(trainer);
				}

				string pokemonName = commandArgs[1];

				string pokemonElement = commandArgs[2];

				int pokemonHealth = int.Parse(commandArgs[3]);

				Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

				trainer.AddPokemon(pokemon);
				
			}
			
		}
		
		while (true)
		{
			string tournament = Console.ReadLine();

			if(tournament=="End")
			{
				break;
			}

			if(tournament=="Fire")
			{
				foreach (Trainer trainer in trainers)
				{
					if(trainer.pokemons.Any(p => p.Element=="Fire"))
					{
						trainer.Badges++;
					}
					else
					{
						Pokemon[] trainerPokemons = trainer.pokemons.ToArray();

						for (int p = 0; p < trainerPokemons.Length; p++)
						{
							trainerPokemons[p].Health -= 10;
							if(trainerPokemons[p].Health<=0)
							{
								trainer.pokemons.Remove(trainerPokemons[p]);
							}
						}
					}
				}
			}
			else if (tournament == "Water")
			{
				foreach (Trainer trainer in trainers)
				{
					if (trainer.pokemons.Any(p => p.Element == "Water"))
					{
						trainer.Badges++;
					}
					else
					{
						Pokemon[] trainerPokemons = trainer.pokemons.ToArray();

						for (int p = 0; p < trainerPokemons.Length; p++)
						{
							trainerPokemons[p].Health -= 10;
							if (trainerPokemons[p].Health <= 0)
							{
								trainer.pokemons.Remove(trainerPokemons[p]);
							}
						}
					}
				}
			}
			else if (tournament == "Electricity")
			{
				foreach (Trainer trainer in trainers)
				{
					if (trainer.pokemons.Any(p => p.Element == "Electricity"))
					{
						trainer.Badges++;
					}
					else
					{
						Pokemon[] trainerPokemons = trainer.pokemons.ToArray();

						for (int p = 0; p < trainerPokemons.Length; p++)
						{
							trainerPokemons[p].Health -= 10;
							if (trainerPokemons[p].Health <= 0)
							{
								trainer.pokemons.Remove(trainerPokemons[p]);
							}
						}
					}
				}
			}
			
		}

		Trainer[] sorted = trainers.OrderByDescending(t => t.Badges).ToArray();

		foreach (Trainer trainer in sorted)
		{
			Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.pokemons.Count}");
		}
	}
}

