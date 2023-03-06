using Application.Contracts.Persistence;
using Application.Functions.Auth.Command.SignIn;
using Application.Responses;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth.Command.SignUp
{
    public class SignUpCommandHandler : IRequestHandler<SignUpCommand, BaseResponse>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;

        public SignUpCommandHandler(IApplicationUserRepository applicationUserRepository, IMapper mapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            var validator = new SignUpCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
                return new BaseResponse(validationResult);

            var user = await _applicationUserRepository.GetByEmail(request.Email.ToLower());

            if (user != null)
                return new BaseResponse("Użytkownik z takim emailem już istnieje", false);

            var salt = AuthPasswordHashHandler.SaltGenerator();
            var newUser = _mapper.Map<ApplicationUser>(request);

            newUser.Salt = salt;
            newUser.Password = AuthPasswordHashHandler.HashPassword(request.Password, salt);
            newUser.Email = request.Email.ToLower();
            newUser.PersonalData.FirstName = request.PersonalData.FirstName.ToLower();
            newUser.PersonalData.LastName = request.PersonalData.LastName.ToLower();

            var response = await _applicationUserRepository.AddAsync(newUser);

            if (response != null)
                return new BaseResponse("Dodano użytkownika");

            return new BaseResponse(false);
        }
    }
}
