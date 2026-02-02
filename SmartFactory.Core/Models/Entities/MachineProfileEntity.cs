namespace SmartFactory.Core.Models.Entities;

/// <summary>
/// Configuration model for individual machine profiles.
/// </summary>
public class MachineProfileEntity
{
    public Guid Id { get; set; }

    /// <summary>
    /// Machine Name (unique).
    /// </summary>
    public required string MachineName { get; set; }

    /// <summary>
    /// Temperature setpoint for this machine (in Celsius).
    /// </summary>
    public double TemperatureSetpoint { get; set; } = 65.0;

    /// <summary>
    /// Vibration setpoint for this machine (in mm\s).
    /// </summary>
    public double VibrationSetpoint { get; set; } = 0;

    /// <summary>
    /// Power consumption setpoint for this machine (in Watt).
    /// </summary>
    public double PowerConsumptionSetpoint { get; set; } = 0;

    /// <summary>
    /// Indicates if the machine profile is active.
    /// </summary>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Timestamp when the profile was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Timestamp when the profile was last updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
