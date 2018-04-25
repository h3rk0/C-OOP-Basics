using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
		Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

		while (true)
		{
			string command = Console.ReadLine();

			if(command=="End")
			{
				break;
			}

			string[] commandArgs = command.Split(' ').ToArray();

			string commandName = commandArgs[0];

			int accountId = int.Parse(commandArgs[1]);

			if(commandName=="Create")
			{
				if(!AccountExists(accountId,accounts))
				{
					accounts[accountId] = new BankAccount();
					accounts[accountId].Id = accountId;
				}
				else
				{
					Console.WriteLine($"Account already exists");
				}
			}
			else if(commandName=="Deposit")
			{
				decimal amount = decimal.Parse(commandArgs[2]);

				if (!AccountExists(accountId, accounts))
				{
					continue;
				}

				accounts[accountId].Deposit(amount);

			}
			else if(commandName=="Withdraw")
			{
				decimal amount = decimal.Parse(commandArgs[2]);

				if (!AccountExists(accountId, accounts))
				{
					continue;
				}

				if(amount>accounts[accountId].Balance)
				{
					Console.WriteLine("Insufficient balance");
					continue;
				}

				accounts[accountId].Withdraw(amount);
			}
			else if(commandName=="Print")
			{
				if (!AccountExists(accountId, accounts))
				{
					continue;
				}

				BankAccount account = accounts[accountId];

				Console.WriteLine(account);
			}
			
		}

	}
	public static bool AccountExists(int accountId, Dictionary<int, BankAccount> accounts)
	{
		if (accounts.ContainsKey(accountId))
		{
			return true;
		}
		else
		{
			Console.WriteLine("Account does not exist");
			return false;
		}
	}

}

