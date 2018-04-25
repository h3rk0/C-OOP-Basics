using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : Humanoid, IIdentity , IBirthDate , IAge , IBuyer
{
	public string Id { get; }
	public string BirthDate { get; }
	public int Age { get; }
	public int Food { get; private set; }


	public Citizen(string name,int age,string id,string birthDate)
	{
		this.Name = name;
		this.Age = age;
		this.Id = id;
		this.BirthDate = birthDate;
		this.Food = 0;
	}
	public void BuyFood()
	{
		this.Food += 10;
	}

}


