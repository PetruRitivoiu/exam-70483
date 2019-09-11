using System;
using System.Collections.Generic;

namespace exam_70483
{
	public delegate void AddUserCallback(int i);

	public class User
	{
		public string Name { get; set; }
	}

	public class UserTracker
	{
		List<User> users = new List<User>();
		public void AddUser(string name, AddUserCallback callback)
		{
			users.Add(new User() { Name = name });
			callback(users.Count);
		}
	}

	public class Delegates
	{
		static UserTracker tracker = new UserTracker();

		public static void NormalDelegateImplementation(int i)
		{
			Console.WriteLine($"user {i}");
		}

		public static void Execute()
		{
			tracker.AddUser("petru", (i) => Console.WriteLine($"user {i}"));
			tracker.AddUser("marius", NormalDelegateImplementation);
			tracker.AddUser("mihail", delegate (int i) { Console.WriteLine($"user {i}"); });
			tracker.AddUser("florin", new AddUserCallback(NormalDelegateImplementation));
		}
	}
}
