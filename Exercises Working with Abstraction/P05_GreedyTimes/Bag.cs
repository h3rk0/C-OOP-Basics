using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Bag
{
	private long bagCapacity;

	public Gold Gold { get; set; }
	public List<Gem> Gems { get; set; }
	public List<Cash> Cash { get; set; }
	
	

	private long GoldAmount => Gold.Amount;
	private long GemAmount => Gems.Sum(g => g.Amount);
	private long CashAmount => Cash.Sum(c => c.Amount);
	private long CurrentBagAmount => GoldAmount + GemAmount + CashAmount;

	public Bag(long bagCapacity)
	{
		this.BagCapacity = bagCapacity;
		this.Gold = new Gold();
		this.Gems = new List<Gem>();
		this.Cash = new List<Cash>();
	}

	public long BagCapacity
	{
		get { return bagCapacity; }
		set { bagCapacity = value; }
	}

	public void AddGold(long gold)
	{
		if(BagWontExceed(gold))
		{
			this.Gold.Amount += gold;
		}
	}

	public void AddCash(Cash cash)
	{
		long currentAmount = cash.Amount;

		if(this.CashAmount+currentAmount<=this.GemAmount && BagWontExceed(currentAmount))
		{
			this.Cash.Add(cash);
		}
	}

	public void AddGem(Gem gem)
	{
		long currentAmount = gem.Amount;

		if (this.GemAmount + currentAmount <= this.GoldAmount && BagWontExceed(currentAmount))
		{
			this.Gems.Add(gem);
		}
	}

	private bool BagWontExceed(long amount)
	{
		return amount + this.CurrentBagAmount <= this.BagCapacity;
	}

	public void PrintBag()
	{
		// gold > gem > cash
		// gold = gem > cash
		if(this.GoldAmount==this.GemAmount)
		if(this.GoldAmount>0)
		{
			Console.WriteLine($"<Gold> ${this.GoldAmount}");
			Console.WriteLine($"##Gold - {this.GoldAmount}");
		}

		if(this.GemAmount>0)
		{
			Console.WriteLine($"<Gem> ${this.GemAmount}");
			foreach (Gem gem in this.Gems.OrderByDescending(g => g.Name).ThenBy(g => g.Amount)) 
			{
				Console.WriteLine($"##{gem.Name} - {gem.Amount}");
			}
		}

		if (this.CashAmount > 0)
		{
			
			Console.WriteLine($"<Cash> ${this.CashAmount}");
			foreach (Cash cash in this.Cash.OrderByDescending(g => g.Name).ThenBy(g => g.Amount))
			{
				Console.WriteLine($"##{cash.Name} - {cash.Amount}");
			}
		}
	}
}

