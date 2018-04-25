using System;
using System.Collections.Generic;
using System.Text;


public class Dough
{
	private const int baseCalories = 2;

	private string flourType;
	private string bakingTechnique;
	private double weight;

	private List<string> validFlourTypes;
	private List<string> validBakingTechniques;

	private Dough()
	{
		this.validFlourTypes = new List<string>();
		this.validFlourTypes.Add("white");
		this.validFlourTypes.Add("wholegrain");
		this.validBakingTechniques = new List<string>();
		this.validBakingTechniques.Add("crispy");
		this.validBakingTechniques.Add("chewy");
		this.validBakingTechniques.Add("homemade");
	}

	public Dough(string flourType, string bakingTechnique, double weight)
		:this()
	{
		this.FlourType = flourType;
		this.BakingTechnique = bakingTechnique;
		this.Weight = weight;
	}

	public double Calories => CalculateCalories();

	private string FlourType
	{
		get { return flourType; }
		set
		{
			if(!validFlourTypes.Contains(value.ToLower()))
			{
				throw new ArgumentException("Invalid type of dough.");
			}

			flourType = value;
		}
	}

	private string BakingTechnique
	{
		get { return bakingTechnique; }
		set
		{
			if (!validBakingTechniques.Contains(value.ToLower()))
			{
				throw new ArgumentException("Invalid type of dough.");
			}
			bakingTechnique = value;
		}
	}

	private double Weight
	{
		get { return weight; }
		set
		{
			if (value < 1 || value > 200)
			{
				throw new ArgumentException("Dough weight should be in the range [1..200].");
			}
			weight = value;
		}
	}

	private double CalculateCalories()
	{
		double result;
		double flourModifier;
		double techniqueModifier;

		if(this.FlourType.ToLower()=="white")
		{
			flourModifier = 1.5;
		}
		else
		{
			flourModifier = 1.0;
		}

		if(this.BakingTechnique.ToLower()=="chewy")
		{
			techniqueModifier = 1.1;
		}
		else if(this.BakingTechnique.ToLower()=="crispy")
		{
			techniqueModifier = 0.9;
		}
		else
		{
			techniqueModifier = 1.0;
		}

		result = this.weight * baseCalories * flourModifier * techniqueModifier;
		return result;
	}
}

