using System;
using System.Collections.Generic;
using System.Text;


public class Cat
{
	private string name;

	public Cat(string name)
	{
		this.Name = name;
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

}

public class Cymric : Cat
{
	private decimal furLenght;

	public decimal FurLenght
	{
		get { return furLenght; }
		set { furLenght = value; }
	}

	public Cymric(string name, decimal furLenght)
		: base(name)
	{
		this.FurLenght = furLenght;
	}

	public override string ToString()
	{
		return $"Cymric {this.Name} {this.FurLenght:f2}";
	}
}

public class Siamese : Cat
{
	private int earSize;

	public Siamese(string name, int earSize)
		: base(name)
	{
		this.EarSize = earSize;
	}

	public int EarSize
	{
		get { return earSize; }
		set { earSize = value; }
	}

	public override string ToString()
	{
		return $"Siamese {this.Name} {this.EarSize}";
	}
}

public class StreetExtraordinaire : Cat
{
	private int decibels;

	public StreetExtraordinaire(string name, int decibels)
		: base(name)
	{
		this.Decibels = decibels;
	}

	public int Decibels
	{
		get { return decibels; }
		set { decibels = value; }
	}

	public override string ToString()
	{
		return $"StreetExtraordinaire {this.Name} {this.Decibels}";
	}

}