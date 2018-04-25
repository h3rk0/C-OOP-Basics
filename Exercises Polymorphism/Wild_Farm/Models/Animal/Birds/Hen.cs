﻿using System;
using System.Collections.Generic;
using System.Text;


public class Hen : Bird
{
	public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
	{
	}

	public override string ProduceSound()
	{
		return "Cluck";
	}

	public override string Eat(Food food)
	{
		this.Weight += 0.35*food.Quantity;
		this.FoodEaten += food.Quantity;
		return base.Eat(food);
	}
}

