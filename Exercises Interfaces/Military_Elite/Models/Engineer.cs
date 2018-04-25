using System;
using System.Collections.Generic;
using System.Text;



public class Engineer : SpecialisedSoldier, IEngineer
{
	private ICollection<IRepair> repairs;
	public Engineer(string id, string firstName, string lastName,double salary)
		:base(id,firstName,lastName,salary)
	{
		this.repairs = new List<IRepair>();
	}

	public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)repairs;

	public void AddRepair(IRepair repair)
	{
		this.repairs.Add(repair);
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
			.AppendLine($"Corps: {this.Corps}")
			.AppendLine($"Repairs:");

		foreach (var repair in this.Repairs)
		{
			sb.AppendLine($"  {repair.ToString()}");
		}

		string result = sb.ToString().Trim();
		return result;
	}
}

