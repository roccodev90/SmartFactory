using Riok.Mapperly.Abstractions;
using SmartFactory.Core.DTOs;
using SmartFactory.Core.Models.Entities;

namespace SmartFactory.Core.Mapper;

/// <summary>
/// Mapper for converting between MachineProfileEntity and MachineProfileDto.
/// </summary>
[Mapper]
public static partial class MachineProfileMapper
{
    [MapperIgnoreSource(nameof(MachineProfileEntity.Id))]
    [MapperIgnoreSource(nameof(MachineProfileEntity.CreatedAt))]
    [MapperIgnoreSource(nameof(MachineProfileEntity.UpdatedAt))]
    public static partial MachineProfileDto ToDto(MachineProfileEntity entity);

    [MapperIgnoreTarget(nameof(MachineProfileEntity.Id))]
    [MapperIgnoreTarget(nameof(MachineProfileEntity.CreatedAt))]
    [MapperIgnoreTarget(nameof(MachineProfileEntity.UpdatedAt))]
    public static partial MachineProfileEntity ToEntity(MachineProfileDto dto);
}
