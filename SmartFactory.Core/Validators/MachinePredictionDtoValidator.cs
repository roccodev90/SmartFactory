using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MachinePredictionDtoValidator : AbstractValidator<MachinePredictionDto>
{
    private const string MachineNamePattern = @"^[A-Za-z0-9_\-]+$";
    private const string PredictionPattern = "^(Normal|SlowWear|CriticalRisk)$";

    public MachinePredictionDtoValidator()
    {
        RuleFor(x => x.MachineName)
            .NotEmpty().WithMessage("Machine Name è obbligatorio.")
            .MaximumLength(30).WithMessage("MachineName può avere al massimo 30 caratteri.")
            .Matches(MachineNamePattern).WithMessage("MachineName può contenere solo lettere, numeri, trattini e underscore.");

        RuleFor(x => x.Prediction)
            .NotEmpty().WithMessage("Prediction è obbligatorio.")
            .MaximumLength(20).WithMessage("Prediction può avere al massimo 20 caratteri.")
            .Matches(PredictionPattern).WithMessage("Prediction deve essere Normal, SlowWear o CriticalRisk.");

        RuleFor(x => x.Probability)
            .InclusiveBetween(0f, 1f).WithMessage("Probability deve essere tra 0 e 1.");

        RuleFor(x => x.Timestamp)
            .NotEmpty().WithMessage("Timestamp è obbligatorio.");
    }
}
