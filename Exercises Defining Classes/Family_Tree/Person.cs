using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
	private string name;
	private string birthDay;
	private HashSet<Person> children;
	private HashSet<Person> parents;

	public Person()
	{
		this.Children = new HashSet<Person>();
		this.Parents = new HashSet<Person>();
	}

	public Person(string name)
		:this()
	{
		this.Name = name;
	}
	

	public HashSet<Person> Parents
	{
		get { return parents; }
		set { parents = value; }
	}

	public HashSet<Person> Children
	{
		get { return children; }
		set { children = value; }
	}
	
	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public string BirthDay
	{
		get { return birthDay; }
		set { birthDay = value; }
	}

	
}

