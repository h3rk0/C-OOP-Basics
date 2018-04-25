using System;
using System.Collections.Generic;
using System.Text;



public abstract class Vehicle : IVehicle , ITankCapacity
{
	private double fuelConsumption { get; set; }
	private double fuelQuantity { get; set; }
	private double tankCapacity { get; set; }

	public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
	{
		this.FuelQuantity = SetFuelQuantity(tankCapacity,fuelQuantity);
		this.FuelConsumption = fuelConsumption;
		this.TankCapacity = tankCapacity;
	}

	private double SetFuelQuantity(double tankCapacity, double fuelQuantity)
	{
		if(fuelQuantity>tankCapacity)
		{
			return 0;
		}

		return fuelQuantity;
	}

	public double FuelQuantity
	{
		get
		{
			return this.fuelQuantity;
		}
		protected set
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
		protected set
		{
			this.fuelConsumption = value;
		}
	}

	public double TankCapacity
	{
		get
		{
			return this.tankCapacity;
		}
		protected set
		{
			this.tankCapacity = value;
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
		if (fuel <= 0)
		{
			Console.WriteLine($"Fuel must be a positive number");
			return;
		}

		if (this.fuelQuantity + fuel > this.TankCapacity) 
		{
			if(this.GetType().Name=="Truck")
			{
				Console.WriteLine($"Cannot fit {fuel / 19 * 20} fuel in the tank");
				return;
			}

			Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
			return;
		}

		this.FuelQuantity += fuel;
	}

	public override string ToString()
	{
		return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
	}
}

