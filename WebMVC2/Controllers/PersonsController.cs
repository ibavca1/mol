using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using WebMVC2.Models;

namespace WebMVC2.Controllers
{
    public class PersonsController : ApiController
    {
        private List<Person> _persones;

        public PersonsController()
        {
            _persones = new List<Person>();
            _persones.AddRange(
                new Person[]
                {
                    new Person() {Id = 0, FirstName = "Anton", LastName = "Belonogov"},
                    new Person() {Id = 1, FirstName = "Anna", LastName = "Belonogova"}
                });
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _persones.AsEnumerable();
        }

        [HttpGet]
        public Person Get(int id)
        {
            return _persones.Find(x => x.Id == id);
        }
    }
}
