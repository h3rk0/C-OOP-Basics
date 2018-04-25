using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
	public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
		:base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
	{
	}

	public override void Refuel(double fuel)
	{
		base.Refuel(fuel * 0.95);

	}
}

