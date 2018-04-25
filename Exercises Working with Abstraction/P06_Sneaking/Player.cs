public class Player
{
	public int oldRow;
	public int oldCol;
	private int row;
	private int col;

	public Player(int row,int col)
	{
		this.Row = row;
		this.Col = col;
		this.oldRow = this.row;
		this.oldCol = this.col;
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

	public void MovePlayer(char move)
	{
		if(move=='U')
		{
			this.oldRow = this.row;
			this.oldCol = this.col;
			this.row--;
		}
		else if (move == 'D')
		{
			this.oldRow = this.row;
			this.oldCol = this.col;
			this.row++;
		}
		else if (move == 'L')
		{
			this.oldRow = this.row;
			this.oldCol = this.col;
			this.col--;
		}
		else if (move == 'R')
		{
			this.oldRow = this.row;
			this.oldCol = this.col;
			this.col++;
		}
	}

	public override string ToString()
	{
		return $"Player: {this.Row}, {this.Col}";
	}
}