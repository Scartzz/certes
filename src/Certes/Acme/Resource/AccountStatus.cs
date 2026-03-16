using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Certes.Json;

namespace Certes.Acme.Resource;

/// <summary>
/// Represents the status of <see cref="Account"/>.
/// </summary>
[JsonConverter(typeof(JsonEnumMemberStringEnumConverter))]
public enum AccountStatus
{
    /// <summary>
    /// The valid status.
    /// </summary>
    [EnumMember(Value = "valid")]
    Valid,

    /// <summary>
    /// The deactivated status, initiated by client.
    /// </summary>
    [EnumMember(Value = "deactivated")]
    Deactivated,

    /// <summary>
    /// The revoked status, initiated by server.
    /// </summary>
    [EnumMember(Value = "revoked")]
    Revoked,
}
