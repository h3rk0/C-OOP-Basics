using System;
using System.Collections.Generic;
using System.Text;


public class Cash
{
	private string name;
	private long amount;

	public Cash(string name,long amount)
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

