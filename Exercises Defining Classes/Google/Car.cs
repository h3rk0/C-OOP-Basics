public class Car
{
	private string model;
	private decimal speed;

	public Car(string model,decimal speed)
	{
		this.Model = model;
		this.Speed = speed;
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}
	
	public decimal Speed
	{
		get { return speed; }
		set { speed = value; }
	}


}