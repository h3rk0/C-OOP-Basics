using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
	public Tiger(string name, double weight, string livingRegion, string breed)
		:base(name, weight, livingRegion, breed)
	{
	}

	public override string ProduceSound()
	{
		return "ROAR!!!";
	}

	public override string Eat(Food food)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(base.Eat(food));

		if (food.GetType().Name != "Meat")
		{
			sb.AppendLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
		}
		else
		{
			this.Weight += 1.00 * food.Quantity;

			this.FoodEaten += food.Quantity;
		}

		return sb.ToString().Trim();
	}
}

