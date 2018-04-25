using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
	public string model;

	public Engine engine { get; set; }
	public Cargo cargo { get; set; }
	public Tire[] tires { get; set; }

	public Car(string model, Engine engine, Cargo cargo,Tire tireOne,Tire tireTwo,Tire tireThree,Tire tireFour)
	{
		this.model = model;
		this.engine = engine;
		this.cargo = cargo;
		this.tires = new Tire[4] {tireOne,tireTwo,tireThree,tireFour};
	}
	
}
