using System;
using System.Collections.Generic;
using System.Text;


public static class AnimalPattern
{
	public static Animal Get(string input)
	{

		string[] inputArr = input.Split();

		switch (inputArr[0])
		{
			case "Hen":
				return new Hen(inputArr[1],double.Parse(inputArr[2]),double.Parse(inputArr[3]));
			case "Owl":
				return new Owl(inputArr[1], double.Parse(inputArr[2]), double.Parse(inputArr[3]));
			case "Mouse":
				return new Mouse(inputArr[1], double.Parse(inputArr[2]), inputArr[3]);
			case "Dog":
				return new Dog(inputArr[1], double.Parse(inputArr[2]), inputArr[3]);
			case "Cat":
				return new Cat(inputArr[1], double.Parse(inputArr[2]), inputArr[3], inputArr[4]);
			case "Tiger":
				return new Tiger(inputArr[1], double.Parse(inputArr[2]), inputArr[3], inputArr[4]);
			default:
				return null;
		}
	}
}

