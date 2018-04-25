using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
	private string model;
	private Engine engine;
	private Cargo cargo;
	private Tire tireOne;
	private Tire tireTwo;
	private Tire tireThree;
	private Tire tireFour;

	public Car(string model,Engine engine,Cargo cargo,Tire tireOne,Tire tireTwo,Tire tireThree,Tire tireFour)
	{
		this.Model = model;
		this.Engine = engine;
		this.Cargo = cargo;
		this.TireOne = tireOne;
		this.TireTwo = tireTwo;
		this.TireThree = tireThree;
		this.TireFour = tireFour;
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}
	
	public Engine Engine
	{
		get { return engine; }
		set { engine = value; }
	}
	
	public Cargo Cargo
	{
		get { return cargo; }
		set { cargo = value; }
	}
	
	public Tire TireOne
	{
		get { return tireOne; }
		set { tireOne = value; }
	}
	
	public Tire TireTwo
	{
		get { return tireTwo; }
		set { tireTwo = value; }
	}
	
	public Tire TireThree
	{
		get { return tireThree; }
		set { tireThree = value; }
	}
	
	public Tire TireFour
	{
		get { return tireFour; }
		set { tireFour = value; }
	}


}

