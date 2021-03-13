using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators{
    public class UserValidator : AbstractValidator<User>{
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("A entidade não pode ser nula");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O campo name não pode ser vazio")

                .NotNull()
                .WithMessage("O campo name não pode ser nulo")

                .MaximumLength(80)
                .WithMessage("O campo name deve conter no maximo 80 caracteres")

                .MinimumLength(3)
                .WithMessage("O campo name deve conter no minimo 3 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O Campo email não pode ser vazio")

                .NotNull()
                .WithMessage("O campo email não pode ser nulo")

                .MaximumLength(180)
                .WithMessage("O campo email deve conter no maximo 180 caracteres")

                .MinimumLength(10)
                .WithMessage("O campo name deve conter no minimo 10 caracteres")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O campo email está inválido");
                

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("O campo senha não pode ser vazio")

                .NotNull()
                .WithMessage("O campo senha não pode ser nulo")

                .MaximumLength(30)
                .WithMessage("O campo senha deve conter no maximo 30 caracteres")

                .MinimumLength(8)
                .WithMessage("O campo senha deve conter no minimo 8 caracteres");
        }
    }
}