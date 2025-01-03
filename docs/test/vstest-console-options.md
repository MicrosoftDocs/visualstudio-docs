---
title: VSTest.Console.exe command-line options
description: Learn about the VSTest.Console.exe command-line tool that runs tests. This article includes the General command-line options.
ms.date: 03/11/2022
ms.topic: reference
helpviewer_keywords:
- vstest.console.exe
- command-line tests
ms.author: mikejo
author: mikejo5000
manager: mijacobs
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

The following table lists all the options for *VSTest.Console.exe* and short descriptions of them. You can see a similar summary by typing `VSTest.Console/?` at a command line.

| Option | Description |
|---|---|
|**[*test file names*]**|Run tests from the specified files. Separate multiple test file names with spaces.<br />Examples: `mytestproject.dll`, `mytestproject.dll myothertestproject.exe`|
|**/Settings:[*file name*]**|Run tests with additional settings such as data collectors. For more information, see [Configure unit tests using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)<br />Example: `/Settings:local.runsettings`|
|**/Tests:[*test name*]**|Run tests with names that contain the provided values. This command matches against the full test name, including the namespace. To provide multiple values, separate them by commas.<br />Example: `/Tests:TestMethod1,testMethod2`<br />The **/Tests** command-line option cannot be used with the **/TestCaseFilter** command-line option.|
|**/Parallel**|Specifies that the tests be executed in parallel. By default, up to all available cores on the machine can be used. You can configure the number of cores to use in a settings file.|
|**/Enablecodecoverage**|Enables data diagnostic adapter CodeCoverage in the test run.<br />Default settings are used if not specified using settings file.|
|**/InIsolation**|Runs the tests in an isolated process.<br />This isolation makes the *vstest.console.exe* process less likely to be stopped on an error in the tests, but tests might run slower.|
|**/UseVsixExtensions**|This option makes the *vstest.console.exe* process use or skip the VSIX extensions installed (if any) in the test run.<br />This option is deprecated. Starting from the next major release of Visual Studio this option may be removed. Move to consuming extensions made available as a NuGet package.<br />Example: `/UseVsixExtensions:true`|
|**/TestAdapterPath:[*path*]**|Forces the *vstest.console.exe* process to use custom test adapters from a specified path (if any) in the test run.<br />Example: `/TestAdapterPath:[pathToCustomAdapters]`|
|**/Platform:[*platform type*]**|Forces the given platform to be used, instead of the platform determined from the current runtime. This option is able to force only x86, and x64 platforms on Windows. The ARM option is broken and will result in x64 on most systems.<br />Do NOT specify this option to run on runtimes that are not in the list of valid values such as ARM64.<br />Valid values are x86, x64, and ARM.<br /> 
|**/Framework: [*framework version*]**|Target .NET version to be used for test execution.<br />Example values are `Framework35`, `Framework40`, `Framework45`, `FrameworkUap10`, `.NETCoreApp,Version=v1.1`.<br />TargetFrameworkAttribute is used to automatically detect this option from your assembly, and defaults to `Framework40` when the attribute is not present. You must specify this option explicitly if you remove the [TargetFrameworkAttribute](/dotnet/api/system.runtime.versioning.targetframeworkattribute) from your .NET Core assemblies.<br />If the target framework is specified as **Framework35**, the tests run in CLR 4.0 "compatibility mode".<br />Example: `/Framework:framework40`|
|**/TestCaseFilter:[*expression*]**|Run tests that match the given expression.<br /><Expression\> is of the format <property\>=<value\>[\|<Expression\>].<br />Example: `/TestCaseFilter:"Priority=1"`<br />Example: `/TestCaseFilter:"TestCategory=Nightly|FullyQualifiedName=Namespace.ClassName.MethodName"`<br />The **/TestCaseFilter** command-line option cannot be used with the **/Tests** command-line option. <br />For information about creating and using expressions, see [TestCase filter](https://github.com/Microsoft/vstest-docs/blob/main/docs/filter.md).|
|**/?**|Displays usage information.|
|**/Logger:[*uri/friendlyname*]**|Specify a logger for test results. Specify the parameter multiple times to enable multiple loggers.<br />Example: To log results into a Visual Studio Test Results File (TRX), use<br />**/Logger:trx**<br />**[;LogFileName=\<Defaults to unique file name>]**|
|**/ListTests:[*file name*]**|Lists discovered tests from the given test container.<br />Note: The `/TestCaseFilters` option has no effect when listing tests; it only controls which tests get run.|
|**/ListDiscoverers**|Lists installed test discoverers.|
|**/ListExecutors**|Lists installed test executors.|
|**/ListLoggers**|Lists installed test loggers.|
|**/ListSettingsProviders**|Lists installed test settings providers.|
|**/Blame**|Runs the tests in blame mode. This option is helpful in isolating problematic tests that cause the test host to crash. When a crash is detected, it creates a sequence file in `TestResults/<Guid>/<Guid>_Sequence.xml` that captures the order of tests that were run before the crash. For more information, see [Blame data collector](https://github.com/Microsoft/vstest-docs/blob/main/docs/extensions/blame-datacollector.md).|
|**/Diag:[*file name*]**|Writes diagnostic trace logs to the specified file.|
|**/ResultsDirectory:[*path*]**|Test results directory will be created in specified path if not exists.<br />Example: `/ResultsDirectory:<pathToResultsDirectory>`|
|**/ParentProcessId:[*parentProcessId*]**|Process ID of the Parent Process responsible for launching current process.|
|**/Port:[*port*]**|The Port for socket connection and receiving the event messages.|
|**/Collect:[*dataCollector friendlyName*]**|Enables data collector for the test run. [More information](https://github.com/Microsoft/vstest-docs/blob/main/docs/analyze.md).|

> [!TIP]
> The options and values are not case-sensitive.

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

If there is no test host crash, the *sequence.xml* file will not be generated.

Example of a generated *sequence.xml* file: 

```xml
<?xml version="1.0"?>
<TestSequence>
  <Test Name="TestProject.UnitTest1.TestMethodB" Source="D:\repos\TestProject\TestProject\bin\Debug\TestProject.dll" />
  <Test Name="TestProject.UnitTest1.TestMethodA" Source="D:\repos\TestProject\TestProject\bin\Debug\TestProject.dll" />
</TestSequence>
```

## UWP example

For UWP, the appxrecipe file must be referenced instead of a DLL.

```cmd
vstest.console.exe /Logger:trx /Platform:x64 /framework:frameworkuap10 UnitTestsUWP\bin\x64\Release\UnitTestsUWP.build.appxrecipe
```
