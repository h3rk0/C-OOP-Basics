using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
	private string model;
	private decimal fuelAmount;
	private decimal fuelConsumption;
	private int distanceTraveled { get; set; } = 0;

	public Car(string name,int fuelAmount,decimal fuelConsumption)
	{
		this.Model = name;
		this.FuelAmount = fuelAmount;
		this.FuelConsumption = fuelConsumption;
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}
	
	public decimal FuelAmount
	{
		get { return fuelAmount; }
		set { fuelAmount = value; }
	}
	
	public decimal FuelConsumption
	{
		get { return fuelConsumption; }
		set { fuelConsumption = value; }
	}
	
	public int DistanceTraveled
	{
		get { return distanceTraveled; }
		set { distanceTraveled = value; }
	}

	public void TravelDistance(int amountOfKm)
	{
		decimal travelDistance = this.FuelAmount / this.FuelConsumption;
		decimal currentConsumption = amountOfKm * this.FuelConsumption;

		if(travelDistance>=amountOfKm)
		{
			this.FuelAmount -= currentConsumption;
			this.DistanceTraveled += amountOfKm;
		}
		else
		{
			Console.WriteLine($"Insufficient fuel for the drive");
		}
	}
	
}

