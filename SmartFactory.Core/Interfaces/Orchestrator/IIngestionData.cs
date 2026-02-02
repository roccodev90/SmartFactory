namespace SmartFactory.Core.Interfaces.Orchestrator;

public interface IIngestionData
{
    Task<bool> IngestDataAsync<T>(T data, CancellationToken ct = default) where T : class;
}