using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            
			// initiallize instance of bag 
			Bag bag = new Bag(bagCapacity);

			// read items
			string[] items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			// check every item
            for (int itemIndex = 0; itemIndex < items.Length; itemIndex += 2)
            {
				string item = items[itemIndex];
				long amount = long.Parse(items[itemIndex + 1]);

				// if item is gold
				if(Regex.IsMatch(item.ToLower(),@"\bgold\b"))
				{
					bag.AddGold(amount);
					continue;
				}

				// if item is cash
				if(Regex.IsMatch(item.ToLower(), @"\b[a-z]{3}\b"))
				{
					Cash cash = new Cash(item, amount);
					bag.AddCash(cash);
					continue;
				}

				// if item is gem
				if (Regex.IsMatch(item.ToLower(), @"\b[a-z]+gem\b"))
				{
					Gem gem = new Gem(item, amount);
					bag.AddGem(gem);
				}
				
			}

			bag.PrintBag();
            
        }
    }
}