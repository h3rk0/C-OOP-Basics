using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Team
{
	private string name;
	private List<Player> Players;

	public int Rating => SetRating();

	private int SetRating()
	{
		if(this.Players.Count==0)
		{
			return 0;
		}
		else
		{
			return (int)Math.Round(this.Players.Average(p => p.OveralSkill));
		}
	}

	public Team(string name)
	{
		this.Name = name;
		this.Players = new List<Player>();
	}

	public string Name
	{
		get { return name; }
		private set
		{
			if(string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("A name should not be empty.");
			}
			name = value;
		}
	}

	public void AddPlayer(Player player)
	{
		this.Players.Add(player);
	}

	public void RemovePlayer(string playerName)
	{
		Player player = this.Players.SingleOrDefault(p => p.Name == playerName);

		if (player == null)
		{
			throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
		}
		
		this.Players.Remove(player);
	}
}

