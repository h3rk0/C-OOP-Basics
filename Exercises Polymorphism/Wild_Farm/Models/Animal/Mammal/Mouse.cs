using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
	public Mouse(string name, double weight, string livingRegion)
		:base(name, weight, livingRegion)
	{
	}

	public override string ProduceSound()
	{
		return "Squeak";
	}

	public override string Eat(Food food)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(base.Eat(food));

		if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
		{
			sb.AppendLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
		}
		else
		{
			this.Weight += 0.10 * food.Quantity;
			this.FoodEaten += food.Quantity;
		}

		return sb.ToString().Trim();
	}
}

