using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


public class Smartphone : ICall , IBrowse
{
	public string Call(string number)
	{
		if (NumberIsInvalid(number))
		{
			return "Invalid number!";
		}

		return $"Calling... {number}";
	}
	
	public string Browse(string link)
	{
		if (!IsUrlValid(link))
		{
			return "Invalid URL!";
		}

		return $"Browsing: {link}!";
	}

	/// <summary>
	///  ??
	/// </summary>
	/// <param name="link"></param>
	/// <returns></returns>
	

	private bool LinkIsInvalid(string link)
	{
		return !Regex.IsMatch(link, @"^[^\d]+$");
	}

	private bool IsUrlValid(string url)
	{
		for (int i = 0; i < url.Length; i++)
		{
			if (char.IsDigit(url[i]))
			{
				return false;
			}
		}

		return true;
	}

	private bool NumberIsInvalid(string number)
	{
		return !Regex.IsMatch(number, @"\b\d+\b");
	}
}

