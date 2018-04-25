using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
	private const int baseCalories = 2;

	private double weight;
	private string type;
	private List<string> validTypes;
	public double Calories => Calculate();

	private Topping()
	{
		this.validTypes = new List<string>();
		this.validTypes.Add("meat");
		this.validTypes.Add("veggies");
		this.validTypes.Add("cheese");
		this.validTypes.Add("sauce");

	}

	public Topping(string type,double weight)
		:this()
	{
		this.Type = type;
		this.Weight = weight;
	}

	private double Weight
	{
		get { return weight; }
		set
		{
			if (value < 1 || value > 50)
			{
				throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
			}
			weight = value;
		}
	}
	
	private string Type
	{
		get { return type; }
		set
		{
			if (!validTypes.Contains(value.ToLower()))
			{
				throw new ArgumentException($"Cannot place {value} on top of your pizza.");
			}
			type = value;
		}
	}

	private double Calculate()
	{
		double typeModifier;

		if(this.Type.ToLower()=="meat")
		{
			typeModifier = 1.2;
		}
		else if (this.Type.ToLower() == "veggies")
		{
			typeModifier = 0.8;
		}
		else if (this.Type.ToLower() == "cheese")
		{
			typeModifier = 1.1;
		}
		else
		{
			typeModifier = 0.9;
		}

		return baseCalories * this.Weight * typeModifier;
	}

}

