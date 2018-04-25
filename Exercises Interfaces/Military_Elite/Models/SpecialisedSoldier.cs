using System;
using System.Collections.Generic;
using System.Text;


public abstract class SpecialisedSoldier : Private, ISpecializedSoldier
{
	public SpecialisedSoldier(string id, string firstName, string lastName,double salary)
		:base(id,firstName,lastName,salary)
	{

	}

	public Corps Corps { get; private set; }

	public void ParseCorps(string corps)
	{
		bool valid = Enum.TryParse(typeof(Corps), corps, out object result);

		if(!valid)
		{
			throw new ArgumentException();
		}

		this.Corps = (Corps) result;
	}

	
}

