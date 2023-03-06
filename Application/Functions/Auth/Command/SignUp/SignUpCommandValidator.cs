using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth.Command.SignUp
{
    public class SignUpCommandValidator : AbstractValidator<SignUpCommand>
    {
        public SignUpCommandValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Podaj poprawny email")
                .NotEmpty()
                .WithMessage("Musisz podać email");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Musisz podać hasło")
                .MinimumLength(8)
                .WithMessage("Hasło musi zawierać 8 znaków");
        }
    }
}
