using Application.Contracts.Persistence;
using Application.Functions.Auth.Command;
using Application.Responses;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Users.Queries.GetUserInfo
{
    public class GetUserInfoQueryHandler : IRequestHandler<GetUserInfoQuery, BaseResponse<GetUserInfoQueryViewModel>>
    {
        private readonly IApplicationUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserInfoQueryHandler(IMapper mapper, IApplicationUserRepository applicationUserRepository)
        {
            _mapper = mapper;
            _userRepository = applicationUserRepository;
        }

        public async Task<BaseResponse<GetUserInfoQueryViewModel>> Handle(GetUserInfoQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetById(request.Id);
            
            if (user == null)
                return new BaseResponse<GetUserInfoQueryViewModel>("Nie ma takiego użytkownika", false);

            return (new BaseResponse<GetUserInfoQueryViewModel>(_mapper.Map<GetUserInfoQueryViewModel>(user)));
        }
    }
}
