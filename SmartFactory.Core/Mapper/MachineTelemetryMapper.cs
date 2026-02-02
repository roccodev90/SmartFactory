using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between MachineTelemetryEntity and MachineTelemetryDto.
/// </summary>
[Mapper]
public static partial class MachineTelemetryMapper
{
    [MapperIgnoreSource(nameof(MachineTelemetryEntity.Id))]
    [MapperIgnoreSource(nameof(MachineTelemetryEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(MachineTelemetryEntity.Predictions))]
    public static partial MachineTelemetryDto ToDto(MachineTelemetryEntity entity);

    [MapperIgnoreTarget(nameof(MachineTelemetryEntity.Id))]
    [MapperIgnoreTarget(nameof(MachineTelemetryEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(MachineTelemetryEntity.Predictions))]
    public static partial MachineTelemetryEntity ToEntity(MachineTelemetryDto dto);
}
