﻿using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

		Family family = new Family();

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();

			string name = input[0];

			int age = int.Parse(input[1]);

			Person person = new Person(name, age);

			family.AddMember(person);
		}

		Person oldestPerson = family.GetOldestMember();

		Console.WriteLine(oldestPerson);
    }
}

