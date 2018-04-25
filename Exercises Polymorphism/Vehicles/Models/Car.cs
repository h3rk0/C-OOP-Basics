using System;
using System.Collections.Generic;
using System.Text;


class Car : Vehicle
{
	private double tankCapacity { get; set; }

	public Car(double fuelQuantity, double fuelConsumption) 
		:base(fuelQuantity, fuelConsumption + 0.9)
	{

	}
	
}

