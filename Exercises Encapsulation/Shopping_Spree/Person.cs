using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
	private string name;
	private decimal money;
	public List<Product> Products;

	public Person()
	{
		this.Products = new List<Product>();
	}

	public Person(string name,decimal money)
		:this()
	{
		this.Name = name;
		this.Money = money;

	}

	public string Name
	{
		get { return name; }
		set
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("Name cannot be empty");
			}
			name = value;
		}
	}

	
	public decimal Money
	{
		get { return money; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Money cannot be negative");
			}
			money = value;
		}
	}

	public void BuyProduct(Product product)
	{
		if (this.Money >= product.Cost) 
		{
			this.Money -= product.Cost;
			
			this.Products.Add(product);
			Console.WriteLine($"{this.Name} bought {product.Name}");
		}
		else
		{
			Console.WriteLine($"{this.Name} can't afford {product.Name}");
		}
	}

	public override string ToString()
	{
		return $"{this.name}";
	}
}

