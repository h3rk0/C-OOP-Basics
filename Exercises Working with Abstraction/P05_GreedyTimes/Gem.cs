using System;
using System.Collections.Generic;
using System.Text;


public class Gem
{
	private string name;
	private long amount;

	public Gem(string name, long amount)
	{
		this.Name = name;
		this.Amount = amount;
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public long Amount
	{
		get { return amount; }
		set { amount = value; }
	}
}

