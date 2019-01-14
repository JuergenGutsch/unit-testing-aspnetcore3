using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebToTest.Data;
using WebToTest.Data.Entities;

namespace WebToTest.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _dbContext;
        public PersonService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Person> AllPersons()
        {
            return _dbContext.Persons.OrderBy(x => x.DateOfBirth);
        }

        public Person FindPerson(int id)
        {
            return _dbContext.Persons.FirstOrDefault(x => x.Id == id);
        }
    }

    public interface IPersonService
    {
        IEnumerable<Person> AllPersons();
        Person FindPerson(int id);
    }
}
