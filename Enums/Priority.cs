using System.Text.Json.Serialization;

namespace choreScore_Csharp.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]

public enum Priority
{
  Low,
  Medium,
  High
}
