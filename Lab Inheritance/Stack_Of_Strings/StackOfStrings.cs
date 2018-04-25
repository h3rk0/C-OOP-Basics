using System;
using System.Collections.Generic;
using System.Text;


public class StackOfStrings
{
	private List<string> data;

	public StackOfStrings()
	{
		this.data = new List<string>();
	}

	public void Push(string item)
	{
		this.data.Add(item);
	}

	public string Pop()
	{
		string item = this.data[this.data.Count - 1];
		this.data.RemoveAt(this.data.Count - 1);
		return item;
	}

	public string Peek()
	{
		string item = this.data[this.data.Count - 1];
		return item;
	}

	public bool IsEmpty()
	{
		return this.data.Count == 0;
	}
}

