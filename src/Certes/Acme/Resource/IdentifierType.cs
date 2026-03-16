using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Certes.Json;

namespace Certes.Acme.Resource;

/// <summary>
/// Represents type of <see cref="Identifier"/>.
/// </summary>
[JsonConverter(typeof(JsonEnumMemberStringEnumConverter))]
public enum IdentifierType
{
    /// <summary>
    /// The DNS type.
    /// </summary>
    [EnumMember(Value = "dns")]
    Dns,
}
