using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		List<Car> cars = new List<Car>();

		for (int i = 0; i < n; i++)
		{
			string[] args = Console.ReadLine().Split(' ').ToArray();

			string name = args[0];
			int fuelAmount = int.Parse(args[1]);
			decimal fuelConsumption = decimal.Parse(args[2]);

			Car car = new Car(name, fuelAmount, fuelConsumption);

			cars.Add(car);

		}
		

		while (true)
		{
			string command = Console.ReadLine();

			if (command == "End")
			{
				break;
			}

			string[] commandArgs = command.Split(' ').ToArray();

			string carModel = commandArgs[1];

			Car currentCar = cars.SingleOrDefault(c => c.Model == carModel);

			int amountOfKm = int.Parse(commandArgs[2]);

			currentCar.TravelDistance(amountOfKm);
			
		}

		foreach (Car car in cars)
		{
			Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
		}
	}
}

