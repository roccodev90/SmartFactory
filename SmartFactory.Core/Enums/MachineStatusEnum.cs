using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SmartFactory.Core.Enums;
/// <summary>
/// The Status of the machine
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
/// 
public enum MachineStatusEnum
{
    [EnumMember(Value = "Unknown")]
    Unknown,
    [EnumMember(Value = "Running")]
    Running,
    [EnumMember(Value = "Idle")]
    Idle, 
    [EnumMember(Value = "Warning")]
    Warning,
    [EnumMember(Value = "Fault")]
    Fault,
    [EnumMember(Value = "Maintenance")]
    Maintenance
}