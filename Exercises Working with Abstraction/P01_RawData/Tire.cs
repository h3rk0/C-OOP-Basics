using System;
using System.Collections.Generic;
using System.Text;


public class Tire
{
	public decimal tirePressure { get; set; }
	public int tireAge { get; set; }
	public Tire(decimal tirePressure,int tireAge)
	{
		this.tirePressure = tirePressure;
		this.tireAge = tireAge;
	}
}

