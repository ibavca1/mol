using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate;
using System.ComponentModel.DataAnnotations;
using FluentNHibernate.Mapping;

namespace WebMVC2.Models
{
    public class DepartmentMap:ClassMap<Department>
    {
        public DepartmentMap()
        {
            Id(x => x.Id);
            Map(x => x.Type);
            Map(x => x.Name);
        }
    }
}