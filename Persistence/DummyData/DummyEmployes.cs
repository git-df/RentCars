using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DummyData
{
    public class DummyEmployes
    {
        public static List<Employee> Get()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, IsAdmin = false },
                new Employee { Id = 2, IsAdmin = false },
                new Employee { Id = 3, IsAdmin = false },
                new Employee { Id = 4, IsAdmin = false },
                new Employee { Id = 5, IsAdmin = false },
                new Employee { Id = 6, IsAdmin = false },
                new Employee { Id = 7, IsAdmin = false },
                new Employee { Id = 8, IsAdmin = false },
                new Employee { Id = 9, IsAdmin = false },
            };
        }
    }
}
