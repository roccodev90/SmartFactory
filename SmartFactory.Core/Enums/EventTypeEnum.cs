using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters; // Per [EnumMember]

namespace SmartFactory.Core.Enums;
/// <summary>
/// The Status of the machine
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EventTypeEnum
{
    [EnumMember(Value = "In riparazione")]
    Repair,
    [EnumMember(Value = "Inspection")]
    Inspection,
    [EnumMember(Value = "Replacement")]
    Replacement,
    [EnumMember(Value = "Calibration")]
    Calibration,
    [EnumMember(Value = "Emergency")]
    Emergency
}