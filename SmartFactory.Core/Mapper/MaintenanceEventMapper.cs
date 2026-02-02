using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between MaintenanceEventEntity and MaintenanceEventDto.
/// </summary>
[Mapper]
public static partial class MaintenanceEventMapper
{
    [MapperIgnoreSource(nameof(MaintenanceEventEntity.Id))]
    [MapperIgnoreSource(nameof(MaintenanceEventEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(MaintenanceEventEntity.StartedAt))]
    [MapperIgnoreSource(nameof(MaintenanceEventEntity.CompletedAt))]
    public static partial MaintenanceEventDto ToDto(MaintenanceEventEntity entity);

    [MapperIgnoreTarget(nameof(MaintenanceEventEntity.Id))]
    [MapperIgnoreTarget(nameof(MaintenanceEventEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(MaintenanceEventEntity.StartedAt))]
    [MapperIgnoreTarget(nameof(MaintenanceEventEntity.CompletedAt))]
    public static partial MaintenanceEventEntity ToEntity(MaintenanceEventDto dto);
}
