using System;
using System.Collections.Generic;
using System.Linq;

namespace Wild_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
			// weight 4.5
			//Animal hen = new Owl("sasho", 4.5, 0,5.5);
			//Meat veg = new Meat(5);
			//Console.WriteLine(hen.Eat(veg));
			//Console.WriteLine(hen);

			List<IAnimal> animals = new List<IAnimal>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "End") 
				{
					break;
				}

				Animal animal = AnimalPattern.Get(input);

				
				if (animal == null)
				{
					continue;
				}

				string foodInput = Console.ReadLine();

				Food food = FoodPattern.Get(foodInput);

				if (food == null)
				{
					continue;
				}

				Console.WriteLine(animal.Eat(food));
				animals.Add(animal);
			}

			foreach (Animal animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
    }
}
