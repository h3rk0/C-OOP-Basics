using System;
using System.Collections.Generic;
using System.Text;


public class AddCollection : IAddCollection
{
	private string[] items;

	public int Count { get; private set; }

	public AddCollection()
	{
		this.items = new string[100];
		this.Count = 0;
	}
	
	public string[] Items => items;


	public int Add(string item)
	{
		items[this.Count] = item;
		this.Count++;
		return this.Count-1;
	}
}

