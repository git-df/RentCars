using Application.Functions.Users.Queries.GetUserInfo;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<PersonalData, PersonalDataInUserInfoViewModel>();
            CreateMap<Employee,  EmployeeInUserInfoViewModel>();
            CreateMap<ApplicationUser, UserInfoViewModel>();
        }
    }
}
