public static class FoodPattern
{
	public static Food Get(string input)
	{

		string[] inputArr = input.Split();
		int quantity = int.Parse(inputArr[1]);

		switch (inputArr[0])
		{
			case "Vegetable":
				return new Vegetable(quantity);
			case "Fruit":
				return new Fruit(quantity);
			case "Meat":
				return new Meat(quantity);
			case "Seeds":
				return new Seeds(quantity);
			default:
				return null;
		}
	}
}