namespace SmartFactory.Core.Interfaces;
/// <summary>
/// Comunicazione push verso il frontend (SignalR).
/// </summary>
public interface IRealTime
{
    // T può essere AlertDto, TelemetryDto, o NotificationDto
    Task BroadcastEntityAsync<T>(T data, CancellationToken ct = default) where T : class;
}