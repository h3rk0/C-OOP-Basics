public class Enemy
{
	private char direction;
	private int row;
	private int col;

	public Enemy(char direction,int row,int col)
	{
		this.Direction = direction;
		this.Row = row;
		this.Col = col;
	}

	public char Direction
	{
		get { return direction; }
		set { direction = value; }
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
		return $"Enemy:{this.Row}, {this.Col}";
	}

}