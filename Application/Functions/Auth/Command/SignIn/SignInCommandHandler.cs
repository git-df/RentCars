using Application.Contracts.Persistence;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth.Command.SignIn
{
    public class SignInCommandHandler : IRequestHandler<SignInCommand, BaseResponse<string>>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IJwtProvider _jwtProvider;

        public SignInCommandHandler(IApplicationUserRepository applicationUserRepository, IJwtProvider jwtProvider)
        {
            _applicationUserRepository = applicationUserRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<string>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            var validator = new SignInCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid)
                return new BaseResponse<string>(validationResult);

            var user = await _applicationUserRepository.GetByEmail(request.Email.ToLower());

            if (user == null)
                return new BaseResponse<string>("Nie ma takiego użytkownika", false);

            //tu trzeba dodac sprawdzanie hasła

            string token = _jwtProvider.Generate(user);

            throw new NotImplementedException();
        }
    }
}
