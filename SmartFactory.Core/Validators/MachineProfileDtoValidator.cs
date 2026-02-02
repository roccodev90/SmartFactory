using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MachineProfileDtoValidator : AbstractValidator<MachineProfileDto>
{
    private const string MachineNamePattern = @"^[A-Za-z0-9_\-]+$";

    public MachineProfileDtoValidator()
    {
        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("MachineName è obbligatorio.")
            .MaximumLength(30).WithMessage("MachineName può avere al massimo 30 caratteri.")
            .Matches(MachineNamePattern).WithMessage("MachineName può contenere solo lettere, numeri, trattini e underscore.");

        RuleFor(x => x.TemperatureSetpoint)
            .InclusiveBetween(-50.0, 200.0).WithMessage("TemperatureSetpoint deve essere tra -50 e 200 °C.");

        RuleFor(x => x.VibrationSetpoint)
            .GreaterThanOrEqualTo(0).WithMessage("VibrationSetpoint deve essere >= 0.");

        RuleFor(x => x.PowerConsumptionSetpoint)
            .GreaterThanOrEqualTo(0).WithMessage("PowerConsumptionSetpoint deve essere >= 0.");
    }
}
