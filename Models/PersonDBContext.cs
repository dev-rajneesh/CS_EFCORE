using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_EFCORE.Models
{
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public PersonDBContext()
        {

        }

        // Configure DB connection with Application
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb; Initial Catalog=PersonDb; Integrated Security=SSPI;");
        }

        // Provide mechanish of Model Mapping while database and tables are created
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>();
        }
    }
}
