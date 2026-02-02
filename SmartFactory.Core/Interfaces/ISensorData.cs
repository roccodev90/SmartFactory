namespace SmartFactory.Core.Interfaces;

public interface ISensorData
{
    // Il nome "umano" della macchina (es. "MAC-01")
    string MachineName { get; }
    
    // Il momento esatto della rilevazione
    DateTime Timestamp { get; }
}