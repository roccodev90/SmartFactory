namespace SmartFactory.Core.Models.Entities;

public class MachinePredictionEntity
{
    public Guid Id { get; set; }

    /// <summary>
    /// Foreign key to MachineTelemetryEntity.
    /// </summary>
    public Guid MachineTelemetryId { get; set; }

    /// <summary>
    /// Machine Name (unique).
    /// </summary>
    public required string MachineName { get; set; }

    /// <summary>
    /// Label: Normal | SlowWear | CriticalRisk
    /// </summary>
    public required string Prediction { get; set; }

    /// <summary>
    /// Probability/confidence of prediction (0..1).
    /// </summary>
    public float Probability { get; set; }

    /// <summary>
    /// AI-generated maintenance recommendation (3 critical steps) - only populated for CriticalRisk predictions.
    /// </summary>
    public string? Recommendation { get; set; }

    /// <summary>
    /// Timestamp of the telemetry data this prediction refers to.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Timestamp when the prediction was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public MachineTelemetryEntity MachineTelemetry { get; set; } = null!;
    public ICollection<NotificationEntity> Notifications { get; set; } = new List<NotificationEntity>();
}
