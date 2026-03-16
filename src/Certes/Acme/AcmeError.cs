using System.Collections.Generic;
using System.Net;
using Certes.Acme.Resource;

namespace Certes.Acme;

using System.Text.Json.Serialization;

/// <summary>
/// Represents an error returned from ACME server.
/// </summary>
public class AcmeError
{
    /// <summary>
    /// Gets or sets the error type URI.
    /// </summary>
    /// <value>
    /// The error type URI.
    /// </value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the detail message.
    /// </summary>
    /// <value>
    /// The detail message.
    /// </value>
    [JsonPropertyName("detail")]
    public string Detail { get; set; }

    /// <summary>
    /// Gets or sets the identifier for this error.
    /// </summary>
    /// <value>
    /// The identifier for this error.
    /// </value>
    [JsonPropertyName("identifier")]
    public Identifier Identifier { get; set;}

    /// <summary>
    /// Gets or sets the subproblems.
    /// </summary>
    /// <value>
    /// The subproblems.
    /// </value>
    [JsonPropertyName("subproblems")]
    public IList<AcmeError> Subproblems { get; set; }

    /// <summary>
    /// Gets or sets the HTTP status.
    /// </summary>
    /// <value>
    /// The HTTP status.
    /// </value>
    [JsonPropertyName("status")]
    public HttpStatusCode Status { get; set; }
}
