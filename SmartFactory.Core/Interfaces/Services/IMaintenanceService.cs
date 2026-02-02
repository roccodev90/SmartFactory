using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interface.Services;
public interface IMaintenanceService
{
     /// <summary>
    /// Avvia un intervento: crea l'evento e mette la macchina in stato di manutenzione.
    /// </summary>
    Task<MaintenanceEventDto> StartMaintenanceAsync(
        MaintenanceEventDto dto, 
        string? technicianId = null, 
        CancellationToken ct = default);

    /// <summary>
    /// Chiude l'intervento, riattiva la macchina e pulisce gli alert pendenti.
    /// </summary>
    Task<MaintenanceEventDto?> CompleteMaintenanceAsync(Guid eventId, CancellationToken ct = default);

    /// <summary>
    /// Recupera i nomi delle macchine attualmente in manutenzione.
    /// </summary>
    Task<IReadOnlyList<string>> GetMachineNamesInMaintenanceAsync(CancellationToken ct = default);

    /// <summary>
    /// Recupera la cronologia o lo stato attuale degli interventi per una macchina specifica.
    /// </summary>
    Task<IReadOnlyList<MaintenanceEventDto>> GetByMachineNameAsync(
        string machineName, 
        bool onlyInProgress = false, 
        CancellationToken ct = default);

    /// <summary>
    /// Restituisce la lista di tutti gli eventi di manutenzione del sistema, con filtri opzionali.
    /// </summary>
    Task<IReadOnlyList<MaintenanceEventDto>> ListAsync(
        bool? inProgressOnly = null, 
        CancellationToken ct = default);
}