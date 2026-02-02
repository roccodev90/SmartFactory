namespace SmartFactory.Core.DTOs;

/// <summary>
/// Data Transfer Object for MachineProfileEntity.
/// Contains only properties necessary for services 
/// </summary>
public class MachineProfileDto
{

    /// <summary>
    /// Sensor's name
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
    /// Temperature setpoint for this machine (in Watt).
    /// </summary>
    public double PowerConsumptionSetpoint { get; set; } = 0;

    /// <summary>
    /// Indicates if the machine profile is active.
    /// </summary>
    public bool IsActive { get; set; } = true;
}

