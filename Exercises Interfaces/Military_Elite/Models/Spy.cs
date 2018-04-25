using System;
using System.Collections.Generic;
using System.Text;


public class Spy : Soldier, ISpy
{
	public Spy(string id, string firstName, string lastName,int spyNumber)
		:base(id,firstName,lastName)
	{
		this.CodeNumber = spyNumber;
	}

	public int CodeNumber { get; }

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
			.AppendLine($"Code Number: {this.CodeNumber}");

		string result = sb.ToString().Trim();
		return result;
	}
}

