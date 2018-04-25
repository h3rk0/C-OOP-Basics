using System;
using System.Collections.Generic;
using System.Text;


public class Rebel : Humanoid , IAge , IBuyer
{

	public int Age { get; }
	private string group;
	public int Food { get; private set; }

	public Rebel(string name,int age, string group)
	{
		this.Name = name;
		this.Age = age;
		this.Group = group;
		this.Food = 0;
	}

	public string Group
	{
		get { return group; }
		set { group = value; }
	}

	public void BuyFood()
	{
		this.Food += 5;
	}

}

