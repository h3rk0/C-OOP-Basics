using System.Collections.Generic;
using System.Linq;

public class Department
{
	private List<Employee> employees;

	private string name;
	
	public List<Employee> Employees
	{
		get
		{
			return this.employees;
		}
		private set
		{
			this.employees = value;
		}
	}
	
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

	public decimal Average => this.Employees.Select(e => e.Salary).Average();

	public Department(string name)
	{
		this.Employees = new List<Employee>();
		this.Name = name;
	}

	public void AddEmployee(Employee employee)
	{
		this.employees.Add(employee);
	}
}