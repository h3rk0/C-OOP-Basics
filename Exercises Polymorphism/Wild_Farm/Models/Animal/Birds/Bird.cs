using System;
using System.Collections.Generic;
using System.Text;


public abstract class Bird : Animal , IBird
{
	private double wingSize { get; set; }

	public Bird(string name, double weight,double wingSize) : base(name, weight)
	{
		this.WingSize = wingSize;
	}

	public double WingSize
	{
		get
		{
			return this.wingSize;
		}
		set
		{
			this.wingSize = value;
		}
	}

	public override string ToString()
	{
		return $"{this.GetType().Name} [{this.Name}, {this.wingSize}, {this.Weight}, {this.FoodEaten}]";
	}
}

