using System.Linq.Expressions;

namespace SmartFactory.Core.Interfaces.Repositories;
/// <summary>
///  Gestione della persistenza a lungo termine
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : class
{

    // funziona per Macchine, Telemetria, Eventi, ecc.
    Task<T?> GetByIdAsync(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Recupera tutti i nomi univoci delle macchine registrate.
    /// Corrisponde alla lista di quelli che il frontend chiamerebbe "IDs".
    /// </summary>
    Task<IReadOnlyList<string>> GetAllNamesAsync(CancellationToken ct = default);

    // <summary>
    /// Recupera i nomi registrati e attivi.
    /// </summary>
    Task<IReadOnlyList<(string, bool)>> GetAllNamesAndIsActiveAsync(CancellationToken ct = default);

    // Metodo generico per query con filtri e ordinamento
    Task<IReadOnlyList<T>> GetFilteredAndSortedAsync(
        Expression<Func<T, bool>>? filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        CancellationToken ct = default);

    // add data to database
    Task AddAsync(T entity, CancellationToken ct = default);

    /// <summary>
    /// /// <summary>
    /// Checks if a ID is registered.
    /// </summary>
    /// <param name="machineId">The machine ID to check</param>
    /// <returns>True if the machine is registered, false otherwise</returns>
    /// </summary>
    Task<bool> ExistsAsync(Expression<Func<T, bool>> filter, CancellationToken ct = default);

    /// <summary>
    /// Checks if a ID is registered asynchronously.
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<bool> AnyAsync(Expression<Func<T, bool>> filter, CancellationToken ct = default);

    /// <summary>
    /// Gets the count of registered objects.
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<int> CountAsync(Expression<Func<T, bool>>? filter = null, CancellationToken ct = default);
}