using System;
using System.Collections.Generic;
using System.Text;

public class Parent
{
	private string name;
	private string birthDay;

	public Parent(string name,string birthDay)
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
