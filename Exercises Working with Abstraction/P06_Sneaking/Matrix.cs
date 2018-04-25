using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Matrix
{
	private int rows;
	private Player player;
	private Nikoladze nikoladze;
	private List<Enemy> enemies;
	private char[][] room;
	public bool playerAlive { get; set; }
	public bool nikoladzeAlive { get; set; }
	public int Cols { get; set; }

	// constructor
	public Matrix(int rows)
	{
		this.Room = new char[rows][];
		this.Rows = rows;
		this.Player = null;
		this.Nikoladze = null;
		this.Enemies = new List<Enemy>();
		this.playerAlive = true;
		this.nikoladzeAlive = true;

	}

	// properties
	public List<Enemy> Enemies
	{
		get { return enemies; }
		set { enemies = value; }
	}
	
	public char[][] Room
	{
		get { return room; }
		set { room = value; }
	}
	
	public Player Player
	{
		get { return player; }
		set { player = value; }
	}
	
	public Nikoladze Nikoladze
	{
		get { return nikoladze; }
		set { nikoladze = value; }
	}
	
	public int Rows
	{
		get { return rows; }
		set { rows = value; }
	}
	
	// public methods

	// reads matrix
	public void ReadMatrix()
	{

		for (int row = 0; row < this.Rows; row++)
		{
			var input = Console.ReadLine().ToCharArray();
			//this.Cols = input.Length-1;
			room[row] = new char[input.Length];
			for (int col = 0; col < input.Length; col++)
			{
				room[row][col] = input[col];
			}
		}
		this.Cols = this.Room[this.Room.GetLength(0)-1].Length - 1;
		// finds and initiallizes player,nikoladze and enemies
		this.FindPlayer();
		this.FindNikoladze();
		this.FindEnemies();
	}
	
	public void PrintCurrentMatrix()
	{
		this.Room[this.Player.oldRow][this.player.oldCol] = '.';
		this.Room[this.Player.Row][this.player.Col] = 'S';

		if (this.playerAlive == false)
		{
			this.Room[Player.Row][Player.Col] = 'X';
		}
		else if(this.nikoladzeAlive == false)
		{
			this.Room[Nikoladze.Row][Nikoladze.Col] = 'X';
		}

		for (int row = 0; row < this.Room.GetLength(0); row++)
		{
			for (int col = 0; col < this.Room[row].Length; col++)
			{
				Console.Write(this.Room[row][col]);
			}
			Console.WriteLine();
		}
	}

	public void MoveEnemies()
	{
		// ...b....S...
		// ...S......d.
		foreach (Enemy enemy in this.Enemies)
		{
			if(enemy.Direction=='d')
			{
				if(enemy.Col == 0)
				{
					enemy.Direction = 'b';
					this.Room[enemy.Row][enemy.Col] = 'b';
				}
				else
				{
					this.Room[enemy.Row][enemy.Col] = '.';
					enemy.Col--;
					this.Room[enemy.Row][enemy.Col] = 'd';

				}
			}
			else if(enemy.Direction=='b')
			{
				if (enemy.Col ==this.Cols)
				{
					enemy.Direction = 'd';
					this.Room[enemy.Row][enemy.Col] = 'd';
				}
				else
				{
					this.Room[enemy.Row][enemy.Col] = '.';
					enemy.Col++;
					this.Room[enemy.Row][enemy.Col] = 'b';
				}
			}

			// if facing player => player is dead
			if(enemy.Row==player.Row&&enemy.Direction=='b'&&enemy.Col<=player.Col|| enemy.Row == player.Row && enemy.Direction == 'd' && enemy.Col >= player.Col)
			{
				this.playerAlive = false;
			}
		}
	}

	// private methods

	// finds and sets Player 
	private void FindPlayer()
	{
		int playerRow=0;
		int playerCol=0;
		for (int row = 0; row < this.Room.GetLength(0); row++)
		{
			for (int col = 0; col < this.Room[row].Length; col++)
			{
				if(this.Room[row][col]=='S')
				{
					//this.Room[row][col] = '.';
					playerRow = row;
					playerCol = col;
				}
			}
		}
		Player player = new Player(playerRow, playerCol);
		this.Player = player;
	}

	// finds and initiallizes nikolatze
	private void FindNikoladze()
	{
		int nikoladzeRow = 0;
		int nikoladzeCol = 0;
		for (int row = 0; row < this.Room.GetLength(0); row++)
		{
			for (int col = 0; col < this.Room[row].Length; col++)
			{
				if (this.Room[row][col] == 'N')
				{
					nikoladzeRow = row;
					nikoladzeCol = col;
				}
			}
		}
		Nikoladze nikoladze = new Nikoladze(nikoladzeRow, nikoladzeCol);
		this.Nikoladze = nikoladze;
	}

	// finds enemies 
	private void FindEnemies()
	{
		for (int row = 0; row < this.Room.GetLength(0); row++)
		{
			for (int col = 0; col < this.Room[row].Length; col++)
			{
				if(this.Room[row][col]=='b'|| this.Room[row][col] == 'd')
				{
					Enemy enemy = new Enemy(this.Room[row][col], row, col);
					this.Enemies.Add(enemy);
				}
			}
			
		}
	}

	public void PlayerMove(char move)
	{
		this.Player.MovePlayer(move);

		this.Room[this.Player.oldRow][this.player.oldCol] = '.';
		
		if(this.Room[this.player.Row][this.Player.Col]=='b'|| this.Room[this.player.Row][this.Player.Col] == 'd')
		{
			this.Room[this.player.Row][this.Player.Col] = '.';
			Enemy enemy = this.Enemies.Single(e => e.Row == this.player.Row && e.Col == this.Player.Col);

			this.Enemies.Remove(enemy);

		}

		if(this.Player.Row==this.Nikoladze.Row)
		{
			this.nikoladzeAlive = false;
		}
	}

	
}

