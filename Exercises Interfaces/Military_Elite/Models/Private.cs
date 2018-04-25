using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Contracts;


public class Private : Soldier, IPrivate
{
	public double Salary { get; private set; }

	public Private(string id, string firstName, string lastName,double salary)
		:base(id,firstName,lastName)
	{
		this.Salary = salary;
	}

	public override string ToString()
	{
		return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
	}
}

