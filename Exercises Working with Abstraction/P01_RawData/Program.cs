using System;
using System.Collections.Generic;
using System.Linq;



class RawData
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            string model = parameters[0];

			// initialize engine
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
			Engine engine = new Engine(engineSpeed, enginePower);

			// initialize cargo
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
			Cargo cargo = new Cargo(cargoWeight, cargoType);

			// initialize tires
            decimal tire1Pressure = decimal.Parse(parameters[5]);
            int tire1age = int.Parse(parameters[6]);
			Tire tireOne = new Tire(tire1Pressure, tire1age);

			decimal tire2Pressure = decimal.Parse(parameters[7]);
            int tire2age = int.Parse(parameters[8]);
			Tire tireTwo = new Tire(tire2Pressure, tire2age);
			
			decimal tire3Pressure = decimal.Parse(parameters[9]);
            int tire3age = int.Parse(parameters[10]);
			Tire tireThree = new Tire(tire3Pressure, tire3age);

			decimal tire4Pressure = decimal.Parse(parameters[11]);
            int tire4age = int.Parse(parameters[12]);
			Tire tireFour = new Tire(tire4Pressure, tire4age);

			// initialize car
            cars.Add(new Car(model,engine,cargo,tireOne,tireTwo,tireThree,tireFour));
        }

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.cargo.cargoType == "fragile" && x.tires.Any(y => y.tirePressure < 1))
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.cargo.cargoType == "flamable" && x.engine.enginePower > 250)
                .Select(x => x.model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }
}

