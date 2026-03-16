using System.Text.Json;
using System.Text.Json.Serialization;

namespace Certes.Json;

using System.Text.Encodings.Web;

/// <summary>
/// Helper methods for JSON serialization.
/// </summary>
public static class JsonUtil
{
    /// <summary>
    /// Creates the <see cref="JsonSerializerOptions"/> used for ACME entity serialization.
    /// </summary>
    /// <returns>The JSON serializer settings.</returns>
    public static JsonSerializerOptions CreateJsonSettings()
    {
        return new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
    }
}
