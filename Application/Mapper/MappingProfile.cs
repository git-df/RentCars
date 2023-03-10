using Application.Functions.Auth.Command.SignUp;
using Application.Functions.Cars.Queries.GetCarsByModel;
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
            CreateMap<PersonalData, PersonalDataInGetUserInfoQueryViewModel>();
            CreateMap<PersonalDataInSignUpCommand, PersonalData>();
            CreateMap<Employee,  EmployeeInGetUserInfoQueryViewModel>();
            CreateMap<ApplicationUser, GetUserInfoQueryVM>();
            CreateMap<SignUpCommand, ApplicationUser>();
            CreateMap<GetCarsByModelQueryVM, Car>();
            CreateMap<ModelInGetCarsByModelQueryVM, ModelOfCars>();
                
        }
    }
}
