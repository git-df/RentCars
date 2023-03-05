using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; } = false;

        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();

        public int? BranchId { get; set; }
        public Branch? Branch { get; set; }
    }
}
