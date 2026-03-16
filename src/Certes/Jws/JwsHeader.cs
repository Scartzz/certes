#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Certes.Jws;

using System.Text.Json.Serialization;

public class JwsHeader
{
    [JsonPropertyName("alg")]
    public string Algorithm { get; set; }
    
    [JsonPropertyName("jwk")]
    public JsonWebKey JsonWebKey { get; set; }
    
    [JsonPropertyName("kid")]
    public string KeyId { get; set; }
    
    [JsonPropertyName("nonce")]
    public string Nonce { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
}
