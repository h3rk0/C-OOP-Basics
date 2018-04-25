using System;
using System.Collections.Generic;
using System.Text;


public class Owl : Bird
{
	public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
	{
	}

	public override string ProduceSound()
	{
		return "Hoot Hoot";
	}

	public override string Eat(Food food)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(base.Eat(food));

		if(food.GetType().Name!="Meat")
		{
			sb.AppendLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
		}
		else
		{
			this.Weight += 0.25 * food.Quantity;

			this.FoodEaten += food.Quantity;
		}

		return sb.ToString().Trim();
	}
}

