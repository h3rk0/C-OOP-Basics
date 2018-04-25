using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Doctor 
{
	private string name;
	private List<Pacient> pacients;

	public Doctor(string name)
	{
		this.Name = name;
		this.Pacients = new List<Pacient>();
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public List<Pacient> Pacients
	{
		get { return pacients; }
		set { pacients = value; }
	}

	public void AddPacient(Pacient pacient)
	{
		this.Pacients.Add(pacient);
	}

	public void PrintPacients()
	{
		List<Pacient> sorted = this.Pacients.OrderBy(p => p.Name).ToList();

		foreach (Pacient pacient in sorted)
		{
			Console.WriteLine(pacient);
		}
	}

}

