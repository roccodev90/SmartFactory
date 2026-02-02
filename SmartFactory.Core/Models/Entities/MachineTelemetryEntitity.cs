using SmartFactory.Core.Enums;

namespace SmartFactory.Core.Models.Entities;

public class MachineTelemetryEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public required string MachineName { get; set; }

    public double Temperature { get; set; }

    public double Vibration { get; set; }

    public double PowerConsumption { get; set; }

    public MachineStatusEnum Status { get; set; }

    public DateTime Timestamp { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<MachinePredictionEntity> Predictions { get; set; } = new List<MachinePredictionEntity>();
}
