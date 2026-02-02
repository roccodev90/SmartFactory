using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MachineSettingsDtoValidator : AbstractValidator<MachineSettingsDto>
{
    private const string MachineNamePattern = @"^[A-Za-z0-9_\-]+$";

    public MachineSettingsDtoValidator()
    {
        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("MachineName è obbligatorio.")
            .MaximumLength(30).WithMessage("MachineName può avere al massimo 30 caratteri.")
            .Matches(MachineNamePattern).WithMessage("MachineName può contenere solo lettere, numeri, trattini e underscore.");

        RuleFor(x => x.Profile)
            .NotNull().WithMessage("Profile è obbligatorio.")
            .SetValidator(new MachineProfileDtoValidator());

        RuleFor(x => x.Thresholds)
            .NotNull().WithMessage("Thresholds è obbligatorio.")
            .SetValidator(new MachineSensorThresholdsDtoValidator());
    }
}
