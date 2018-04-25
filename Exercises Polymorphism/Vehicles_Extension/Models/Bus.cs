using System;
using System.Collections.Generic;
using System.Text;


public class Bus : Vehicle , IBus
{
	public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
		:base(fuelQuantity, fuelConsumption, tankCapacity)
	{
	}

	public string DriveWithPassengers(double distance)
	{
		this.FuelConsumption += 1.4;
		string result =base.Drive(distance);
		this.FuelConsumption -= 1.4;
		return result;
	}
}

