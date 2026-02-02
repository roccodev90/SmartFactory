namespace SmartFactory.Core.Interfaces.State;

public interface IStateRepository<T> where T : class
{
    // Salva lo stato 
    Task SetLatestAsync(T param, T state, CancellationToken ct = default);

    // Recupera lo stato per una singola macchina
    Task<T?> GetLatestAsync(T param, CancellationToken ct = default);

    // Restituisce l'ultimo stato di tutti i params registrati
    Task<IReadOnlyList<T>> GetAllLatestStatesAsync(CancellationToken ct = default);
}