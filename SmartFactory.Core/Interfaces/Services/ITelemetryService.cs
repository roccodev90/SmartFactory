using System.Threading.Channels;
using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interfaces.Services;

public interface ITelemetryService
{
    // Espone solo la lettura: il Core processa i dati che passano di qui
    ChannelReader<MachineTelemetryDto> Reader { get; }
    
    // Metodo specifico per il flusso principale della fabbrica
    Task BroadcastTelemetryAsync(
        MachineTelemetryDto telemetry, 
        MachinePredictionDto? prediction = null);
}