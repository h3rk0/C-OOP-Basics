using System;
using System.Collections.Generic;
using System.Text;


public class MyList : IAddCollection, IRemoveCollection
{
	private string[] items { get; set; }

	public MyList()
	{
		this.items = new string[100];
		this.Count = 0;
	}

	public string[] Items => items;

	public int Count { get; private set; }

	public int Add(string item)
	{
		if (this.Count == 0)
		{
			items[0] = item;
			this.Count++;
		}
		else
		{
			for (int i = this.Count + 1; i >= 1; i--)
			{
				items[i] = items[i - 1];
			}

			items[0] = item;
			this.Count++;
		}

		return 0;
	}

	public string Remove()
	{
		string removed = this.items[0];

		for (int i = 0; i < this.Count-1; i++)
		{
			this.items[i] = this.items[i + 1];
		}

		this.items[this.Count - 1] = default(string);

		this.Count--;

		return removed;
	}
}

