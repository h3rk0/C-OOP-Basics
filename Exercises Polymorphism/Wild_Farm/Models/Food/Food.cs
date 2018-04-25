using System;
using System.Collections.Generic;
using System.Text;


public abstract class Food : IFood
{
	private int quantity { get; set; }

	public Food(int quantity)
	{
		this.Quantity = quantity;
	}

	public int Quantity
	{
		get
		{
			return this.quantity;
		}
		set
		{
			this.quantity = value;
		}
	}
}

