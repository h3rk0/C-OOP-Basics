using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
		List<Department> departments = new List<Department>();

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string[] input = Console.ReadLine().Split(' ').ToArray();

			string name = input[0];
			decimal salary = decimal.Parse(input[1]);
			string position = input[2];
			string departmentString = input[3];
			string email="n/a";
			int age=-1;

			Department department = departments.SingleOrDefault(d => d.Name == departmentString);

			if (department == null) 
			{
				department = new Department(departmentString);
			}

			if (input.Length == 6)
			{
				email = input[4];
				age = int.Parse(input[5]);
			}
			else if (input.Length == 5)
			{
				bool isAge = int.TryParse(input[4], out age);
				if (!isAge)
				{
					email = input[4];
					age = -1;
				}
			}
			
			Employee employee = new Employee(name,salary,position,department,email,age);

			department.AddEmployee(employee);

			if(!departments.Contains(department))
			{
				departments.Add(department);
			}
			
			
		}

		//foreach (var department in departments)
		//{
		//	Console.WriteLine($"dep: {department.Name}");

		//	foreach (var employee in department.Employees)
		//	{
		//		Console.WriteLine($"--{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age} ");
		//	}
		//}

		Department highestDepartment = departments.OrderByDescending(d => d.Employees.Select(e => e.Salary).Average()).First();

		Console.WriteLine($"Highest Average Salary: {highestDepartment.Name}");
		foreach (var employee in highestDepartment.Employees.OrderByDescending(e => e.Salary))
		{
			Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age} ");
		}
    }
}

