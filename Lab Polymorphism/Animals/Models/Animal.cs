using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal : IAnimal
{
	public Animal(string name, string favouriteFood)
	{
		this.Name = name;
		this.FavouriteFood = favouriteFood;
	}


	public string Name { get; }

	public string FavouriteFood { get; }

	public virtual string ExplainSelf()
	{
		return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
	}
}

