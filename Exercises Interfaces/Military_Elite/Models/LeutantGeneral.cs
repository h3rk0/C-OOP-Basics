using System;
using System.Collections.Generic;
using System.Text;


public class LeutantGeneral : Private, ILeutantGeneral
{
	private ICollection<ISoldier> privates;

	public LeutantGeneral(string id, string firstName, string lastName,double salary)
		:base(id,firstName,lastName,salary)
	{
		this.privates = new List<ISoldier>();
	}

	public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<ISoldier>)privates;

	public void AddPrivate(ISoldier soldier)
	{
		this.privates.Add(soldier);
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
			.AppendLine($"Privates:");

		foreach (var privateSoldier in this.Privates)
		{
			sb.AppendLine(privateSoldier.ToString());
		}

		string result = sb.ToString().Trim();
		return result;
	}
}

