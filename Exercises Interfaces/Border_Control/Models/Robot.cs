using System;
using System.Collections.Generic;
using System.Text;


public class Robot : IIdentity
{
	private string name;
	public string Id { get; }

	public Robot(string name,string id)
	{
		this.Name = name;
		this.Id = id;
	}
	
	public string Name
	{
		get { return name; }
		set { name = value; }
	}


}

