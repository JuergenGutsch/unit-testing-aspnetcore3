using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenFu;
using Moq;
using WebToTest.Controllers;
using WebToTest.Data.Entities;
using WebToTest.Services;
using Xunit;
using WebToTest.Models;

namespace WebToTest.Tests
{

    public class PersonControllerTests
    {
        [Fact]
        public void GetPersonsTest()
        {
            // arrange
            var service = new Mock<IPersonService>();

            var persons = GetFakeData();
            service.Setup(x => x.AllPersons()).Returns(persons);

            var controller = new PersonController(service.Object);

            // act
            var results = controller.GetPersons();

            var count = results.Count();

            // assert
            Assert.Equal(26, count);
        }

        [Fact]
        public void GetPerson()
        {
            // arrange
            var service = new Mock<IPersonService>();

            var persons = GetFakeData();
            service.Setup(x => x.FindPerson(1)).Returns(persons.First());

            var controller = new PersonController(service.Object);

            // act
            var result = controller.GetPerson(1);
            var person = result.Value;

            // assert
            Assert.Equal(1, person.Id);
        }

        private IEnumerable<PersonModel> GetFakeData()
        {
            var i = 1;
            var persons = A.ListOf<PersonModel>(26);
            persons.ForEach(x => x.Id = i++);
            return persons.Select(_ => _);
        }
    }
}
