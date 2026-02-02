
namespace SmartFactory.Core.DTOs;
public class MachineSensorThresholdsDto
{
   public double TemperatureWarningThreshold { get; set; }

    public double TemperatureCriticalThreshold { get; set; }

    public double VibrationWarningThreshold { get; set; }

    public double VibrationCriticalThreshold { get; set; }

    public double PowerWarningThreshold { get; set; }

    public double PowerCriticalThreshold { get; set; }
}