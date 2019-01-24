using Xunit;
using System.Linq;
using WebToTest.Data.Entities;
using GenFu;
using Moq;
using WebToTest.Services;
using WebToTest.Controllers;
using System.Collections.Generic;
using WebToTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace WebToTest.IntegrationTests
{
    public class PersonIntegrationTest
    {
        [Fact]
        public void GetPersonsTest()
        {
            // arrange
            var context = CreateDbContext();

            var service = new PersonService(context.Object);

            var controller = new PersonController(service);

            // act
            var results = controller.GetPersons();

            var count = results.Count();

            // assert
            Assert.Equal(26, count);
        }

        [Fact]
        public void GetPersonTest()
        {
            // arrange
            var context = CreateDbContext();

            var service = new PersonService(context.Object);

            var controller = new PersonController(service);

            // act
            var result = controller.GetPerson(1);
            var person = result.Value;

            // assert
            Assert.Equal(1, person.Id);
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

        private IEnumerable<Person> GetFakeData()
        {
            var i = 1;
            var persons = A.ListOf<Person>(26);
            persons.ForEach(x => x.Id = i++);
            return persons.Select(_ => _);
        }
    }
}
