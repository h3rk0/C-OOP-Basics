using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal : IAnimal , IProduceSound , IEat
{
	public Animal(string name,double weight)
	{
		this.Name = name;
		this.Weight = weight;
		this.FoodEaten = 0;
	}

	public string Name { get; protected set; }

	public double Weight { get; protected set; }

	public int FoodEaten { get; protected set; }

	public virtual string Eat(Food food)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(this.ProduceSound());
		return sb.ToString().Trim();
	}

	public abstract string ProduceSound();
}

