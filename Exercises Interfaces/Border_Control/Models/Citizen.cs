using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IIdentity
{
	public string Id { get; }

	private int age;
	private string name;

	public Citizen(string name,int age,string id)
	{
		this.Name = name;
		this.Age = age;
		this.Id = id;
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public int Age
	{
		get { return age; }
		set { age = value; }
	}



}


