using System.Collections.Generic;
using System.Data.SqlClient;

namespace exam_70483
{
	public class Animal
	{
		public string Color { get; set; }
		public string Name { get; set; }

		public override string ToString() => $"{Name}, {Color}";
	}

	public class Sql
	{
		public static List<Animal> GetAnimals(string conn)
		{
			var animals = new List<Animal>();
			var sqlConnection = new SqlConnection(conn);

			using (sqlConnection)
			{
				var sqlCommand = new SqlCommand("SELECT Color, Name FROM Animal", sqlConnection);
				sqlConnection.Open();

				using (var sqlDataReader = sqlCommand.ExecuteReader())
				{
					while (sqlDataReader.Read())
					{
						var animal = new Animal();

						animal.Name = (string)sqlDataReader["name"];
						animal.Color = (string)sqlDataReader["color"];

						animals.Add(animal);
					}
				}
			}
			return animals;
		}
	}
}
