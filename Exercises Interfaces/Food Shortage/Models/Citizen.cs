using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IIdentity , IName , IBirthDate
{
	public string Id { get; }
	public string Name { get; }

	public string BirthDate { get; }

	private int age;

	public Citizen(string name,int age,string id,string birthDate)
	{
		this.Name = name;
		this.Age = age;
		this.Id = id;
		this.BirthDate = birthDate;
	}
	
	public int Age
	{
		get { return age; }
		set { age = value; }
	}

}


