using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
	private string name;
	private decimal salary;
	private string position;
	private Department department;
	private string email= "n/a";
	private int age =-1;
	
	public Employee(string name, decimal salary, string position, Department department,string email,int age)
	{
		this.Name = name;
		this.Salary = salary;
		this.Position = position;
		this.department = department;
		this.Email = email;
		this.Age = age;
	}
	

	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	
	public decimal Salary
	{
		get { return salary; }
		set { salary = value; }
	}
	
	public string Position
	{
		get { return position; }
		set { position = value; }
	}
	
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
	
	public int Age
	{
		get { return age; }
		set { age = value; }
	}


}

