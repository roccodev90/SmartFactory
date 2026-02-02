namespace SmartFactory.Core.Models.Entities;

public class NotificationEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string MachineName { get; set; } = string.Empty;

    public Guid? MachinePredictionId { get; set; }

    public DateTime? Timestamp { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public bool IsRead { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ReadAt { get; set; }

    public MachinePredictionEntity? MachinePrediction { get; set; }
}
