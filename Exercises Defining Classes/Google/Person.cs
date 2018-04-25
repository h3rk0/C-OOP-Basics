using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
	private string name;
	private Company company;
	private List<Pokemon> pokemons;
	private List<Parent> parents;
	private List<Child> children;
	private Car car;

	public Person(string name)
	{
		this.Name = name;
		this.Company = null;
		this.Car = null;
		this.Parents = new List<Parent>();
		this.Children = new List<Child>();
		this.Pokemons = new List<Pokemon>();
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public Company Company
	{
		get { return company; }
		set { company = value; }
	}

	public List<Pokemon> Pokemons
	{
		get { return pokemons; }
		set { pokemons = value; }
	}

	public List<Parent> Parents
	{
		get { return parents; }
		set { parents = value; }
	}
	
	public List<Child> Children
	{
		get { return children; }
		set { children = value; }
	}
	
	public Car Car
	{
		get { return car; }
		set { car = value; }
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		//string company = this.Company.Name

		sb.AppendLine($"{this.Name}");

		sb.AppendLine($"Company:");
		if (this.Company != null)
		{
			sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
		}

		sb.AppendLine($"Car:");
		if (this.Car != null)
		{
			sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
		}

		sb.AppendLine($"Pokemon:");
		if (this.Pokemons.Count > 0) 
		{
			foreach (Pokemon pokemon in this.Pokemons)
			{
				sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
			}
		}

		sb.AppendLine($"Parents:");
		if (this.Parents.Count > 0)
		{
			foreach (Parent parent in this.Parents)
			{
				sb.AppendLine($"{parent.Name} {parent.BirthDay}");
			}
		}

		sb.AppendLine($"Children:");
		if (this.Children.Count > 0)
		{
			foreach (Child child in this.Children)
			{
				sb.AppendLine($"{child.Name} {child.BirthDay}");
			}
		}

		string result = sb.ToString();
		return result;
	}


}

