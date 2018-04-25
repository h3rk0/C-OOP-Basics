using System;
using System.Collections.Generic;
using System.Text;


public class Pacient
{
	private string name;

	public Pacient(string name)
	{
		this.Name = name;
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public override string ToString()
	{
		return $"{this.Name}";
	}




}

