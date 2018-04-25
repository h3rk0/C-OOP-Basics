using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Military_Elite.Contracts;


public class Commando : SpecialisedSoldier, ICommando
{
	private ICollection<IMission> missions;

	public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>) missions;

	public Commando(string id, string firstName, string lastName,double salary)
		:base(id,firstName,lastName,salary)
	{
		this.missions = new List<IMission>();
	}

	public void CompleteMission(string missionCodeName)
	{
		IMission mission = this.missions.SingleOrDefault(m => m.CodeName == missionCodeName);

		if (mission == null) 
		{
			throw new ArgumentException();
		}

		mission.Complete();
	}

	public void AddMission(IMission mission)
	{
		this.missions.Add(mission);
	}

	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
			.AppendLine($"Corps: {this.Corps}")
			.AppendLine($"Missions:");

		foreach (var mission in this.Missions)
		{
			sb.AppendLine(mission.ToString());
		}

		string result = sb.ToString().Trim();
		return result;
	}
}

