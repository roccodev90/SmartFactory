namespace SmartFactory.Core.Models.Entities;

public class MachineSensorThresholdsEntity
{
    public Guid Id { get; set; }

    public string MachineName { get; set; } = string.Empty;

    public double TemperatureWarningThreshold { get; set; } = 85.0;

    public double TemperatureCriticalThreshold { get; set; } = 100.0;

    public double VibrationWarningThreshold { get; set; } = 15.0;

    public double VibrationCriticalThreshold { get; set; } = 25.0;

    public double PowerWarningThreshold { get; set; } = 2000.0;

    public double PowerCriticalThreshold { get; set; } = 3000.0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }
}
