using System;
using System.Collections.Generic;
using System.Text;


public abstract class Mammal : Animal, IMammal
{
	private string livingRegion { get; set; }


	public Mammal(string name, double weight,string livingRegion)
		:base(name, weight)
	{
		this.LivingRegion = livingRegion;
	}

	public string LivingRegion
	{
		get
		{
			return this.livingRegion;
		}
		set
		{
			this.livingRegion = value;
		}
	}

	public override string ToString()
	{
		return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.livingRegion}, {this.FoodEaten}]";
	}
}

