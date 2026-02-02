using SmartFactory.Core.Enums;

namespace SmartFactory.Core.Models.Entities;

public class MaintenanceEventEntity
{
    public Guid Id { get; set; }

    /// <summary>
    /// Machine Name where the maintenance event occurred.
    /// </summary>
    public required string MachineName { get; set; }

    /// <summary>
    /// Type of maintenance event (e.g., "Repair", "Inspection", "Replacement").
    /// </summary>
    public required EventTypeEnum EventType { get; set; }

    /// <summary>
    /// Description of the maintenance intervention.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Complete name of the technician/operator who performed the maintenance (Identity User ID).
    /// </summary>
    public string? TechnicianCompleteName { get; set; }

    /// <summary>
    /// Status of the maintenance event (e.g., "InProgress", "Completed", "Cancelled").
    /// </summary>
    public MaintenanceStatusEnum Status { get; set; }

    /// <summary>
    /// Timestamp when the record was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Timestamp when the maintenance event started.
    /// </summary>
    public DateTime StartedAt { get; set; }

    /// <summary>
    /// Timestamp when the maintenance event was completed (nullable if still in progress).
    /// </summary>
    public DateTime? CompletedAt { get; set; }
}
