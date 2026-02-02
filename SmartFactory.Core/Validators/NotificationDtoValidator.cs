using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class NotificationDtoValidator : AbstractValidator<NotificationDto>
{
    public NotificationDtoValidator()
    {
        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("MachineName è obbligatorio.")
            .MaximumLength(30).WithMessage("MachineName può avere al massimo 30 caratteri.");

        RuleFor(x => x.Type)
            .NotEmpty().WithMessage("Type è obbligatorio.")
            .MaximumLength(50).WithMessage("Type può avere al massimo 50 caratteri.");

        RuleFor(x => x.Message)
            .NotEmpty().WithMessage("Message è obbligatorio.");
    }
}
