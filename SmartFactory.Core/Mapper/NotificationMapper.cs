using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between NotificationEntity and NotificationDto.
/// </summary>
[Mapper]
public static partial class NotificationMapper
{
    [MapperIgnoreSource(nameof(NotificationEntity.Id))]
    [MapperIgnoreSource(nameof(NotificationEntity.MachinePredictionId))]
    [MapperIgnoreSource(nameof(NotificationEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(NotificationEntity.ReadAt))]
    [MapperIgnoreSource(nameof(NotificationEntity.MachinePrediction))]
    [MapperIgnoreTarget(nameof(NotificationDto.MachinePrediction))]
    public static partial NotificationDto ToDto(NotificationEntity entity);

    [MapperIgnoreSource(nameof(NotificationDto.MachinePrediction))]
    [MapperIgnoreTarget(nameof(NotificationEntity.Id))]
    [MapperIgnoreTarget(nameof(NotificationEntity.MachinePredictionId))]
    [MapperIgnoreTarget(nameof(NotificationEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(NotificationEntity.ReadAt))]
    [MapperIgnoreTarget(nameof(NotificationEntity.MachinePrediction))]
    public static partial NotificationEntity ToEntity(NotificationDto dto);
}
