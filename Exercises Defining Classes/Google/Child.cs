using System;
using System.Collections.Generic;
using System.Text;


public class Child
{
	private string name;
	private string birthDay;

	public Child(string name,string birthDay)
	{
		this.Name = name;
		this.BirthDay = birthDay;
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	
	public string BirthDay
	{
		get { return birthDay; }
		set { birthDay = value; }
	}

}

