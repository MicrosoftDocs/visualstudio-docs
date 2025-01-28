---
title: Microsoft.CodeCoverage.Console tool
description: Use the Microsoft.CodeCoverage.Console tool to collect code coverage for C++ and C# code in nontest scenarios, and merge and convert code coverage reports.
ms.date: 01/28/2025
ms.topic: conceptual
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
monikerRange: '>= vs-2022'
---
# Microsoft.CodeCoverage.Console tool

Microsoft.CodeCoverage.Console is a command-line tool that you can use to collect code coverage for C++ and C# code. It also supports merging and converting code coverage reports. This tool can be used to collect code coverage in non-test scenarios (for example, for a simple console application).

This tool is extension to the [dotnet-coverage](/dotnet/core/additional-tools/dotnet-coverage) dotnet tool that adds support for collecting code coverage for C++ code. Additionally, Microsoft.CodeCoverage.Console supports security features to enable collecting ASP.NET code coverage data from IIS.

>[!NOTE]
> The tool is available only with Visual Studio Enterprise. For .NET code coverage, you can alternatively use the command-line tool, [dotnet-coverage](/dotnet/core/additional-tools/dotnet-coverage).

Microsoft.CodeCoverage.Console is available in Visual Studio 2022 17.3 under the folder `Common7\IDE\Extensions\Microsoft\CodeCoverage.Console`. You can use it in a Developer Command Prompt and a Developer PowerShell:

```console
D:\ConsoleApplication\x64\Debug> Microsoft.CodeCoverage.Console --help
Description:
  Code coverage tools.

Usage:
  Microsoft.CodeCoverage.Console [command] [options]

Options:
  --version       Show version information
  -?, -h, --help  Show help and usage information

Commands:
  collect <command> <args>            Collect code coverage from inner process and subprocesses.
  connect <session> <command> <args>  Connects to an existing code coverage session and collects code coverage from
                                      inner process and subprocesses.
  merge <files>                       Merge coverage reports
  shutdown <session>                  Close existing code coverage collection.
  snapshot <session>                  Creates coverage file for existing code coverage collection.
  instrument <input-file>             Instruments native and managed binary.
  uninstrument <input-file>           Restore original binary.
```

## Collect, connect, shutdown, merge, snapshot, and uninstrument commands

The Microsoft.CodeCoverage.Console tool is extension to the [dotnet-coverage](/dotnet/core/additional-tools/dotnet-coverage) dotnet tool. The documentation for collect, connect, shutdown, merge, snapshot, and uninstrument commands can be found [here](/dotnet/core/additional-tools/dotnet-coverage).

Microsoft.CodeCoverage.Console supports additional security features to enable collecting ASP.NET code coverage data from IIS. Additionally, the Microsoft.CodeCoverage.Console tool supports collecting code coverage for C++ code. The `instrument` command is specific to these scenarios.

## Instrument command

The instrument command is used to instrument native or managed binary on disk. 

### Synopsis

```console
Microsoft.CodeCoverage.Console instrument
    <input-file>
    [-s|--settings <settings>] [-id|--session-id <session-id>]
    [-o|--output <output>]
    [-l|--log-file <log-file>] [-ll|--log-level <log-level>]
    [-dco|--disable-console-output] [--nologo]
    [-?|-h|--help]
```

### Arguments

* **`<input-file>`**

  The input binary.

### Options

* **`-s|--settings <settings>`**

  Sets the path to the XML code coverage settings.

* **`-id|--session-id <session-id>`**

  Specifies the code coverage session ID. If not provided, the tool generates a random GUID.

* **`-o|--output <output>`**

  Sets the path to output file binary. If not provided, instrumentation will be performed in-place.

* **`-l|--log-file <log-file>`**

  Sets the log file path. When you provide a directory (with a path separator at the end), a new log file is generated for each process under analysis.

* **`-ll|--log-level <log-level>`**

  Sets the log level. Supported values: `Error`, `Info`, and  `Verbose`.

* **`-dco|--disable-console-output`**

  Disables console output.

* **`--nologo`**

  Do not display Code Coverage banner.

## Static code coverage for C++ code

The Microsoft.CodeCoverage.Console tool can be used to collect code coverage for C++ using static instrumentation. There are three different methods available that you can use. To demonstrate, let's assume we have a simple C++ console application (linked with the option [/PROFILE](/cpp/build/reference/profile-performance-tools-profiler)):

```console
D:\ConsoleApplication\x64\Debug> .\ConsoleApplication.exe
Hello World!
```

### Code coverage using collect command with configuration file

If you don't want to use the `instrument` command, you can instead use a configuration file to specify the files to instrument, as follows:

```xml
<ModulePaths>
  <IncludeDirectories>
    <Directory>D:\ConsoleApplication\x64\Debug</Directory>
  </IncludeDirectories>
</ModulePaths>
```

Then, collect code coverage as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console collect --settings coverage.config .\ConsoleApplication.exe
SessionId: 85d9d49e-38a7-43a4-81ff-9e12f0e6b04b
Hello World!
Code coverage results: output.coverage.
```

### Code coverage using instrument and collect commands

Before collecting code coverage data, first instrument the binary as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console instrument ConsoleApplication.exe
Input file successfully instrumented.
```

Then, collect code coverage as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console collect .\ConsoleApplication.exe
SessionId: e85e657f-9ff3-42a0-88d7-2349598a1ecd
Hello World!
Code coverage results: output.coverage.
```

### Code coverage using instrument command and collect command in server mode

Using this method, you can separate code coverage collection from running your application. First, instrument your binary as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console instrument --session-id 73c34ce5-501c-4369-a4cb-04d31427d1a4 ConsoleApplication.exe
Input file successfully instrumented.
```

> [!NOTE]
> Session ID needs to be used in this scenario to make sure that the application can connect and provide data to external collector.

In the second step, you need to start the code coverage collector as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console collect --session-id 73c34ce5-501c-4369-a4cb-04d31427d1a4 --server-mode
SessionId: 73c34ce5-501c-4369-a4cb-04d31427d1a4
```

Then, start the application as follows:

```console
D:\ConsoleApplication\x64\Debug>.\ConsoleApplication.exe
Hello World!
```

> [!NOTE]
> Instrumented native binary contains a reference to `static_covrun64.dll`. Make sure that this file is next to the instrumented binary or the directory where `static_covrun64.dll` is located is listed in the `Path` environment variable. The `collect` and `connect` commands are adding proper directories to `Path` automatically.

Finally, close the collector as follows:

```console
D:\ConsoleApplication\x64\Debug>Microsoft.CodeCoverage.Console shutdown 73c34ce5-501c-4369-a4cb-04d31427d1a4
```

## Related content

- [dotnet-coverage code coverage utility](/dotnet/core/additional-tools/dotnet-coverage)
- [Customize code coverage analysis](../test/customizing-code-coverage-analysis.md)
- [Configure unit tests by using a run settings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Use code coverage to determine how much code is tested](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)
- [Unit test your code](../test/unit-test-your-code.md)
