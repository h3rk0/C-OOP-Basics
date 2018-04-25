using System;
using System.Collections.Generic;
using System.Text;


public class Pet : IName , IBirthDate
{
	public string Name { get; }
	public string BirthDate { get; }

	public Pet(string name,string birthDate)
	{
		this.Name = name;
		this.BirthDate = birthDate;
	}
}

