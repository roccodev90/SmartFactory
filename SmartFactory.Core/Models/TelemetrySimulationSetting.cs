namespace SmartFactory.Core.Models;

/// <summary>
/// Configuration model for telemetry simulation parameters.
/// </summary>
public class TelemetrySimulationSettings
{
    /// <summary>
    /// Probability of generating anomalous data (0.0 to 1.0).
    /// Default: 0.15 (15%).
    /// </summary>
    public double AnomalyProbability { get; set; } = 0.15;

    /// <summary>
    /// Ratio of anomalies that are CriticalRisk vs SlowWear (0.0 to 1.0).
    /// Default: 0.4 (40% of anomalies are CriticalRisk).
    /// </summary>
    public double CriticalRiskRatio { get; set; } = 0.4;

    /// <summary>
    /// Probability of machine being in Maintenance state (0.0 to 1.0).
    /// Default: 0.05 (5%).
    /// </summary>
    public double MaintenanceProbability { get; set; } = 0.05;

    /// <summary>
    /// Probability of machine being in Idle state (0.0 to 1.0).
    /// Default: 0.10 (10%).
    /// </summary>
    public double IdleProbability { get; set; } = 0.10;

    /// <summary>
    /// Interval in seconds between telemetry generation cycles.
    /// Default: 1 second.
    /// </summary>
    public int GenerationIntervalSeconds { get; set; } = 1;
}
