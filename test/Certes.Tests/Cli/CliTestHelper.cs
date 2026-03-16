using System.CommandLine;
using System.CommandLine.IO;
using System.Text;
using Certes.Cli.Settings;
using Moq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Certes.Cli;

internal static class CliTestHelper
{
    public static JsonSerializerOptions JsonSettings { get; } = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    public static (Mock<IConsole> Console, StringBuilder StdOut, StringBuilder ErrOut) MockConsole()
    {
        var stdOutput = new StringBuilder();
        var errOutput = new StringBuilder();

        var stdOut = new Mock<IStandardStreamWriter>(MockBehavior.Strict);
        stdOut.Setup(m => m.Write(It.IsAny<string>()))
            .Callback((string value) => stdOutput.Append(value));

        var errOut = new Mock<IStandardStreamWriter>(MockBehavior.Strict);
        errOut.Setup(m => m.Write(It.IsAny<string>()))
            .Callback((string value) => errOutput.Append(value));

        var console = new Mock<IConsole>(MockBehavior.Strict);
        console.SetupGet(c => c.Out).Returns(stdOut.Object);
        console.SetupGet(c => c.Error).Returns(errOut.Object);

        return (console, stdOutput, errOutput);
    }

    public static IUserSettings NoopSettings()
    {
        var mock = new Mock<IUserSettings>();
        return mock.Object;
    }
}
