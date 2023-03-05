using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonalData : Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public int PESEL { get; set; }

        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
    }
}
