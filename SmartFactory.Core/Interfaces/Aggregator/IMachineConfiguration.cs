using SmartFactory.Core.DTOs;

namespace SmartFactory.Core.Interfaces.Aggregator;
public interface IMachineCpnfiguration
{
    Task<MachineSettingsDto> GetSettingsAsync(string machineName, CancellationToken ct = default);
}