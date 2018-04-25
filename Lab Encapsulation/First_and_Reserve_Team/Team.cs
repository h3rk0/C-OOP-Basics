using System;
using System.Collections.Generic;
using System.Text;


public class Team
{
	private string name;
	private List<Person> firstTeam;
	private List<Person> reserveTeam;
	public Team(string name)
	{
		this.Name = name;
		this.reserveTeam = new List<Person>();
		this.firstTeam = new List<Person>(0);
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public List<Person> FirstTeam
	{
		get { return firstTeam; }

	}
	
	public List<Person> ReserveTeam
	{
		get { return reserveTeam; }

	}

	public void AddPlayer(Person person)
	{
		if(person.Age<40)
		{
			this.firstTeam.Add(person);
		}
		else
		{
			this.reserveTeam.Add(person);
		}
	}


}

