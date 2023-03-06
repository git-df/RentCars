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

            RuleFor(x => x.PersonalData.Country)
                .NotEmpty()
                .WithMessage("Musisz podać państwo");

            RuleFor(x => x.PersonalData.City)
                .NotEmpty()
                .WithMessage("Musisz podać miasto");

            RuleFor(x => x.PersonalData.Street)
                .NotEmpty()
                .WithMessage("Musisz podać ulicę");

            RuleFor(x => x.PersonalData.HouseNumber)
                .NotEmpty()
                .WithMessage("Musisz podać numer domu");

            RuleFor(x => x.PersonalData.PhoneNumber)
                .NotEmpty()
                .WithMessage("Musisz podać numer telefonu");

            RuleFor(x => x.PersonalData.PostalCode)
                .NotEmpty()
                .WithMessage("Musisz podać kod pocztowy");

            RuleFor(x => x.PersonalData.PESEL)
                .NotEmpty()
                .WithMessage("Musisz podać kod PESEL");

            RuleFor(x => x.PersonalData.FirstName)
                .NotEmpty()
                .WithMessage("Musisz podać imię");

            RuleFor(x => x.PersonalData.LastName)
                .NotEmpty()
                .WithMessage("Musisz podać nazwisko");

            RuleFor(x => x.PersonalData.DateOfBirth)
                .NotEmpty()
                .WithMessage("Musisz podać datę urodzenia")
                .LessThan(DateTime.UtcNow.AddYears(-5))
                .WithMessage("Podaj poprawną datę");
        }
    }
}
