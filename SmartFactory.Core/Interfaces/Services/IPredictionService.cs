using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interfaces;
public interface IPredictionService
{
    /// <summary>
    /// Esegue l'analisi del rischio in tempo reale.
    /// Nota: È sincrono perché l'inferenza locale su CPU/GPU è solitamente bloccante e veloce (uso ML.Net).
    /// </summary>
    MachinePredictionDto Predict(MachineTelemetryDto telemetry);
}