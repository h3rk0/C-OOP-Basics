using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Department
{
	private string name;
	private List<Pacient> pacients;

	public Department(string name)
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

	public bool AddPacient(Pacient pacient)
	{
		if (this.Pacients.Count < 60) 
		{
			this.Pacients.Add(pacient);
			return true;
		}
		return false;
	}

	public void PrintPacients()
	{
		//List<Pacient> sorted = this.Pacients.OrderByDescending(p => p.Name).ToList();

		foreach (Pacient pacient in this.Pacients)
		{
			Console.WriteLine(pacient);
		}
	}

	public void PrintPacientsInRoom(int room)
	{
		// algorithm for room (first pacient index) -> 3 beds * 4 room (private case)  - 3 beds  = 9 index in this.Pacients list
		List<Pacient> currentRoom = new List<Pacient>();

		int startingIndex = room * 3 - 3;

		for (int pacientIndex = startingIndex; pacientIndex < this.Pacients.Count; pacientIndex++)
		{
			if (currentRoom.Count < 3)
			{
				currentRoom.Add(this.Pacients[pacientIndex]);
			}

		}

		var sorted = currentRoom.OrderBy(p => p.Name).ToList();

		foreach (Pacient pacient in sorted)
		{
			Console.WriteLine(pacient);
		}
	}

}

