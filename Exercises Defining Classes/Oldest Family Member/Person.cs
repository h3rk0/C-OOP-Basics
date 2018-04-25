using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
	private string name { get; set; }
	private int age { get; set; }

	public string Name
	{
		get
		{
			return this.name;
		}
		set
		{
			this.name = value;
		}
	}

	public int Age
	{
		get
		{
			return this.age;
		}
		set
		{
			this.age = value;
		}
	}

	public Person()
	{
		this.Name = "No name";
		this.Age = 1;
	}

	public Person(int age)
		:this()
	{
		this.Age = age;
	}

	public Person(string name,int age)
	{
		this.Name = name;
		this.Age = age;
	}

	public override string ToString()
	{
		return $"{this.name} {this.age}";
	}
	
}

public class Family
{
	public List<Person> family = new List<Person>();


	public void AddMember(Person member)
	{
		this.family.Add(member);
	}

	public Person GetOldestMember()
	{
		Person oldestMember = this.family.OrderByDescending(p => p.Age).First();

		return oldestMember;
	}
}

