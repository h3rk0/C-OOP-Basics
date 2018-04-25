using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
	private string name;
	private Dough dough;
	private List<Topping> toppings;
	private double totalToppingsCalories => this.Toppings.Sum(t => t.Calories);

	public Pizza(string name)
	{
		this.Name = name;
		this.Toppings = new List<Topping>();
	}


	public int toppingsCount => this.Toppings.Count;
	public double TotalCalories => totalToppingsCalories + this.Dough.Calories;

	public string Name
	{
		get { return name; }
		set
		{
			if (value.Length < 1 || value.Length > 15)
			{
				throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
			}
			name = value;
		}
	}
	
	public Dough Dough
	{
		private get { return dough; }
		set { dough = value; }
	}
	
	private List<Topping> Toppings
	{
		get { return toppings; }
		set { toppings = value; }
	}

	public void AddTopping(Topping topping)
	{
		if (this.Toppings.Count == 10)
		{
			throw new ArgumentException("Number of toppings should be in range [0..10].");
		}
		this.Toppings.Add(topping);
	}


}

