using System;
using System.Collections.Generic;
using System.Text;

public class Trainer
{
	private string name;
	private int badges = 0;
	public ICollection<Pokemon> pokemons { get; set; }

	public Trainer(string name)
	{
		this.Name = name;
		this.pokemons = new List<Pokemon>();
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public int Badges
	{
		get { return badges; }
		set { badges = value; }
	}

	public void AddPokemon(Pokemon pokemon)
	{
		this.pokemons.Add(pokemon);
	}

	
}

