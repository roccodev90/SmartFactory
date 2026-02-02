using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between MachineSensorThresholdsEntity and MachineSensorThresholdsDto.
/// </summary>
[Mapper]
public static partial class MachineSensorThresholdsMapper
{
    [MapperIgnoreSource(nameof(MachineSensorThresholdsEntity.Id))]
    [MapperIgnoreSource(nameof(MachineSensorThresholdsEntity.MachineName))]
    [MapperIgnoreSource(nameof(MachineSensorThresholdsEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(MachineSensorThresholdsEntity.UpdatedAt))]
    public static partial MachineSensorThresholdsDto ToDto(MachineSensorThresholdsEntity entity);

    [MapperIgnoreTarget(nameof(MachineSensorThresholdsEntity.Id))]
    [MapperIgnoreTarget(nameof(MachineSensorThresholdsEntity.MachineName))]
    [MapperIgnoreTarget(nameof(MachineSensorThresholdsEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(MachineSensorThresholdsEntity.UpdatedAt))]
    public static partial MachineSensorThresholdsEntity ToEntity(MachineSensorThresholdsDto dto);
}
