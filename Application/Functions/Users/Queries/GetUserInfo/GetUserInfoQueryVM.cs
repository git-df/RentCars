using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Users.Queries.GetUserInfo
{
    public class GetUserInfoQueryVM
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public PersonalDataInGetUserInfoQueryViewModel PersonalData { get; set; }
        public EmployeeInGetUserInfoQueryViewModel Employee { get; set; }
    }

    public class PersonalDataInGetUserInfoQueryViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public class EmployeeInGetUserInfoQueryViewModel
    {
        public int Id { get; set; }
        public bool IsAdmin { get; set; } = false;
        public int? BranchId { get; set; }
    }
}
