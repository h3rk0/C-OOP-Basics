using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Mammal
{
	public Dog(string name, double weight, string livingRegion)
		:base(name, weight,livingRegion)
	{
	}

	public override string ProduceSound()
	{
		return "Woof!";
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
			this.Weight += 0.40 * food.Quantity;

			this.FoodEaten += food.Quantity;
		}

		return sb.ToString().Trim();
	}
}

