using System.Collections.Generic;
using System.Linq;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Moq;
using WebToTest.Data;
using WebToTest.Data.Entities;
using WebToTest.Services;
using Xunit;

namespace WebToTest.Tests
{
    public class PersonServiceTests
    {
        [Fact]
        public void AllPersonsTest()
        {
            // arrange
            var context = CreateDbContext();

            var service = new PersonService(context.Object);

            // act
            var results = service.AllPersons();

            var count = results.Count();

            // assert
            Assert.Equal(26, count);
        }

        private Mock<ApplicationDbContext> CreateDbContext()
        {
            var persons = GetFakeData().AsQueryable();

            var dbSet = new Mock<DbSet<Person>>();
            dbSet.As<IQueryable<Person>>().Setup(m => m.Provider).Returns(persons.Provider);
            dbSet.As<IQueryable<Person>>().Setup(m => m.Expression).Returns(persons.Expression);
            dbSet.As<IQueryable<Person>>().Setup(m => m.ElementType).Returns(persons.ElementType);
            dbSet.As<IQueryable<Person>>().Setup(m => m.GetEnumerator()).Returns(persons.GetEnumerator());

            var context = new Mock<ApplicationDbContext>();
            context.Setup(c => c.Persons).Returns(dbSet.Object);
            return context;
        }

        [Fact]
        public void FindPersonTest()
        {
            // arrange
            var context = CreateDbContext();

            var service = new PersonService(context.Object);

            // act
            var person = service.FindPerson(1);


            // assert
            Assert.Equal(1, person.Id);
        }

        private IEnumerable<Person> GetFakeData()
        {
            var i = 1;
            var persons = A.ListOf<Person>(26);
            persons.ForEach(x => x.Id = i++);
            return persons.Select(_ => _);
        }
    }
}
