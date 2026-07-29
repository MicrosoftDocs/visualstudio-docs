---
title: VSTest.Console.exe command-line options
description: Learn about the VSTest.Console.exe command-line tool that runs tests. This article includes the General command-line options.
ms.date: 07/17/2026
ms.topic: reference
helpviewer_keywords:
- vstest.console.exe
- command-line tests
ms.author: mikejo
author: mikejo5000

ms.subservice: test-tools
---
# VSTest.Console.exe command-line options

*VSTest.Console.exe* is the command-line tool to run tests. You can specify several options in any order on the command line. These options are listed in [General command-line options](#general-command-line-options).

> [!NOTE]
> The MSTest adapter in Visual Studio also works in legacy mode (equivalent to running tests with *mstest.exe*) for compatibility. In legacy mode, it can't take advantage of the TestCaseFilter feature. The adapter can switch to legacy mode when a *testsettings* file is specified, **forcelegacymode** is set to **true** in a *runsettings* file, or by using attributes such as **HostType**.
>
> To run automated tests on an ARM architecture-based machine, you must use *VSTest.Console.exe*.

Open [Developer Command Prompt](../ide/reference/command-prompt-powershell.md) to use the command-line tool, or you can find the tool in *%Program Files(x86)%\Microsoft Visual Studio\\<version\>\\<edition\>\common7\ide\CommonExtensions\\<Platform | Microsoft>*.

## General command-line options

The following table lists the commonly used options for *VSTest.Console.exe* and short descriptions of them. You can see a similar summary by typing `VSTest.Console/?` at a command line. For the complete reference, including internal and legacy switches that aren't listed here, see [vstest.console.exe command line options](https://github.com/microsoft/vstest/blob/main/docs/commandline.md) and specifically [Omitted switches](https://github.com/microsoft/vstest/blob/main/docs/commandline.md#omitted-switches) in the vstest repository.

| Option | Description |
|---|---|
|**[*test file names*]**|Run tests from the specified files. Separate multiple test file names with spaces.<br />Examples: `mytestproject.dll`, `mytestproject.dll myothertestproject.exe`|
|**/Settings:[*file name*]**|Run tests with additional settings such as data collectors. For more information, see [Configure unit tests using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)<br />Example: `/Settings:local.runsettings`|
|**/Tests:[*test name*]**|Run tests with names that contain the provided values. This command matches against the full test name, including the namespace. To provide multiple values, separate them by commas.<br />Example: `/Tests:TestMethod1,testMethod2`<br />The **/Tests** command-line option can't be used with the **/TestCaseFilter** command-line option.|
|**/Parallel**|Specifies that the tests be executed in parallel. By default, up to all available cores on the machine can be used. You can configure the number of cores to use in a settings file.|
|**/InIsolation**|Runs the tests in an isolated process.<br />This isolation makes the *vstest.console.exe* process less likely to be stopped on an error in the tests, but tests might run slower.|
|**/TestAdapterPath:[*path*]**|Forces the *vstest.console.exe* process to use custom test adapters from a specified path (if any) in the test run.<br />Example: `/TestAdapterPath:[pathToCustomAdapters]`|
|**/Platform:[*platform type*]**|Forces the given platform architecture to be used, instead of the platform determined from the current runtime. Values are case-insensitive; the accepted values are `x86`, `x64`, `ARM`, `ARM64`, `S390x`, `Ppc64le`, `RiscV64`, and `LoongArch64`.<br />On Windows, only x86 and x64 can be reliably forced; specifying `ARM` results in x64 on most systems. Don't specify this option to run on a runtime that isn't in the list of valid values.|
|**/Framework: [*framework version*]**|Target .NET version to be used for test execution.<br />Modern framework short forms are accepted and parsed by the NuGet framework parser, for example `net48`, `net6.0`, or `net10.0` (as well as the long forms such as `.NETFramework,Version=v4.8` and `.NETCoreApp,Version=v10.0`).<br />The legacy aliases `Framework35`, `Framework40`, `Framework45`, `FrameworkCore10`, and `FrameworkUap10` are also accepted.<br />TargetFrameworkAttribute is used to automatically detect this option from your assembly, and defaults to `Framework40` when the attribute isn't present. You must specify this option explicitly if you remove the [TargetFrameworkAttribute](/dotnet/api/system.runtime.versioning.targetframeworkattribute) from your .NET Core assemblies.<br />If the target framework is specified as **Framework35**, the tests run in CLR 4.0 "compatibility mode".<br />Example: `/Framework:net8.0`|
|**/TestCaseFilter:[*expression*]**|Run tests that match the given expression.<br /><Expression\> is of the format <property\>=<value\>[\|<Expression\>].<br />Example: `/TestCaseFilter:"Priority=1"`<br />Example: `/TestCaseFilter:"TestCategory=Nightly|FullyQualifiedName=Namespace.ClassName.MethodName"`<br />The **/TestCaseFilter** command-line option can't be used with the **/Tests** command-line option. <br />For information about creating and using expressions, see [TestCase filter](https://github.com/microsoft/vstest/blob/main/docs/filter.md). When you type a filter directly in a shell, see [Escape filter expressions in the shell](#escape-filter-expressions-in-the-shell).|
|**/Environment:[*NAME*]=[*VALUE*]**|Sets the value of an environment variable for the test host process. Creates the variable if it doesn't exist, and overrides it if it does. This option implies **/InIsolation** and forces the tests to run in an isolated process. Specify the option multiple times to set multiple variables. Short form: **/e**.<br />Example: `/e:VARIABLE1=VALUE1`|
|**/?**|Displays usage information.|
|**/Logger:[*uri/friendlyname*]**|Specify a logger for test results. Specify the parameter multiple times to enable multiple loggers.<br />Example: To log results into a Visual Studio Test Results File (TRX), use<br />**/Logger:trx**<br />**[;LogFileName=\<Defaults to unique file name>]**<br />Use `LogFilePrefix=<prefix>` instead of `LogFileName` to keep a separate, timestamped file per run. `LogFileName` sets an explicit name and overwrites the previous file, whereas `LogFilePrefix` doesn't.<br />For more information, see [Logging example](#logging-example).|
|**/ListTests:[*file name*]**|Lists discovered tests from the given test container. Short form: **/lt**.<br />Note: The `/TestCaseFilter` option has no effect when listing tests; it only controls which tests get run.|
|**/Blame**|Runs the tests in blame mode. This option is helpful in isolating problematic tests that cause the test host to crash. When a crash is detected, it creates a sequence file in `TestResults/<Guid>/<Guid>_Sequence.xml` that captures the order of tests that were run before the crash.<br />You can also collect a crash or hang dump, for example `/Blame:CollectDump;DumpType=full` or `/Blame:CollectHangDump;TestTimeout=90m;HangDumpType=mini`. The equivalent `dotnet test` switches are `--blame-crash` and `--blame-hang`.<br />For the full option matrix and dump-collection requirements, see [Blame data collector](https://github.com/microsoft/vstest/blob/main/docs/extensions/blame-datacollector.md).|
|**/Diag:[*file name*]**|Writes diagnostic trace logs to the specified file.<br />Set the trace level with `/Diag:<file name>;tracelevel=<off\|error\|warning\|info\|verbose>` (default is `verbose`).|
|**/ResultsDirectory:[*path*]**|Test results directory will be created in specified path if not exists.<br />Example: `/ResultsDirectory:<pathToResultsDirectory>`|
|**/ParentProcessId:[*parentProcessId*]**|Process ID of the Parent Process responsible for launching current process.|
|**/Port:[*port*]**|The Port for socket connection and receiving the event messages.|
|**/Collect:[*dataCollector friendlyName*]**|Enables data collector for the test run. [More information](https://github.com/microsoft/vstest/blob/main/docs/analyze.md).|
|**@[*file*]**|Reads additional options from the specified response file. Arguments in the file are separated by whitespace (spaces or newlines) and quoting is supported, so options can span multiple lines.<br />Example: `vstest.console.exe @options.rsp`|

> [!TIP]
> The options and values aren't case-sensitive.

## Examples

The syntax for running *vstest.console.exe* is:

`vstest.console.exe [TestFileNames] [Options]`

By default, the command returns 0 when it exits normally, even if no tests are discovered. If you want to return a non-zero value if no tests are discovered, use `<TreatNoTestsAsError>true</TreatNoTestsAsError>` runsettings option.

The following command runs *vstest.console.exe* for the test library *myTestProject.dll*:

```cmd
vstest.console.exe myTestProject.dll
```

The following command runs *vstest.console.exe* with multiple test files. Separate test file names with spaces:

```cmd
vstest.console.exe myTestFile.dll myOtherTestFile.dll
```

The following command runs *vstest.console.exe* with several options. It runs the tests in the *myTestFile.dll* file in an isolated process and uses settings specified in the *Local.RunSettings* file. Additionally, it only runs tests marked "Priority=1", and logs the results to a *.trx* file.

```cmd
vstest.console.exe myTestFile.dll /Settings:Local.RunSettings /InIsolation /TestCaseFilter:"Priority=1" /Logger:trx
```

The following command runs *vstest.console.exe* with the `/blame` option for the test library *myTestProject.dll*:

```cmd
vstest.console.exe myTestFile.dll /blame
```

If a test host crash happened, the *sequence.xml* file is generated. The file contains fully qualified names of the tests in their sequence of execution up to and including the specific test that was running at the time of the crash.

If there is no test host crash, the *sequence.xml* file won't be generated.

Example of a generated *sequence.xml* file: 

```xml
<?xml version="1.0"?>
<TestSequence>
  <Test Name="TestProject.UnitTest1.TestMethodB" Source="D:\repos\TestProject\TestProject\bin\Debug\TestProject.dll" />
  <Test Name="TestProject.UnitTest1.TestMethodA" Source="D:\repos\TestProject\TestProject\bin\Debug\TestProject.dll" />
</TestSequence>
```
In this case, the `<Test Name>` listed last is the test that was running at the time of the crash.

## Exit codes

*vstest.console.exe* returns one of two exit codes:

| Code | Meaning |
|---|---|
| `0` | Success. The requested operation completed and, for a test run, all executed tests passed. |
| `1` | Failure. For example, one or more tests failed, a run error was reported, the command line was invalid or missing, a test source couldn't be loaded, or the run was aborted or canceled. |

The process never returns any other value. When you run tests through `dotnet test`, the .NET SDK surfaces a non-zero exit code when the run fails in the same way.

When discovery finds no matching tests, the runner prints a *warning* rather than an error, and by default still returns `0`. To make a run that discovers or selects zero tests return `1` instead, set `<TreatNoTestsAsError>true</TreatNoTestsAsError>` in the **RunConfiguration** element of your *.runsettings* file. For more information, see [Configure unit tests using a .runsettings file](configure-unit-tests-by-using-a-dot-runsettings-file.md).

## Escape filter expressions in the shell

A **/TestCaseFilter** expression is parsed by both your shell and the test platform, so some characters need shell-specific escaping before *vstest.console.exe* receives them. Quoting the whole expression, as in the examples earlier in this article, avoids most problems. The following cases need extra care:

- **PowerShell**: The comma (`,`) is the array operator and the semicolon (`;`) is a statement separator. Quote the entire filter expression so it's passed through literally, for example `/TestCaseFilter:"FullyQualifiedName=MyNamespace.MyClass.MyMethod"`.
- **Bash and zsh (Linux and macOS)**: Escape `!` with a backslash when you use the `!~` (*not contains*) operator, for example `--filter FullyQualifiedName\!~IntegrationTests` with `dotnet test`. Also quote values that contain characters with special meaning to the shell, such as `<`, `>`, or `,` in a generic type argument list:

  ```bash
  dotnet test --filter "FullyQualifiedName=MyNamespace.MyClass<Type1,Type2>.MyMethod"
  ```

For the full filtering reference and supported properties per test framework, see [TestCase filter](https://github.com/microsoft/vstest/blob/main/docs/filter.md).

## Logging example

Each logger defines its own parameters. Unlike trx, the console logger allows you to set verbosity level. For additional information, type `VSTest.Console/?` at the command line.

Here is an example for the console logger:

```cmd
vstest.console.exe myTestFile.dll /logger:console;verbosity=detailed
```

Supported verbosity levels include quiet, minimal, normal, and detailed.

In PowerShell, you need to use quotes:

```cmd
vstest.console.exe myTestFile.dll /logger:"console;verbosity=detailed"
```

For the full list of available loggers, as well as instructions for authoring your own logger, see [Reporting test results](https://github.com/microsoft/vstest/blob/main/docs/report.md) in the vstest repository.

## UWP example

For UWP, the appxrecipe file must be referenced instead of a DLL.

```cmd
vstest.console.exe /Logger:trx /Platform:x64 /framework:frameworkuap10 UnitTestsUWP\bin\x64\Release\UnitTestsUWP.build.appxrecipe
```

## Environment variables

The test platform recognizes several environment variables. The following are the ones most useful when you run tests from the command line. For the complete list, see [Environment variables understood by the test platform](https://github.com/microsoft/vstest/blob/main/docs/environment-variables.md) in the vstest repository.

| Variable | Description |
|---|---|
|`VSTEST_CONNECTION_TIMEOUT`|Timeout, in seconds, for establishing connections between test platform components (*vstest.console.exe*, testhost, and data collector). The default is 90. Increase it on slow machines or when network latency causes connection timeouts.|
|`VSTEST_DIAG`|Enables diagnostic logging and specifies the path to the log file. Equivalent to the **/Diag** option.|
|`VSTEST_DIAG_VERBOSITY`|Sets the verbosity of diagnostic logging when `VSTEST_DIAG` is enabled. Valid values are `Verbose`, `Info`, `Warning`, and `Error` (default is `Verbose`).|
|`VSTEST_HOST_DEBUG`|Set to any non-empty value to enable debugging of the testhost process.|
|`VSTEST_RUNNER_DEBUG`|Set to any non-empty value to enable debugging of the runner (*vstest.console.exe*).|
|`VSTEST_DUMP_PATH`|Overrides the default directory where blame crash dumps are stored.|
|`VSTEST_DUMP_FORCEPROCDUMP`|Set to any non-empty value to force ProcDump to be used for crash dump collection.|
|`VSTEST_DISABLE_UTF8_CONSOLE_ENCODING`|Set to `1` to disable setting UTF-8 encoding on console output.|
|`VSTEST_CONSOLE_PATH`|Path to the *vstest.console.exe* executable used by the .NET SDK's `dotnet test` forwarding app. Equivalent to `-p:VSTestConsolePath` when you run `dotnet test` on a project.|

## Related content

- [Quickstart: run tests from the command line](https://github.com/microsoft/vstest/blob/main/docs/quickstart.md) in the vstest repository
- [Configure unit tests using a .runsettings file](configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Create a data collector](https://github.com/microsoft/vstest/blob/main/docs/extensions/datacollector.md) in the vstest repository
- [dotnet test command reference](/dotnet/core/tools/dotnet-test)
