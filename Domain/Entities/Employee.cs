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

        public List<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();
    }
}
