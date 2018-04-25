using System;
using System.Collections.Generic;
using System.Text;


public class Mission : IMission
{
	public Mission(string codeName,string state)
	{
		this.CodeName = codeName;
		ParseState(state);
	}

	private void ParseState(string state)
	{
		bool parsed = Enum.TryParse(typeof(State), state, out object result);

		if(!parsed)
		{
			throw new ArgumentException();
		}

		this.State = (State)result;
	}

	public string CodeName { get; private set; }

	public State State { get; private set; }

	void IMission.Complete()
	{
		this.State = State.Finished;
	}

	public override string ToString()
	{
		return $"Code Name: {this.CodeName} State: {this.State}";
	}
}

