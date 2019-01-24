using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebToTest.Data;
using WebToTest.Data.Entities;
using WebToTest.Models;

namespace WebToTest.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _dbContext;
        public PersonService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database?.EnsureCreated();
        }

        public IEnumerable<PersonModel> AllPersons()
        {
            return _dbContext.Persons
                .Select(x => new PersonModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    DateOfBirth = x.DateOfBirth,
                    City = x.City,
                    State = x.State,
                    Address = x.Address,
                    Telephone = x.Telephone,
                    Email = x.Email
                })
                .OrderBy(x => x.DateOfBirth);
        }

        public PersonModel FindPerson(int id)
        {
            var model = _dbContext.Persons
                .Select(x => new PersonModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    DateOfBirth = x.DateOfBirth,
                    City = x.City,
                    State = x.State,
                    Address = x.Address,
                    Telephone = x.Telephone,
                    Email = x.Email
                })
                .FirstOrDefault(x => x.Id == id);

            return model;
        }
    }

    public interface IPersonService
    {
        IEnumerable<PersonModel> AllPersons();
        PersonModel FindPerson(int id);
    }
}
