using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle : IVehicle
{
	private double fuelConsumption { get; set; }
	private double fuelQuantity { get; set; }

	public Vehicle(double fuelQuantity,double fuelConsumption)
	{
		this.FuelQuantity = fuelQuantity;
		this.FuelConsumption = fuelConsumption;
	}

	public double FuelQuantity
	{
		get
		{
			return this.fuelQuantity;
		}
		private set
		{
			this.fuelQuantity = value;
		}
	}

	public double FuelConsumption
	{
		get
		{
			return this.fuelConsumption;
		}
		private set
		{
			this.fuelConsumption = value;
		}
	}

	public virtual string Drive(double distance)
	{
		double estimatedFuelConsumption = distance * this.FuelConsumption;
		if(estimatedFuelConsumption > this.FuelQuantity)
		{
			return $"{this.GetType().Name} needs refueling";
		}

		this.FuelQuantity -= estimatedFuelConsumption;
		
		return $"{this.GetType().Name} travelled {distance} km";
	}

	public virtual void Refuel(double fuel)
	{
		this.FuelQuantity += fuel;
	}

	public override string ToString()
	{
		return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
	}
}

