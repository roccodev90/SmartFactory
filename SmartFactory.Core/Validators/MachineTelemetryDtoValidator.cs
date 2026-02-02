using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MachineTelemetryDtoValidator : AbstractValidator<MachineTelemetryDto>
{
    private const string MachineNamePattern = @"^[A-Za-z0-9_\-]+$";

    public MachineTelemetryDtoValidator()
    {
        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("MachineName è obbligatorio.")
            .Length(1, 30).WithMessage("MachineName deve essere tra 1 e 30 caratteri.")
            .Matches(MachineNamePattern).WithMessage("MachineName può contenere solo lettere, numeri, trattini e underscore.");

        RuleFor(x => x.Temperature)
            .InclusiveBetween(-50.0, 200.0).WithMessage("Temperature deve essere tra -50 e 200 °C.");

        RuleFor(x => x.Vibration)
            .InclusiveBetween(0.0, 200.0).WithMessage("Vibration deve essere tra 0 e 200 mm/s.");

        RuleFor(x => x.PowerConsumption)
            .InclusiveBetween(0.0, 100_000.0).WithMessage("PowerConsumption deve essere tra 0 e 100000 W.");

        RuleFor(x => x.Status)
            .IsInEnum().WithMessage("Status non valido.");

        RuleFor(x => x.Timestamp)
            .NotEmpty().WithMessage("Timestamp è obbligatorio.");
    }
}
