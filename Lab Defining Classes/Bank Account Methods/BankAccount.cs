﻿using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
	int id { get; set; }
	decimal balance { get; set; }

	public int Id
	{
		get { return this.id; }
		set { this.id = value; }
	}

	public decimal Balance
	{
		get { return this.balance; }
		set { this.balance = value; }
	}

	public void Deposit(decimal amount)
	{
		this.Balance += amount;
	}
	
	public void Withdraw(decimal amount)
	{
		this.Balance -= amount;
	}

	public override string ToString()
	{
		return $"Account {this.Id}, balance {this.Balance}";
	}
}

