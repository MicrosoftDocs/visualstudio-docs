---
title: VSTest.Console.exe command-line options
ms.date: 07/12/2018
ms.topic: reference
helpviewer_keywords:
  - "vstest.console.exe"
  - "command-line tests"
ms.author: jillfra
author: jillre
manager: jillfra
ms.workload:
  - "multiple"
---
# VSTest.Console.exe command-line options

*VSTest.Console.exe* is the command-line tool to run tests. You can specify several options in any order on the command line. These options are listed in [General command-line options](#general-command-line-options).

> [!NOTE]
> The MSTest adapter in Visual Studio also works in legacy mode (equivalent to running tests with *mstest.exe*) for compatibility. In legacy mode, it can't take advantage of the TestCaseFilter feature. The adapter can switch to legacy mode when a *testsettings* file is specified, **forcelegacymode** is set to **true** in a *runsettings* file, or by using attributes such as **HostType**.
>
> To run automated tests on an ARM architecture-based machine, you must use *VSTest.Console.exe*.

## General command-line options

The following table lists all the options for *VSTest.Console.exe* and short descriptions of them. You can see a similar summary by typing `VSTest.Console/?` at a command line.

| Option | Description |
|---|---|
|**[*test file names*]**|Run tests from the specified files. Separate multiple test file names with spaces.<br />Examples: `mytestproject.dll`, `mytestproject.dll myothertestproject.exe`|
|**/Settings:[*file name*]**|Run tests with additional settings such as data collectors.<br />Example: `/Settings:Local.RunSettings`|
|**/Tests:[*test name*]**|Run tests with names that contain the provided values. To provide multiple values, separate them by commas.<br />Example: `/Tests:TestMethod1,testMethod2`<br />The **/Tests** command-line option cannot be used with the **/TestCaseFilter** command-line option.|
|**/Parallel**|Specifies that the tests be executed in parallel. By default, up to all available cores on the machine can be used. You can configure the number of cores to use in a settings file.|
|**/Enablecodecoverage**|Enables data diagnostic adapter CodeCoverage in the test run.<br />Default settings are used if not specified using settings file.|
|**/InIsolation**|Runs the tests in an isolated process.<br />This isolation makes the *vstest.console.exe* process less likely to be stopped on an error in the tests, but tests might run slower.|
|**/UseVsixExtensions**|This option makes the *vstest.console.exe* process use or skip the VSIX extensions installed (if any) in the test run.<br />This option is deprecated. Starting from the next major release of Visual Studio this option may be removed. Move to consuming extensions made available as a NuGet package.<br />Example: `/UseVsixExtensions:true`|
|**/TestAdapterPath:[*path*]**|Forces the *vstest.console.exe* process to use custom test adapters from a specified path (if any) in the test run.<br />Example: `/TestAdapterPath:[pathToCustomAdapters]`|
|**/Platform:[*platform type*]**|Target platform architecture to be used for test execution.<br />Valid values are x86, x64, and ARM.|
|**/Framework: [*framework version*]**|Target .NET version to be used for test execution.<br />Example values are `Framework35`, `Framework40`, `Framework45`, `FrameworkUap10`, `.NETCoreApp,Version=v1.1`.<br />If the target framework is specified as **Framework35**, the tests run in CLR 4.0 "compatibly mode".<br />Example: `/Framework:framework40`|
|**/TestCaseFilter:[*expression*]**|Run tests that match the given expression.<br /><Expression\> is of the format <property\>=<value\>[\|<Expression\>].<br />Example: `/TestCaseFilter:"Priority=1"`<br />Example: `/TestCaseFilter:"TestCategory=Nightly|FullyQualifiedName=Namespace.ClassName.MethodName"`<br />The **/TestCaseFilter** command-line option cannot be used with the **/Tests** command-line option. <br />For information about creating and using expressions, see [TestCase filter](https://github.com/Microsoft/vstest-docs/blob/master/docs/filter.md).|
|**/?**|Displays usage information.|
|**/Logger:[*uri/friendlyname*]**|Specify a logger for test results.<br />Example: To log results into a Visual Studio Test Results File (TRX), use **/Logger:trx**.<br />Example: To publish test results to Team Foundation Server, use TfsPublisher:<br />**/logger:TfsPublisher;**<br />**Collection=<project url\>;**<br />**BuildName=<build name\>;**<br />**TeamProject=<project name\>;**<br />**[;Platform=\<Defaults to "Any CPU">]**<br />**[;Flavor=\<Defaults to "Debug">]**<br />**[;RunTitle=<title\>]**|
|**/ListTests:[*file name*]**|Lists discovered tests from the given test container.|
|**/ListDiscoverers**|Lists installed test discoverers.|
|**/ListExecutors**|Lists installed test executors.|
|**/ListLoggers**|Lists installed test loggers.|
|**/ListSettingsProviders**|Lists installed test settings providers.|
|**/Blame**|Tracks the tests as they're executing and, if the test host process crashes, emits the tests names in their sequence of execution up to and including the specific test that was running at the time of the crash. This output makes it easier to isolate the offending test and diagnose further. [More information](https://github.com/Microsoft/vstest-docs/blob/master/docs/extensions/blame-datacollector.md).|
|**/Diag:[*file name*]**|Writes diagnostic trace logs to the specified file.|
|**/ResultsDirectory:[*path*]**|Test results directory will be created in specified path if not exists.<br />Example: `/ResultsDirectory:<pathToResultsDirectory>`|
|**/ParentProcessId:[*parentProcessId*]**|Process ID of the Parent Process responsible for launching current process.|
|**/Port:[*port*]**|The Port for socket connection and receiving the event messages.|
|**/Collect:[*dataCollector friendlyName*]**|Enables data collector for the test run. [More information](https://aka.ms/vstest-collect).|

> [!TIP]
> The options and values are not case-sensitive.

## Examples

The syntax for running *VSTest.Console.exe* is:

`Vstest.console.exe [TestFileNames] [Options]`

The following command runs *VSTest.Console.exe* for the test library **myTestProject.dll**:

```cmd
vstest.console.exe myTestProject.dll
```

The following command runs *VSTest.Console.exe* with multiple test files. Separate test file names with spaces:

```cmd
Vstest.console.exe myTestFile.dll myOtherTestFile.dll
```

The following command runs *VSTest.Console.exe* with several options. It runs the tests in the *myTestFile.dll* file in an isolated process and uses settings specified in the *Local.RunSettings* file. Additionally, it only runs tests marked "Priority=1", and logs the results to a *.trx* file.

```cmd
vstest.console.exe  myTestFile.dll /Settings:Local.RunSettings /InIsolation /TestCaseFilter:"Priority=1" /Logger:trx
```
