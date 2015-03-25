using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC2.Models
{
    public class myRepo
    {
        private List<Person> _personsList;

        private List<Department> _departmentsList;

        public myRepo()
        {
            _personsList = new List<Person>();
            _personsList.AddRange(
                new[]
                {
                    new Person {Id = 0, FirstName = "Anton", LastName = "Belonogov"},
                    new Person {Id = 1, FirstName = "Anna", LastName = "Belonogova"}
                });
            _departmentsList = new List<Department>();
        }
    }
}