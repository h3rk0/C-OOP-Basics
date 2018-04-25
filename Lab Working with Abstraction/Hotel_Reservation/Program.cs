using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
		// input
		string[] input = Console.ReadLine().Split(' ').ToArray();

		decimal price = decimal.Parse(input[0]);

		int days = int.Parse(input[1]);

		string seasonString = input[2];
		Season season = (Season)Enum.Parse(typeof(Season),seasonString);

		Discount discount = Discount.None;

		if (input.Length == 4)
		{
			string discountString = input[3];
			discount = (Discount)Enum.Parse(typeof(Discount), discountString);
		}

		// initiallize instance of holiday
		Holiday holiday = new Holiday(price, days, season, discount);

		decimal result = PriceCalculator.Calculate(holiday);

		Console.WriteLine($"{result:f2}");

    }
}

