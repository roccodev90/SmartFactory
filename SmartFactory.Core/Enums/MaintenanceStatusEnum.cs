using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SmartFactory.Core.Enums;
/// <summary>
/// The Status of the machine
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum MaintenanceStatusEnum
{
    [EnumMember(Value = "Completed")]
    Completed,
    [EnumMember(Value = "started")]
    started,
    [EnumMember(Value = "In Progress")]
    InProgress,
    [EnumMember(Value = "Idle")]
    Idle,
    [EnumMember(Value = "Cancelled")]
    Cancelled
}