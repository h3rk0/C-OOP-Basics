using System;


class Program
{
    static void Main()
    {
		

		try
		{
			string[] pizzaArr = Console.ReadLine().Split();
			string pizzaName = pizzaArr[1];
			Pizza pizza = new Pizza(pizzaName);

			string[] doughArr = Console.ReadLine().Split();
			string name = doughArr[0];
			string flour = doughArr[1];
			string tech = doughArr[2];
			double weight = double.Parse(doughArr[3]);
			Dough dough = new Dough(flour, tech, weight);

			pizza.Dough = dough;
			//Console.WriteLine($"{dough.Calories:f2}");

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "END")
				{
					break;
				}
				
				string[] toppingArr = input.Split();

				Topping topping = new Topping(toppingArr[1], double.Parse(toppingArr[2]));

				pizza.AddTopping(topping);
				//Console.WriteLine($"{topping.Calories:f2}");
				

			}

			Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories. ");
		}
		catch (Exception e)
		{

			Console.WriteLine(e.Message);
		}
		
    }
}

