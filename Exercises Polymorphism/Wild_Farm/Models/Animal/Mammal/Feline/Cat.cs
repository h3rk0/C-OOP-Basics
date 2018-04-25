using System;
using System.Collections.Generic;
using System.Text;



public class Cat : Feline
{
	public Cat(string name, double weight, string livingRegion, string breed)
		:base(name, weight, livingRegion, breed)
	{
	}

	public override string ProduceSound()
	{
		return "Meow";
	}

	public override string Eat(Food food)
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine(base.Eat(food));

		if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
		{
			sb.AppendLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
		}
		else
		{
			this.Weight += 0.30 * food.Quantity;

			this.FoodEaten += food.Quantity;
		}

		return sb.ToString().Trim();
	}
}

