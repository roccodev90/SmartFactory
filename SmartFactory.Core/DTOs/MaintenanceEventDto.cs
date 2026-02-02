using SmartFactory.Core.Enums;

namespace SmartFactory.Core.DTOs;
public class MaintenanceEventDto
{
    /// <summary>
    /// Type of maintenance event (e.g., "Repair", "Inspection", "Replacement", "Calibration").
    /// </summary>
    public required EventTypeEnum EventType { get; set; }

    /// <summary>
    /// Unique identifier of the machine where the maintenance event occurred.
    /// </summary>
    public required string MachineName { get; set; }

    /// <summary>
    /// Detailed description of the maintenance intervention performed.
    /// Optional field for additional context about the maintenance work.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Unique identifier of the technician/operator who performed the maintenance.
    /// Typically corresponds to the Identity User ID.
    /// </summary>
    public string? TechnicianCompleteName { get; set; }

    /// <summary>
    /// Current status of the maintenance event (e.g., "InProgress", "Completed", "Cancelled").
    /// </summary>
    public required MaintenanceStatusEnum Status { get; set; } 
}