using System;
using System.Collections.Generic;
using System.Text;


public class Tesla : ICar , IElectricCar
{
	public string Model { get; }
	public string Color { get; }
	public int Battery { get; }

	public Tesla(string model,string color,int battery)
	{
		this.Model = model;
		this.Color = color;
		this.Battery = battery;
	}

	public string Start()
	{
		return "Engine start";
	}

	public string Stop()
	{
		return "Breaaak!";
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries")
			.AppendLine(this.Start())
			.AppendLine(this.Stop());

		return sb.ToString().Trim();
	}

}

