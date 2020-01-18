using CS_EFCORE.Models;
using System;
using System.Linq;

namespace CS_EFCORE
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				ManageDatabase();

				using (var ctx = new PersonDBContext())
				{
					var person = new Person()
					{
						PersonName = "Rajneesh",
						Gender = "Male",
						Age = 30						
					};

					ctx.Persons.Add(person);
					ctx.SaveChanges();

					Console.WriteLine("Added person");

					foreach (var p in ctx.Persons.ToList())
					{
						// Use interpolation in C# 6.0
						// This is equavalent to String builter. Mutable string object
						Console.WriteLine($"{p.PersonId} {p.PersonName} {p.Age} {p.Gender}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex.Message}");
			}

			Console.ReadLine();
		}

		// This method will make sure that if the database is already available, then delete it
		static void ManageDatabase()
		{
			using (var ctx = new PersonDBContext())
			{
				ctx.Database.EnsureDeleted();
				ctx.Database.EnsureCreated();
			}
		}
    }
}
