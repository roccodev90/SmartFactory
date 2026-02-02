using FluentValidation;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Validators;

public class MachineSensorThresholdsDtoValidator : AbstractValidator<MachineSensorThresholdsDto>
{
    public MachineSensorThresholdsDtoValidator()
    {
        RuleFor(x => x.TemperatureWarningThreshold)
            .InclusiveBetween(-50.0, 200.0).WithMessage("TemperatureWarningThreshold deve essere tra -50 e 200.");

        RuleFor(x => x.TemperatureCriticalThreshold)
            .InclusiveBetween(-50.0, 200.0).WithMessage("TemperatureCriticalThreshold deve essere tra -50 e 200.");

        RuleFor(x => x.VibrationWarningThreshold)
            .GreaterThanOrEqualTo(0).WithMessage("VibrationWarningThreshold deve essere >= 0.");

        RuleFor(x => x.VibrationCriticalThreshold)
            .GreaterThanOrEqualTo(0).WithMessage("VibrationCriticalThreshold deve essere >= 0.");

        RuleFor(x => x.PowerWarningThreshold)
            .GreaterThanOrEqualTo(0).WithMessage("PowerWarningThreshold deve essere >= 0.");

        RuleFor(x => x.PowerCriticalThreshold)
            .GreaterThanOrEqualTo(0).WithMessage("PowerCriticalThreshold deve essere >= 0.");
    }
}
