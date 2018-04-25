public class Engine
{
	private string model;
	private double power;
	private double displacement;
	private string efficiency;

	public Engine(string model, double power)
	{
		this.Model = model;
		this.Power = power;
	}

	public Engine(string model, double power, double displacement)
		:this(model,power)
	{
		this.Displacement = displacement;
	}

	public Engine(string model, double power, string efficiency)
		:this(model,power)
	{
		this.Efficiency = efficiency;
	}

	public Engine(string model, double power, double displacement,string efficiency)
		:this(model,power,displacement)
	{
		this.Efficiency = efficiency;
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}
	
	public double Power
	{
		get { return power; }
		set { power = value; }
	}
	
	public double Displacement
	{
		get { return displacement; }
		set { displacement = value; }
	}
	
	public string Efficiency
	{
		get { return efficiency; }
		set { efficiency = value; }
	}

}