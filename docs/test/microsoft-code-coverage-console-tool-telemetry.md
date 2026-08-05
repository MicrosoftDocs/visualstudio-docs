---
title: Microsoft.CodeCoverage.Console telemetry
description: Learn about the telemetry data collected by Microsoft.CodeCoverage.Console and dotnet-coverage and how to disable telemetry reporting.
ms.date: 08/05/2026
ms.topic: concept-article
author: RoseHJM
ms.author: rosemalcolm

ms.subservice: test-tools
monikerRange: '>= vs-2022'
---
# Microsoft.CodeCoverage.Console telemetry

The `dotnet-coverage` global tool and `Microsoft.CodeCoverage.Console.exe` collect telemetry data to help Microsoft understand how to improve the products. For example, this usage data helps prioritize new features and debug issues. Both tools share the same command surface, so they collect the same telemetry.

You can disable telemetry at any time. For more information about how Microsoft handles data, see the [Microsoft Privacy Statement](https://go.microsoft.com/fwlink/?LinkID=528096&clcid=0x409).

## Types of telemetry data

The code coverage tools collect only **Usage Data**. The usage data indicates which commands are used and which options are set when the tools run. This information helps Microsoft prioritize product improvements.

## Disable telemetry reporting

To disable telemetry, set the `DOTNET_COVERAGE_TELEMETRY_OPTOUT` environment variable to `1`.

Telemetry is also disabled when the standard .NET CLI opt-out variable `DOTNET_CLI_TELEMETRY_OPTOUT` is set to `1`. Therefore, opting out of .NET SDK telemetry also opts you out of telemetry from the code coverage tools.

## Disclosure

The tools display text similar to the following the first time you run them. This first-run experience notifies you about data collection.

```console
Telemetry
---------
The code coverage tools collect usage data in order to help us improve your experience. The data is collected by Microsoft. You can opt out of telemetry by setting the DOTNET_COVERAGE_TELEMETRY_OPTOUT environment variable to '1' using your favorite shell.

This message is displayed only once. Set the DOTNET_COVERAGE_NOLOGO environment variable to '1' to suppress it in the future.
```

The notice is displayed only once. To suppress it, for example in scripts or continuous integration (CI), set the `DOTNET_COVERAGE_NOLOGO` environment variable to `1` or `true`. This behavior mirrors `DOTNET_NOLOGO`.

## Data points

The telemetry feature doesn't collect personal data, such as usernames or email addresses. It doesn't scan your code or extract project-level data, such as the repository or author.

It doesn't extract the contents of data files accessed or created by your applications, memory dumps of your application objects, or clipboard contents.

The data is sent securely to Microsoft servers by using Azure Monitor technology. The data is held under restricted access and published under strict security controls from secure Azure Storage systems.

Values that might contain user data, such as file paths, session identifiers, and command lines, are never sent verbatim. Instead, only the fact that an option or argument was provided is recorded as the Boolean value `true`.

If you suspect that telemetry is collecting sensitive data or that data is being handled insecurely or inappropriately, file an issue in the [microsoft/codecoverage](https://github.com/microsoft/codecoverage) GitHub repository or email [dotnet@microsoft.com](mailto:dotnet@microsoft.com) for investigation.

The telemetry feature collects the following data points:

| Version | Data |
| --- | --- |
| 18.10 | Name of the tool that produced the event, such as `dotnet-coverage` or `Microsoft.CodeCoverage.Console`. |
| 18.10 | Version of the tool. |
| 18.10 | Version of the telemetry schema. |
| 18.10 | Operating system, version, and architecture. |
| 18.10 | Process architecture. |
| 18.10 | .NET runtime framework. |
| 18.10 | Runtime identifier (RID). For more information, see [.NET RID Catalog](/dotnet/core/rid-catalog). |
| 18.10 | Whether the tool is running in a CI environment. |
| 18.10 | Three-octet IP address used to determine the geographical location. |
| 18.10 | Timestamp of invocation. |
| 18.10 | GUID used to correlate events from a single tool run. |
| 18.10 | Name of the command invoked, such as `collect` or `merge`. |
| 18.10 | Whether a settings file was provided. |
| 18.10 | Whether an output path was provided. |
| 18.10 | Whether a list of include files was provided. |
| 18.10 | Whether application arguments were provided for the `connect` command. |
| 18.10 | Whether a log file path was provided. |
| 18.10 | Whether server mode was enabled. |
| 18.10 | Whether background mode was enabled. |
| 18.10 | Whether input files are removed after a merge. |
| 18.10 | Whether a recursive merge was requested. |
| 18.10 | Whether the snapshot was reset. |
| 18.10 | Whether a tag name was provided. |
| 18.10 | Whether a tag identifier was provided. |
| 18.10 | Whether dependencies are instrumented. |
| 18.10 | Whether console output was disabled. |
| 18.10 | Whether the logo or first-run notice was suppressed. |
| 18.10 | Output format, such as `cobertura` or `xml`. |
| 18.10 | Log level, such as `Debug`. |
| 18.10 | Timeout value. |

### Command events

Each command invocation emits an event named `dotnet/codecoverage/<command>/init`, for example, `dotnet/codecoverage/instrument/init`. Running the tool without a command, or with `--help` or `--version`, doesn't emit an event. Properties are grouped under a `metadata.*` namespace for application and system identity and a `coverage.*` namespace for the invoked command and the options or arguments provided.

The following rules determine what is recorded for options and arguments:

- Only options and arguments explicitly provided by the user are recorded. Defaults and unset values are omitted.
- For options and flags that might contain user data, only the fact that the option or argument was provided is sent as the Boolean value `true`. The actual value is sent only for the nonsensitive options `logLevel`, `outputFormat`, and `timeout`.
- Mandatory arguments are never sent because they're always present and provide no usage signal. These arguments are `command` for `connect`, `files` for `merge`, `session` for `connect`, `snapshot`, and `shutdown`, and `input-file` for `instrument` and `uninstrument`.
- The `session-id` option is never sent for any command.
- The `--help`, `--version`, and `-?` options are never sent.

### Shared context

Because telemetry is delivered through Azure Application Insights, each event also includes standard, nonpersonal context: the operating system description and a randomly generated session identifier used to correlate events from a single run. This context doesn't include the contents of your code, assemblies, or coverage data.

## See also

- [Microsoft.CodeCoverage.Console tool](microsoft-code-coverage-console-tool.md)
- [dotnet-coverage code coverage utility](/dotnet/core/additional-tools/dotnet-coverage)
- [Customize code coverage analysis](customizing-code-coverage-analysis.md)
