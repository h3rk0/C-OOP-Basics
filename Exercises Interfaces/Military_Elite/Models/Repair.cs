using System;
using System.Collections.Generic;
using System.Text;


public class Repair : IRepair
{
	public Repair(string name,int workHours)
	{
		this.Name = name;
		this.WorkHours = workHours;
	}

	public string Name { get; private set; }

	public int WorkHours { get; private set; }

	public override string ToString()
	{
		return $"Part Name: {this.Name} Hours Worked: {this.WorkHours}";
	}
}

