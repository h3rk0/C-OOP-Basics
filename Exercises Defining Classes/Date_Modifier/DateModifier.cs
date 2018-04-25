using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DateModifier
{
	//private string firstDate;
	//private string secondDate;

	//public string FirstDate
	//{
	//	get { return this.firstDate; }
	//	set { this.firstDate = value; }
	//}

	//public string SecondDate
	//{
	//	get { return this.secondDate; }
	//	set { this.secondDate = value; }
	//}
	//1992 05 31
	//DateTime date = new DateTime(2011, 2, 19);

	public static int CalculateDifference(string firstDateString,string secondDateString)
	{
		string[] firstDateArr = firstDateString.Split(' ').ToArray();
		DateTime firstDate = new DateTime(int.Parse(firstDateArr[0]), int.Parse(firstDateArr[1]), int.Parse(firstDateArr[2]));
		string[] secondDateArr = secondDateString.Split(' ').ToArray();
		DateTime secondDate = new DateTime(int.Parse(secondDateArr[0]), int.Parse(secondDateArr[1]), int.Parse(secondDateArr[2]));

		int result = (secondDate - firstDate).Days;

		if (result < 0)
		{
			result *= -1;
		}

		return result;
	}
}

