using System;
using System.Collections.Generic;
using System.Text;


public class RandomList : List<string>
{
	public string RandomString()
	{
		Random rnd = new Random();

		int stringIndex = rnd.Next(0, this.Count);

		string removed = this[stringIndex];
		this.RemoveAt(stringIndex);
		return removed;
	}
}

