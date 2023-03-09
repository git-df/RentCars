using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DummyData
{
    public class DummyBranches
    {
        public static List<Branch> Get()
        {
            return new List<Branch>
            {
                new Branch { Country = "Polska", City = "Warszawa", Street = "Nowy Świat", HouseNumber = 1, PostalCode = "00-000", Name = "Oddział Warszawa", PhoneNumber = 123456789 },
                new Branch { Country = "Polska", City = "Kraków", Street = "Rynek Główny", HouseNumber = 1, PostalCode = "31-000", Name = "Oddział Kraków", PhoneNumber = 987654321 },
                new Branch { Country = "Polska", City = "Gdańsk", Street = "Długi Targ", HouseNumber = 1, PostalCode = "80-831", Name = "Oddział Gdańsk", PhoneNumber = 111222333 }
            };
        }
    }
}
