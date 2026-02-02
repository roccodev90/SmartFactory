namespace SmartFactory.Core.Interface; 

public interface IMachineSettingsProvider<T, U>
{
    Task<(T t, U u)> GetAsync(T param, CancellationToken cancellationToken);
}