using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BranchEmployee
    {
        public int Id { get; set; }
        
        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public int? BranchId { get; set; }
        public Branch Branch { get; set; } = new Branch();
    }
}
