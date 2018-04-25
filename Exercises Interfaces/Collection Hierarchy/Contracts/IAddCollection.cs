using System;
using System.Collections.Generic;
using System.Text;


public interface IAddCollection
{
	string[] Items { get; }

	int Count { get; }

	int Add(string item);
}

