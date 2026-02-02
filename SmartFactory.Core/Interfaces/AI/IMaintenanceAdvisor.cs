using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interfaces;
public interface IMaintenanceAdvisor
{
    /// <summary>
    /// Genera raccomandazioni basate su telemetria e contesto tecnico.
    /// </summary>
    Task<string> GetMaintenanceRecommendationAsync(
        MachineTelemetryDto telemetry,
        MachinePredictionDto prediction,
        string manualContext,
        CancellationToken cancellationToken = default);
}