using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Car> cars = new List<Car>();

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string[] args = Console.ReadLine().Split(' ').ToArray();

			// model
			string model = args[0];

			// engine
			int engineSpeed = int.Parse(args[1]);
			int enginePower = int.Parse(args[2]);
			Engine engine = new Engine(engineSpeed, enginePower);

			// cargo 
			int cargoWeight = int.Parse(args[3]);
			string cargoType = args[4];
			Cargo cargo = new Cargo(cargoWeight, cargoType);

			// tires
			decimal tireOnePressure = decimal.Parse(args[5]);
			int tireOneAge = int.Parse(args[6]);
			Tire tireOne = new Tire(tireOnePressure, tireOneAge);

			decimal tireTwoPressure = decimal.Parse(args[5]);
			int tireTwoAge = int.Parse(args[6]);
			Tire tireTwo = new Tire(tireTwoPressure, tireTwoAge);

			decimal tireThreePressure = decimal.Parse(args[5]);
			int tireThreeAge = int.Parse(args[6]);
			Tire tireThree = new Tire(tireThreePressure, tireThreeAge);

			decimal tireFourPressure = decimal.Parse(args[5]);
			int tireFourAge = int.Parse(args[6]);
			Tire tireFour = new Tire(tireFourPressure, tireFourAge);

			// car 
			Car car = new Car(model, engine, cargo, tireOne, tireTwo, tireThree, tireFour);

			cars.Add(car);
		}

		string command = Console.ReadLine();

		if(command=="fragile")
		{
			Car[] fragileCars = cars.Where(c => c.Cargo.CargoType == "fragile").ToArray();

			Car[] fragileCarsWithLowTirePressure = fragileCars
														.Where(c => c.TireOne.Pressure < 1 
														|| c.TireTwo.Pressure < 1
														|| c.TireThree.Pressure < 1
														|| c.TireFour.Pressure < 1)
														.ToArray();

			foreach (Car car in fragileCarsWithLowTirePressure)
			{
				Console.WriteLine(car.Model);
			}
		}
		else if (command == "flamable")
		{
			Car[] flamableCars = cars.Where(c => c.Cargo.CargoType == "flamable").ToArray();

			Car[] flamableCarsWithHighEnginePower = flamableCars
														.Where(c => c.Engine.EnginePower > 250)
														.ToArray();

			foreach (Car car in flamableCarsWithHighEnginePower)
			{
				Console.WriteLine(car.Model);
			}
		}
	}
}

