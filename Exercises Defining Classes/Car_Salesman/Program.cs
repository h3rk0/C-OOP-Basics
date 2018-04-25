using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
		List<Engine> engines = new List<Engine>();
		List<Car> cars = new List<Car>();

		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string[] engineArgs = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			string model = engineArgs[0];

			double power = double.Parse(engineArgs[1]);

			double displacement = -1;
			string efficiency = "n/a";

			if(engineArgs.Length==4)
			{
				displacement = double.Parse(engineArgs[2]);
				efficiency = engineArgs[3];
			}
			else if(engineArgs.Length==3)
			{
				bool isDisplacement = double.TryParse(engineArgs[2], out displacement);

				if (!isDisplacement)
				{
					efficiency = engineArgs[2];
					displacement = -1;
				}
			}
			

			Engine engine = new Engine(model, power, displacement, efficiency);

			engines.Add(engine);
		}

		int m = int.Parse(Console.ReadLine());

		for (int i = 0; i < m; i++)
		{
			string[] carArgs = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			string carModel = carArgs[0];

			string engineString = carArgs[1];
			Engine engine = engines.First(e => e.Model == engineString);

			double weight = -1; 
			string color = "n/a";

			if (carArgs.Length == 4)
			{
				weight = double.Parse(carArgs[2]);
				color = carArgs[3];
			}
			else if(carArgs.Length==3)
			{
				bool isWeight = double.TryParse(carArgs[2], out weight);

				if (!isWeight)
				{
					color = carArgs[2];
					weight = -1;
				}
			}
			

			Car car = new Car(carModel, engine, weight, color);

			cars.Add(car);
		}

		foreach (Car car in cars)
		{
			Console.WriteLine(car);
		}
    }
}

