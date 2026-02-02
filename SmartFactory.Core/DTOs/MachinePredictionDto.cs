namespace SmartFactory.Core.DTOs;

/// <summary>
/// Data Transfer Object for MachinePredictionEntity.
/// Contains only properties necessary for services (excludes Id, MachineTelemetryId, navigation properties).
/// </summary>
public class MachinePredictionDto
{
    public required string MachineName {get; set;} = string.Empty;
    /// <summary>
    /// ML model prediction label: "Normal", "SlowWear", or "CriticalRisk".
    /// Indicates the predicted condition of the machine.
    /// </summary>
    public required string Prediction { get; set; }

    /// <summary>
    /// Confidence/probability of the prediction, ranging from 0.0 to 1.0.
    /// Higher values indicate higher confidence in the prediction.
    /// </summary>
    public float Probability { get; set; }

    /// <summary>
    /// AI-generated maintenance recommendation containing 3 critical steps.
    /// Only populated for "CriticalRisk" predictions; null otherwise.
    /// </summary>
    public string? Recommendation { get; set; }

    /// <summary>
    /// Timestamp of the telemetry data this prediction refers to.
    /// Matches the Timestamp of the associated MachineTelemetryDto.
    /// </summary>
    public DateTime Timestamp { get; set; }
}

