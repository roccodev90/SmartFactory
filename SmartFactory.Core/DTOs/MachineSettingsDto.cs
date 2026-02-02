namespace SmartFactory.Core.DTOs;
public class MachineSettingsDto
{
    /// <summary>
    /// Nome della macchina a cui si riferiscono queste impostazioni.
    /// </summary>
    public required string MachineName { get; set; }

    /// <summary>
    /// Contiene i Setpoint (Temperature, Vibration, Power) e lo stato Active.
    /// </summary>
    public required MachineProfileDto Profile { get; set; }

    /// <summary>
    /// Contiene le soglie di Warning e Critical per tutti i sensori.
    /// </summary>
    public required MachineSensorThresholdsDto Thresholds { get; set; }
    
    /// <summary>
    /// Timestamp dell'ultima configurazione aggiornata.
    /// </summary>
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}