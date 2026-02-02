using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between MachinePredictionEntity and MachinePredictionDto.
/// </summary>
[Mapper]
public static partial class MachinePredictionMapper
{
    [MapperIgnoreSource(nameof(MachinePredictionEntity.Id))]
    [MapperIgnoreSource(nameof(MachinePredictionEntity.MachineTelemetryId))]
    [MapperIgnoreSource(nameof(MachinePredictionEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(MachinePredictionEntity.MachineTelemetry))]
    [MapperIgnoreSource(nameof(MachinePredictionEntity.Notifications))]
    public static partial MachinePredictionDto ToDto(MachinePredictionEntity entity);

    [MapperIgnoreTarget(nameof(MachinePredictionEntity.Id))]
    [MapperIgnoreTarget(nameof(MachinePredictionEntity.MachineTelemetryId))]
    [MapperIgnoreTarget(nameof(MachinePredictionEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(MachinePredictionEntity.MachineTelemetry))]
    [MapperIgnoreTarget(nameof(MachinePredictionEntity.Notifications))]
    public static partial MachinePredictionEntity ToEntity(MachinePredictionDto dto);
}
