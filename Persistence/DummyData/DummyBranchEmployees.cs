using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DummyData
{
    public class DummyBranchEmployees
    {
        public static List<BranchEmployee> Get()
        {
            return new List<BranchEmployee>
            {
                new BranchEmployee { Id = 1, EmployeeId = 1, BranchId = 1 },
                new BranchEmployee { Id = 2, EmployeeId = 2, BranchId = 1 },
                new BranchEmployee { Id = 3, EmployeeId = 3, BranchId = 2 },
                new BranchEmployee { Id = 4, EmployeeId = 4, BranchId = 2 },
                new BranchEmployee { Id = 5, EmployeeId = 5, BranchId = 3 },
                new BranchEmployee { Id = 6, EmployeeId = 6, BranchId = 3 },
                new BranchEmployee { Id = 7, EmployeeId = 7, BranchId = 4 },
                new BranchEmployee { Id = 8, EmployeeId = 8, BranchId = 4 },
                new BranchEmployee { Id = 9, EmployeeId = 9, BranchId = 5 },
                new BranchEmployee { Id = 10, EmployeeId = 1, BranchId = 5 },
                new BranchEmployee { Id = 11, EmployeeId = 2, BranchId = 6 },
                new BranchEmployee { Id = 12, EmployeeId = 3, BranchId = 6 },
                new BranchEmployee { Id = 13, EmployeeId = 4, BranchId = 7 },
                new BranchEmployee { Id = 14, EmployeeId = 5, BranchId = 7 },
                new BranchEmployee { Id = 15, EmployeeId = 6, BranchId = 8 },
                new BranchEmployee { Id = 16, EmployeeId = 7, BranchId = 8 },
                new BranchEmployee { Id = 17, EmployeeId = 8, BranchId = 9 },
                new BranchEmployee { Id = 18, EmployeeId = 9, BranchId = 9 }
            };
        }
    }
}
