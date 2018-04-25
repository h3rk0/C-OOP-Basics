using System;
using System.Linq;

namespace Collection_Hierarchy
{
    class Program
    {
        static void Main()
        {
			// banichka boza tutmanik
			string[] args = Console.ReadLine().Split().ToArray();

			// remove operations
			int removeCount = int.Parse(Console.ReadLine());

			AddCollection first = new AddCollection();
			AddRemoveCollection second = new AddRemoveCollection();
			MyList third = new MyList();

			foreach (var arg in args)
			{
				Console.Write(first.Add(arg)+ " ");
			}

			Console.WriteLine();

			foreach (var arg in args)
			{
				Console.Write(second.Add(arg) + " ");
			}

			Console.WriteLine();

			foreach (var arg in args)
			{
				Console.Write(third.Add(arg) + " ");
			}

			Console.WriteLine();

			for (int i = 0; i < removeCount; i++)
			{
				Console.Write(second.Remove()+" ");
			}
			Console.WriteLine();

			for (int i = 0; i < removeCount; i++)
			{
				Console.Write(third.Remove() + " ");
			}
			Console.WriteLine();

			

			//Console.WriteLine();
		}
    }
}
