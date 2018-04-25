using System;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main()
        {
			//Car car = new Car(50,0.1);
			//Console.WriteLine(car.FuelQuantity);
			//Console.WriteLine(car.Drive(45));
			//Console.WriteLine(car.FuelQuantity);

			string[] carArr = Console.ReadLine().Split().ToArray();
			double carFuelQuantity = double.Parse(carArr[1]);
			double carFuelConsumption = double.Parse(carArr[2]);
			Car car = new Car(carFuelQuantity, carFuelConsumption);

			string[] truckArr = Console.ReadLine().Split().ToArray();
			double truckFuelQuantity = double.Parse(truckArr[1]);
			double truckFuelConsumption = double.Parse(truckArr[2]);
			Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

			int count = int.Parse(Console.ReadLine());

			for (int commandIndex = 0; commandIndex < count; commandIndex++)
			{
				string[] args = Console.ReadLine().Split().ToArray();

				string command = args[0];
				string objectType = args[1];
				double amount = double.Parse(args[2]);

				if (objectType == "Car") 
				{
					if (command == "Drive")
					{
						Console.WriteLine(car.Drive(amount));
					}
					else if (command == "Refuel")
					{
						car.Refuel(amount);
					}
				}
				else if(objectType == "Truck")
				{
					if (command == "Drive")
					{
						Console.WriteLine(truck.Drive(amount));
					}
					else if (command == "Refuel")
					{
						truck.Refuel(amount);
					}
				}
			}

			Console.WriteLine(car);
			Console.WriteLine(truck);
        }
    }
}
