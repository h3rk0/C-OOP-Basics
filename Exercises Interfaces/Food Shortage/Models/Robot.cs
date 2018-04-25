using System;
using System.Collections.Generic;
using System.Text;


public class Robot : IIdentity , IName
{
	public string Name { get; }
	public string Id { get; }

	public Robot(string name,string id)
	{
		this.Name = name;
		this.Id = id;
	}
	
}

