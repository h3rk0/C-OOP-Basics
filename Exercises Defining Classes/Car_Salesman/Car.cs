using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
	private string model;
	private Engine engine;
	private double weight;
	private string color;

	public Car(string model,Engine engine)
	{
		this.Model = model;
		this.Engine = engine;
	}

	public Car(string model, Engine engine, double weight)
		:this(model,engine)
	{
		this.Weight = weight;
	}

	public Car(string model, Engine engine, string color)
		:this(model,engine)
	{
		this.Color = color;
	}

	public Car(string model, Engine engine, double weight,string color)
		:this(model,engine,weight)
	{
		this.Color = color;
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
	
	public double Weight
	{
		get { return weight; }
		set { weight = value; }
	}
	
	public string Color
	{
		get { return color; }
		set { color = value; }
	}

	public override string ToString()
	{
		string missingWeight = this.Weight.ToString();
		if(missingWeight=="-1")
		{
			missingWeight = "n/a";
		}

		string missingDisplacement = this.Engine.Displacement.ToString();
		if(missingDisplacement=="-1")
		{
			missingDisplacement = "n/a";
		}

		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"{this.Model}:");
		sb.AppendLine($"  {this.Engine.Model}:");
		sb.AppendLine($"    Power: {this.Engine.Power}");
		sb.AppendLine($"    Displacement: {missingDisplacement}");
		sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
		sb.AppendLine($"  Weight: {missingWeight}");
		sb.Append($"  Color: {this.Color}");

		string result = sb.ToString();
		return result;
	}


}

