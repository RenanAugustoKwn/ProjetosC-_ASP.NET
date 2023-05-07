using FluentValidation;
using SquadManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.email).NotNull().WithMessage("Email Vázio");
            RuleFor(user => user.email).EmailAddress().WithMessage("Email Inválido");
            RuleFor(user => user.passaword).NotNull();
        }

    }
}
