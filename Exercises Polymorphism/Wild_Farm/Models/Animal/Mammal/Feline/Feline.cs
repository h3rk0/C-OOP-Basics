﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline : Mammal , IFeline
{
	private string breed { get; set; }

	public Feline(string name, double weight, string livingRegion,string breed)
		:base(name, weight, livingRegion)
	{
		this.Breed = breed;
	}

	public string Breed
	{
		get
		{
			return this.breed;
		}
		set
		{
			this.breed = value;
		}
	}

	public override string ToString()
	{
		return $"{this.GetType().Name} [{this.Name}, {this.breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
	}
}

