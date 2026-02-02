using SmartFactory.Core.Enums;

namespace SmartFactory.Core.DTOs;

/// <summary>
/// Data Transfer Object for MachineTelemetryEntity.
/// Contains only properties necessary for services (excludes Id, CreatedAt, navigation properties).
/// </summary>
public class MachineTelemetryDto
{
    public required string MachineName {get; set;} = string.Empty;

    /// <summary>
    /// Temperature reading in degrees Celsius. Range: -50.0 to 200.0.
    /// </summary>
    public double Temperature { get; set; }

    /// <summary>
    /// Vibration measurement in mm/s. Range: 0.0 to 200.0.
    /// </summary>
    public double Vibration { get; set; }

    /// <summary>
    /// Power consumption in watts. Range: 0.0 to 100000.0.
    /// </summary>
    public double PowerConsumption { get; set; }

    /// <summary>
    /// Current operational status of the machine (e.g., Running, Stopped, Maintenance).
    /// </summary>
    public MachineStatusEnum Status { get; set; }
    /// <summary>
    /// Timestamp when the telemetry data was captured from the sensors.
    /// </summary>
    public DateTime Timestamp { get; set; }
}