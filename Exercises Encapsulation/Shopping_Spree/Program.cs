using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
		List<Person> persons = new List<Person>();
		List<Product> products = new List<Product>();

		try
		{
			string[] personsArr = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			// initialize persons
			for (int personIndex = 0; personIndex < personsArr.Length; personIndex++)
			{
				string[] personArr = personsArr[personIndex].Split('=').ToArray();
				string personName = personArr[0];
				decimal personMoney = decimal.Parse(personArr[1]);

				Person person = new Person(personName, personMoney);
				persons.Add(person);



			}

			string[] productsArr = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			// initialize products 
			for (int productIndex = 0; productIndex < productsArr.Length; productIndex++)
			{

				string[] productArr = productsArr[productIndex].Split('=').ToArray();
				string productName = productArr[0];
				decimal productPrice = decimal.Parse(productArr[1]);

				Product product = new Product(productName, productPrice);
				products.Add(product);

			}

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "END")
				{
					break;
				}

				string[] args = input.Split().ToArray();

				string personName = args[0];
				string productName = args[1];

				Person person = persons.Single(p => p.Name == personName);
				
				Product product = products.Single(p => p.Name == productName);
				

				person.BuyProduct(product);
			}


			foreach (Person person in persons)
			{
				if (person.Products.Count == 0)
				{
					Console.WriteLine($"{person.Name} - Nothing bought");
				}
				else
				{
					//Dictionary<string, int> personProducts = new Dictionary<string, int>();

					//for (int i = 0; i < person.Products.Count; i++)
					//{
					//	if (!personProducts.ContainsKey(person.Products[i].Name))
					//	{
					//		personProducts[person.Products[i].Name] = 1;
					//	}
					//	else
					//	{
					//		personProducts[person.Products[i].Name]++;
					//	}
					//}

					//List<string> personProductsResult = new List<string>();

					//foreach (var product in products)
					//{
					//	if (personProducts.ContainsKey(product.Name))
					//	{
					//		for (int i = 0; i < personProducts[product.Name]; i++)
					//		{
					//			personProductsResult.Add(product.Name);
					//		}
					//	}
					//}
					Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
				}
			}
		}
		catch (ArgumentException e)
		{
			Console.WriteLine(e.Message);
		}
		
    }
}

