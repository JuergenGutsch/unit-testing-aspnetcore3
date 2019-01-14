using GenFu;
using Microsoft.EntityFrameworkCore;
using WebToTest.Data.Entities;

namespace WebToTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding
            var i = 1;
            var personsToSeed = A.ListOf<Person>(26);
            personsToSeed.ForEach(x => x.Id = i++);
            modelBuilder.Entity<Person>().HasData(personsToSeed);
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}