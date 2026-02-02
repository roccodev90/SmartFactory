using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interfaces;

/// <summary>
/// Interface for notification service.
/// Handles critical risk and SlowWear alerts (visual alerts for frontend).
/// </summary>
public interface INotificationService
{
    /// <summary>
    /// Notifies about a critical risk prediction (saves to DB).
    /// </summary>
    Task NotifyCriticalRiskAsync(MachinePredictionDto prediction, CancellationToken cancellationToken = default);

    /// <summary>
    /// Notifies about a SlowWear prediction (saves to DB for visual alerts).
    /// </summary>
    Task NotifySlowWearAsync(MachinePredictionDto prediction, CancellationToken cancellationToken = default);
}
