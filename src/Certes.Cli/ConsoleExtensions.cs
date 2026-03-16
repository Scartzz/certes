using System.CommandLine;
using System.CommandLine.IO;
using Certes.Json;

namespace Certes.Cli;

using System.Text.Json;

internal static class ConsoleExtensions
{
    private static readonly JsonSerializerOptions jsonSerializerSettings = JsonUtil.CreateJsonSettings();

    public static void WriteAsJson(this IConsole console, object value)
    {
        console.Out.WriteLine(JsonSerializer.Serialize(value, jsonSerializerSettings));
    }
}
