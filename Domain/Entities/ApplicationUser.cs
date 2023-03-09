using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;

        public int? PersonalDataId { get; set; }
        public PersonalData PersonalData { get; set; } = new PersonalData();

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public List<Rent> Rents { get; set; } = new List<Rent>();
    }
}
