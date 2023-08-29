using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username cannot be empty!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirm password cannot be empty!");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password)
                .WithMessage("Confirm password doesn't match the password you entered!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please enter a valid email address!");
        }
    }
}