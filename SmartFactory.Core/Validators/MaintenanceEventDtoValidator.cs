using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MaintenanceEventDtoValidator : AbstractValidator<MaintenanceEventDto>
{
    public MaintenanceEventDtoValidator()
    {
        RuleFor(x => x.EventType)
            .IsInEnum().WithMessage("EventType non valido.");

        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("MachineName è obbligatorio.")
            .Length(7, 30).WithMessage("MachineName deve essere tra 7 e 30 caratteri.");

        RuleFor(x => x.TechnicianCompleteName)
            .MaximumLength(450).WithMessage("TechnicianCompleteName può avere al massimo 450 caratteri.")
            .When(x => !string.IsNullOrEmpty(x.TechnicianCompleteName));

        RuleFor(x => x.Status)
            .IsInEnum().WithMessage("Status non valido.");
    }
}
