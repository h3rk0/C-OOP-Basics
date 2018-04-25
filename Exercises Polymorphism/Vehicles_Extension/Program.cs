using System;
using System.Linq;

namespace Vehicles_Extension
{
    class Program
    {
        static void Main()
        {
			string[] carArr = Console.ReadLine().Split().ToArray();
			double carFuelQuantity = double.Parse(carArr[1]);
			double carFuelConsumption = double.Parse(carArr[2]);
			double carTankCapacity = double.Parse(carArr[3]);
			Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

			string[] truckArr = Console.ReadLine().Split().ToArray();
			double truckFuelQuantity = double.Parse(truckArr[1]);
			double truckFuelConsumption = double.Parse(truckArr[2]);
			double truckTankCapacity = double.Parse(truckArr[3]);
			Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

			string[] busArr = Console.ReadLine().Split().ToArray();
			double busFuelQuantity = double.Parse(busArr[1]);
			double busFuelConsumption = double.Parse(busArr[2]);
			double busTankCapacity = double.Parse(busArr[3]);
			Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

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
				else if (objectType == "Truck")
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
				else if (objectType == "Bus")
				{
					if (command == "Drive")
					{
						Console.WriteLine(bus.DriveWithPassengers(amount));
					}
					else if (command == "Refuel")
					{
						bus.Refuel(amount);
					}
					else if (command == "DriveEmpty")
					{
						Console.WriteLine(bus.Drive(amount));	
					}

				}
			}

			Console.WriteLine(car);
			Console.WriteLine(truck);
			Console.WriteLine(bus);
		}
    }
}
