using System;
using System.Collections.Generic;
using System.Text;


public class PriceCalculator
{

	public static decimal Calculate(Holiday holiday)
	{
		decimal price = 0m;

		// current holiday 
		decimal pricePerDay = holiday.PricePerDay;
		int numberOfDays = holiday.NumberOfDays;
		Season season = holiday.Season;
		Discount discount = holiday.Discount;

		// initial price
		price = pricePerDay * numberOfDays;

		// multiply price depending on season
		if (season == Season.Spring)
		{
			price *= 2.0m;
		}
		else if (season == Season.Summer)
		{
			price *= 4.0m;
		}
		else if (season == Season.Winter)
		{
			price *= 3.0m;
		}

		// discount
		if (discount == Discount.SecondVisit)
		{
			price *= 0.9m;
		}
		else if (discount == Discount.VIP)
		{
			price *= 0.8m;
		}
		
		return price;
	}
}

