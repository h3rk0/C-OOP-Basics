using System;
using System.Collections.Generic;
using System.Text;

public class Tire
{
	private decimal pressure;
	private int age;

	public Tire(decimal pressure,int age)
	{
		this.Pressure = pressure;
		this.Age = age;
	}

	public decimal Pressure
	{
		get { return pressure; }
		set { pressure = value; }
	}
	
	public int Age
	{
		get { return age; }
		set { age = value; }
	}

}

