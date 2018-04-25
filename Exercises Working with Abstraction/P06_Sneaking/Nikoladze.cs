public class Nikoladze
{
	private int row;
	private int col;

	public Nikoladze(int row, int col)
	{
		this.Row = row;
		this.Col = col;
	}

	public int Row
	{
		get { return row; }
		set { row = value; }
	}

	public int Col
	{
		get { return col; }
		set { col = value; }
	}

	public override string ToString()
	{
		return $"Nikoladze: {this.Row}, {this.Col}";
	}

}
