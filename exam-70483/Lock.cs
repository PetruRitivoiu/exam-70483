namespace exam_70483
{
	public class Catalog
	{
		public string name { get; set; }

		public override string ToString() => $"Catalog with Name {name}";
	}

	class Lock
	{
		static Catalog _catalog = new Catalog() { name = "Paintings" };
		static object _lock = new object();

		public static Catalog Catalog
		{
			get
			{
				lock (_lock) return _catalog;
			}
		}
	}
}
