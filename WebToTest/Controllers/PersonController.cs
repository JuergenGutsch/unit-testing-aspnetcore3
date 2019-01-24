using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebToTest.Data.Entities;
using WebToTest.Models;
using WebToTest.Services;

namespace WebToTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController()]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/Person
        [HttpGet]
        public IEnumerable<PersonModel> GetPersons()
        {
            return _personService.AllPersons();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public  ActionResult<PersonModel> GetPerson(int id)
        {
            var todoItem = _personService.FindPerson(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
}
