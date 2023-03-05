using Application.Contracts.Persistence;
using Application.Responses;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Users.Queries.GetUserInfo
{
    public class GetUserInfoQueryHandler : IRequestHandler<GetUserInfoQuery, BaseResponse<UserInfoViewModel>>
    {
        private readonly IApplicationUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserInfoQueryHandler(IMapper mapper, IApplicationUserRepository applicationUserRepository)
        {
            _mapper = mapper;
            _userRepository = applicationUserRepository;
        }

        public async Task<BaseResponse<UserInfoViewModel>> Handle(GetUserInfoQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetWithPersonalDataAndAddressAsync(request.Id);
            
            if (user == null)
                return new BaseResponse<UserInfoViewModel>("Nie ma takiego użytkownika", false);

            return new BaseResponse<UserInfoViewModel>(_mapper.Map<UserInfoViewModel>(user));
        }
    }
}
