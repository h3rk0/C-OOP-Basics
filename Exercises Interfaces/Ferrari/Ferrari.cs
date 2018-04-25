using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : Icar
{
	public string Model { get; }
	public string Driver { get; }

	public Ferrari(string model,string driver)
	{
		this.Model = model;
		this.Driver = driver;
	}

	public string Brakes()
	{
		return "Brakes!";
	}

	public string Gas()
	{
		return "Zadu6avam sA!";
	}

	public override string ToString()
	{
		return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
	}
}

