using Application.Contracts.Persistence;
using Application.Responses;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth.Command.SignIn
{
    public class SignInCommandHandler : IRequestHandler<SignInCommand, BaseResponse<string>>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IConfiguration _configuration;

        public SignInCommandHandler(IApplicationUserRepository applicationUserRepository, IConfiguration configuration)
        {
            _applicationUserRepository = applicationUserRepository;
            _configuration = configuration;
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

            if(AuthPasswordHashHandler.HashPassword(request.Password, user.Salt) != user.Password)
                return new BaseResponse<string>("Złe hasło", false);

            var token = Generate(user);

            return new BaseResponse<string>(token, "Poprawnie zalogowano");
        }

        private string Generate(ApplicationUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creditials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
            };

            if (user.PersonalData != null)
            {
                claims.Append(new Claim(ClaimTypes.GivenName, user.PersonalData.FirstName));
                claims.Append(new Claim(ClaimTypes.Surname, user.PersonalData.LastName));
            }

            if (user.Employee != null)
            {
                if (user.Employee.IsAdmin)
                {
                    claims.Append(new Claim(ClaimTypes.Role, "admin"));
                }
                else
                {
                    claims.Append(new Claim(ClaimTypes.Role, "employee"));
                }
            }
            else
            {
                claims.Append(new Claim(ClaimTypes.Role, "customer"));
            }

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(15),
                signingCredentials: creditials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
