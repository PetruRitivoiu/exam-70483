using System;
using System.Diagnostics;
using System.Linq;

namespace exam_70483
{
	class Program
	{
		static void Main(string[] args)
		{
			//SqlConnection, SqlCommand, SqlDataReader
			var conn = @"Server=(LocalDb)\MSSQLLocalDB;Database=PracticeDB;Trusted_Connection=True;";
			Console.WriteLine(Sql.GetAnimals(conn)[2]);

			//Linq Query Syntax
			int[] numbers = { 1, 7, 2, 9, 3, 6, 4, 5, 0 };
			Console.WriteLine(Linq.LinqQuerySyntax(numbers).Aggregate((curr, acc) => acc += curr));

			//Data Contract JSON Serialization
			Console.WriteLine(Serialization.WcfJsonSerializedLocation());

			//Delegates
			Delegates.Execute();

			//Lock
			Console.WriteLine(Lock.Catalog);

			Debug.Assert(false);
			Console.WriteLine("stop");
		}
	}
}
