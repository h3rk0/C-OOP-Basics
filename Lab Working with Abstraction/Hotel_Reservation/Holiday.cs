using System;
using System.Collections.Generic;
using System.Text;


public class Holiday
{
	private decimal pricePerDay;
	private int numberOfDays;
	private Season season;
	private Discount discount;

	public Holiday(decimal pricePerDay,int numbersOfDays,Season season,Discount discount = Discount.None)
	{
		this.PricePerDay = pricePerDay;
		this.NumberOfDays = numbersOfDays;
		this.Season = season;
		this.Discount = discount;
	}

	public decimal PricePerDay
	{
		get { return pricePerDay; }
		set { pricePerDay = value; }
	}
	
	public int NumberOfDays
	{
		get { return numberOfDays; }
		set { numberOfDays = value; }
	}
	
	public Season Season
	{
		get { return season; }
		set { season = value; }
	}
	
	public Discount Discount
	{
		get { return discount; }
		set { discount = value; }
	}
	
}

	