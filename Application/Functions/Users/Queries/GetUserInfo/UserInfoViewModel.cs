using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Users.Queries.GetUserInfo
{
    public class UserInfoViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public PersonalDataInUserInfoViewModel PersonalData { get; set; }
        public EmployeeInUserInfoViewModel Employee { get; set; }
    }

    public class PersonalDataInUserInfoViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class EmployeeInUserInfoViewModel
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; } = false;
        public int? BranchId { get; set; }
    }

}
