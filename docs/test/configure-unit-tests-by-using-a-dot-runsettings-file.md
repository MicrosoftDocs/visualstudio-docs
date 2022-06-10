---
title: Configure unit tests with a .runsettings file
description: Learn how to use the .runsettings file in Visual Studio to configure unit tests that are run from the command line, from the IDE, or in a build workflow.
ms.custom: SEO-VS-2020
ms.date: 12/06/2021
ms.topic: conceptual
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
  - multiple
author: mikejo5000
---
# Configure unit tests by using a *.runsettings* file

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Unit tests in Visual Studio can be configured by using a *.runsettings* file. For example, you can change the .NET version on which the tests are run, the directory for the test results, or the data that's collected during a test run. A common use of a *.runsettings* file is to customize [code coverage analysis](../test/customizing-code-coverage-analysis.md).

Run settings files can be used to configure tests that are run from the [command line](vstest-console-options.md), from the IDE, or in a build workflow using Azure Test Plans or Team Foundation Server (TFS).

Run settings files are optional. If you don't require any special configuration, you don't need a *.runsettings* file.

## Create a run settings file and customize it

1. Add a run settings file to your solution. In **Solution Explorer**, on the shortcut menu of your solution, choose **Add** > **New Item**, and select **XML File**. Save the file with a name such as *test.runsettings*.

   > [!TIP]
   > The file name doesn't matter, as long as you use the extension *.runsettings*.

2. Add the content from [Example *.runsettings file](#example-runsettings-file), and then customize it to your needs as described in the sections that follow.

3. Specify the *.runsettings file that you want using one of the following methods:

   - [Visual Studio IDE](#specify-a-run-settings-file-in-the-ide)
   - [Command line](#specify-a-run-settings-file-from-the-command-line)
   - [Build workflow](/azure/devops/pipelines/test/getting-started-with-continuous-testing?view=vsts&preserve-view=true) using Azure Test Plans or Team Foundation Server (TFS).

4. Run the unit tests to use the custom run settings.


::: moniker range=">=vs-2019"

If you want to turn the custom settings off and on in the IDE, deselect or select the file on the **Test** menu.

::: moniker-end

> [!TIP]
> You can create more than one *.runsettings* file in your solution and select one as the active test settings file as needed.

## Specify a run settings file in the IDE

The methods available depend on your version of Visual Studio.


::: moniker range=">=vs-2019"

### Visual Studio 2019 version 16.4 and later

There are three ways of specifying a run settings file in Visual Studio 2019 version 16.4 and later.

- [Autodetect the run settings](#autodetect-the-run-settings-file)
- [Manually set the run settings](#manually-select-the-run-settings-file)
- [Set a build property](#set-a-build-property)

#### Autodetect the run settings file

> [!NOTE]
> This will only work for a file named `.runsettings`.

To autodetect the run settings file, place it at the root of your solution.

If auto detection of run settings files is enabled, the settings in this file are applied across all tests run. You can turn on auto detection of runsettings files using two methods:

- Select **Tools** > **Options** > **Test** > **Auto Detect runsettings Files**

   ![Auto detect runsettings file option in Visual Studio](media/auto-detect-runsettings-tools-window.png)

- Select **Test** > **Configure Run Settings** > **Auto Detect runsettings Files**

   ![Auto detect runsettings file menu in Visual Studio](media/auto-detect-runsettings-menu.png)

#### Manually select the run settings file

In the IDE, select **Test** > **Configure Run Settings** > **Select Solution Wide runsettings File**, and then select the *.runsettings* file.

- This file overrides the *.runsettings* file at the root of the solution, if one is present, and is applied across all tests run.
- This file selection only persists locally.

![Select test solution-wide runsettings file menu in Visual Studio](media/select-solution-settings-file.png)

#### Set a build property

Add a build property to a project through either the project file or a Directory.Build.props file. The run settings file for a project is specified by the property **RunSettingsFilePath**.

- Project-level run settings is currently supported in C#, VB, C++, and F# projects.
- A file specified for a project overrides any other run settings file specified in the solution.
- [These MSBuild properties](../msbuild/msbuild-reserved-and-well-known-properties.md) can be used to specify the path to the runsettings file.

Example of specifying a *.runsettings* file for a project:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <RunSettingsFilePath>$(MSBuildProjectDirectory)\example.runsettings</RunSettingsFilePath>
  </PropertyGroup>
  ...
</Project>
```

### Visual Studio 2019 version 16.3 and earlier

To specify a run settings file in the IDE, select **Test** > **Select Settings File**. Browse to and select the *.runsettings* file.

![Select test settings file menu in Visual Studio 2019](media/vs-2019/select-settings-file.png)

The file appears on the Test menu, and you can select or deselect it. While selected, the run settings file applies whenever you select **Analyze Code Coverage**.
::: moniker-end

## Specify a run settings file from the command line

To run tests from the command line, use *vstest.console.exe*, and specify the settings file by using the **/Settings** parameter.

1. Open [Developer Command Prompt for Visual Studio](../ide/reference/command-prompt-powershell.md).

2. Enter a command similar to:

   ```cmd
   vstest.console.exe MyTestAssembly.dll /EnableCodeCoverage /Settings:CodeCoverage.runsettings
   ```

   or

   ```cmd
   vstest.console.exe --settings:test.runsettings test.dll
   ```

For more information, see [VSTest.Console.exe command-line options](vstest-console-options.md).

## The *.runsettings file

The *.runsettings file is an XML file that contains different configuration elements within the **RunSettings** element. The sections that follow detail the different elements. For a complete sample, see [Example *.runsettings file](#example-runsettings-file).

```xml
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <!-- configuration elements -->
</RunSettings>
```

Each of the configuration elements is optional because it has a default value.

## RunConfiguration element

```xml
<RunConfiguration>
    <MaxCpuCount>1</MaxCpuCount>
    <ResultsDirectory>.\TestResults</ResultsDirectory>
    <TargetPlatform>x86</TargetPlatform>
    <TargetFrameworkVersion>net6.0</TargetFrameworkVersion>
    <TestAdaptersPaths>%SystemDrive%\Temp\foo;%SystemDrive%\Temp\bar</TestAdaptersPaths>
    <TestSessionTimeout>10000</TestSessionTimeout>
    <TreatNoTestsAsError>true</TreatNoTestsAsError>
</RunConfiguration>
```

The **RunConfiguration** element can include the following elements:

|Node|Default|Values|
|-|-|-|
|**MaxCpuCount**|1|**The option name is case sensitive and is easy to misspell as MaxCPUCount**.<br /><br />This setting controls the level of parallelism on process-level. Use 0 to enable the maximum process-level parallelism.<br /><br />This setting determines the maximum number of test DLLs, or other test containers that can run in parallel. Each DLL will run in its own testhost process, and will be isolated on the process level from the tests in other test DLLs. This setting does not force tests in each test DLL to run in parallel. Controlling the parallel execution within a DLL (on the thread-level) is up to the test framework such as MSTest, XUnit or NUnit.<br /><br />The default value is `1`, meaning that only one testhost will run at the same time. A special value `0` allows as many testhosts as you have logical processors (e.g. 6, for a computer with 6 physical cores without multi-threading, or 12, for a computer with 6 physical cores with multi-threading).<br /><br />The actual number of testhosts that will be started is determined by the amount of distinct DLLs in the run.|
|**ResultsDirectory**||The directory where test results are placed. The path is relative to the directory that contains .runsettings file.|
|**TargetFrameworkVersion**| net40 or netcoreapp1.0 |**Omit this whole tag to auto-detect.**<br /><br />This setting defines the framework version, or framework family to use to run tests.<br /><br />Accepted values are any framework moniker such as `net48`, `net472`,`net6.0`, `net5.0`, `netcoreapp3.1`, `uap10.0` or any valid full framework name such as`.NETFramework,Version=v4.7.2` or `.NETCoreApp,Version=v6.0.0`. For backwards compatibility `Framework35`, `Framework40`, `Framework45`, `FrameworkCore10`, `FrameworkUap10` are accepted, meaning (`net35`, `net40`, `net45`, `netcoreapp1.0` and `uap10.0` respectively). All the values are case-insensitive.<br /><br />The provided value is used to determine the test runtime provider to be used. Every test runtime provider must respect the framework family to be used, but might not respect the exact framework version:<br /><br />For .NET Framework 4.5.1 - 4.8 a testhost that was built with the specified exact version is used. For values outside of that range, .NET Framework 4.5.1 testhost is used.<br /><br />For .NET, the actual version is determined by the test project's `<TargetFramework>` (or more precisely `runtimeconfig.json`).<br /><br />For UWP, the test project application is a testhost by itself, and determines the actual version of UWP that is used.<br /><br />Omit the `TargetFrameworkVersion` element from the *.runsettings* file to automatically determine the framework version from the built binaries.<br /><br />When auto-detecting, all target frameworks will be unified into a single common framework. When a different version from the same target framework family is found, the newer version is chosen (e.g. net452, net472, net48 = net48).<br /><br />For .NET Framework runner (in Visual Studio, or vstest.console.exe in Developer command line) the common target framework is to net40. For .NET runner (dotnet test + DLLs), the common target framework is set to netcoreapp1.0.|
|**TargetPlatform**|x86|**Omit this whole tag to auto-detect.**<br /><br />This setting defines the architecture to use to run tests. Possible values are `x86`, `x64`, `ARM`, `ARM64`, `S390x`.<br /><br />When auto-detecting, the architecture for AnyCPU DLLs may differ based on the runner. For .NET Framework runner (in Visual Studio, or vstest.console.exe in Developer command line), the default is x86. For .NET runner (dotnet test), the default is the current process architecture.<br /><br />|
|**TreatTestAdapterErrorsAsWarnings**|false|false, true|
|**TestAdaptersPaths**||One or more paths to the directory where the TestAdapters are located|
|**TestSessionTimeout**||Allows users to terminate a test session when it exceeds a given timeout. Setting a timeout ensures that resources are well consumed and test sessions are constrained to a set time. The setting is available in **Visual Studio 2017 version 15.5** and later.|
|**DotnetHostPath**||Specify a custom path to dotnet host that is used to run the testhost. This is useful when you are building your own dotnet, for example when building the dotnet/runtime repository. Specifying this option will skip looking for testhost.exe, and will always use the testhost.dll.|
|**TreatNoTestsAsError**|false| true or false <br>Specify a Boolean value, which defines the exit code when no tests are discovered. If the value is `true` and no tests are discovered, a non-zero exit code is returned. Otherwise, zero is returned.|

## DataCollectors element (diagnostic data adapters)

The **DataCollectors** element specifies settings of diagnostic data adapters. Diagnostic data adapters gather additional information about the environment and the application under test. Each adapter has default settings, and you only have to provide settings if you don't want to use the defaults.

```xml
<DataCollectionRunSettings>
  <DataCollectors>
    <!-- data collectors -->
  </DataCollectors>
</DataCollectionRunSettings>
```

### CodeCoverage data collector

The code coverage data collector creates a log of which parts of the application code have been exercised in the test. For detailed information about customizing the settings for code coverage, see [Customize code coverage analysis](../test/customizing-code-coverage-analysis.md).

```xml
<DataCollector friendlyName="Code Coverage" uri="datacollector://Microsoft/CodeCoverage/2.0" assemblyQualifiedName="Microsoft.VisualStudio.Coverage.DynamicCoverageDataCollector, Microsoft.VisualStudio.TraceCollector, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
  <Configuration>
    <CodeCoverage>
      <ModulePaths>
        <Exclude>
          <ModulePath>.*CPPUnitTestFramework.*</ModulePath>
        </Exclude>
      </ModulePaths>

      <UseVerifiableInstrumentation>True</UseVerifiableInstrumentation>
      <AllowLowIntegrityProcesses>True</AllowLowIntegrityProcesses>
      <CollectFromChildProcesses>True</CollectFromChildProcesses>
      <CollectAspDotNet>False</CollectAspDotNet>
    </CodeCoverage>
  </Configuration>
</DataCollector>
```

### VideoRecorder data collector

The video data collector captures a screen recording when tests are run. This recording is useful for troubleshooting UI tests. The video data collector is available in **Visual Studio 2017 version 15.5** and later. For an example of configuring this data collector, see the [Example *.runsettings file](#example-runsettings-file).

To customize any other type of diagnostic data adapters, use a [test settings file](../test/collect-diagnostic-information-using-test-settings.md).

### Blame data collector

This option can help you isolate a problematic test that causes a test host crash. Running the collector creates an output file (*Sequence.xml*) in *TestResults*, which captures the order of execution of the test before the crash.

```xml
<DataCollector friendlyName="blame" enabled="True">
</DataCollector>
```

## TestRunParameters

```xml
<TestRunParameters>
    <Parameter name="webAppUrl" value="http://localhost" />
    <Parameter name="docsUrl" value="https://docs.microsoft.com" />
</TestRunParameters>
```

Test run parameters provide a way to define variables and values that are available to the tests at run time. Access the parameters using the MSTest <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext.Properties%2A?displayProperty=nameWithType> property (or the NUnit [TestContext](https://docs.nunit.org/articles/nunit/writing-tests/TestContext.html)):

```csharp
private string _appUrl;
public TestContext TestContext { get; set; }

[TestMethod] // [Test] for NUnit
public void HomePageTest()
{
    string _appURL = TestContext.Properties["webAppUrl"];
}
```

To use test run parameters, add a public <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestContext> property to your test class.

## LoggerRunSettings element

The `LoggerRunSettings` section defines one or more loggers to be used for the test run. The most common loggers are console, Visual Studio Test Results File (trx), and html.

```xml
<LoggerRunSettings>
    <Loggers>
      <Logger friendlyName="console" enabled="True">
        <Configuration>
            <Verbosity>quiet</Verbosity>
        </Configuration>
      </Logger>
      <Logger friendlyName="trx" enabled="True">
        <Configuration>
          <LogFileName>foo.trx</LogFileName>
        </Configuration>
      </Logger>
      <Logger friendlyName="html" enabled="True">
        <Configuration>
          <LogFileName>foo.html</LogFileName>
        </Configuration>
      </Logger>
    </Loggers>
  </LoggerRunSettings>
```

## MSTest element

These settings are specific to the test adapter that runs test methods that have the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute> attribute.

```xml
<MSTest>
    <MapInconclusiveToFailed>True</MapInconclusiveToFailed>
    <CaptureTraceOutput>false</CaptureTraceOutput>
    <DeleteDeploymentDirectoryAfterTestRunIsComplete>False</DeleteDeploymentDirectoryAfterTestRunIsComplete>
    <DeploymentEnabled>False</DeploymentEnabled>
    <AssemblyResolution>
      <Directory path="D:\myfolder\bin\" includeSubDirectories="false"/>
    </AssemblyResolution>
</MSTest>
```

|Configuration|Default|Values|
|-|-|-|
|**ForcedLegacyMode**|false|In Visual Studio 2012, the MSTest adapter was optimized to make it faster and more scalable. Some behavior, such as the order in which tests are run, might not be exactly as it was in previous editions of Visual Studio. Set this value to **true** to use the older test adapter.<br /><br />For example, you might use this setting if you have an *app.config* file specified for a unit test.<br /><br />We recommend that you consider refactoring your tests to allow you to use the newer adapter.|
|**IgnoreTestImpact**|false|The test impact feature prioritizes tests that are affected by recent changes, when run in MSTest or from Microsoft Test Manager (deprecated in Visual Studio 2017). This setting deactivates the feature. For more information, see [Which tests should be run since a previous build](/previous-versions/dd286589(v=vs.140)).|
|**SettingsFile**||You can specify a test settings file to use with the MSTest adapter here. You can also specify a test settings file [from the settings menu](#specify-a-run-settings-file-in-the-ide).<br /><br />If you specify this value, you must also set the **ForcedLegacyMode** to **true**.<br /><br />`<ForcedLegacyMode>true</ForcedLegacyMode>`|
|**KeepExecutorAliveAfterLegacyRun**|false|After a test run is completed, MSTest is shut down. Any process that is launched as part of the test is also killed. If you want to keep the test executor alive, set the value to **true**. For example, you could use this setting to keep the browser running between coded UI tests.|
|**DeploymentEnabled**|true|If you set the value to **false**, deployment items that you've specified in your test method aren't copied to the deployment directory.|
|**CaptureTraceOutput**|true|You can write to the debug trace from your test method using <xref:System.Diagnostics.Trace.WriteLine%2A?displayProperty=nameWithType>.|
|**DeleteDeploymentDirectoryAfterTestRunIsComplete**|true|To retain the deployment directory after a test run, set this value to **false**.|
|**MapInconclusiveToFailed**|false|If a test completes with an inconclusive status, it is mapped to the skipped status in **Test Explorer**. If you want inconclusive tests to be shown as failed, set the value to **true**.|
|**InProcMode**|false|If you want your tests to be run in the same process as the MSTest adapter, set this value to **true**. This setting provides a minor performance gain. But if a test exits with an exception, the remaining tests don't run.|
|**AssemblyResolution**|false|You can specify paths to additional assemblies when finding and running unit tests. For example, use these paths for dependency assemblies that aren't in the same directory as the test assembly. To specify a path, use a **Directory Path** element. Paths can include environment variables.<br /><br />`<AssemblyResolution>  <Directory path="D:\myfolder\bin\" includeSubDirectories="false"/> </AssemblyResolution>`|

## Example *.runsettings* file

The following XML shows the contents of a typical *.runsettings* file. Copy this code and edit it to suit your needs.

Each element of the file is optional because it has a default value.

```xml
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <!-- Configurations that affect the Test Framework -->
  <RunConfiguration>
    <!-- Use 0 for maximum process-level parallelization. This does not force parallelization within the test DLL (on the thread-level). You can also change it from the Test menu; choose "Run tests in parallel". Unchecked = 1 (only 1), checked = 0 (max). -->
    <MaxCpuCount>1</MaxCpuCount>
    <!-- Path relative to directory that contains .runsettings file-->
    <ResultsDirectory>.\TestResults</ResultsDirectory>

    <!-- Omit the whole tag for auto-detection. -->
    <!-- [x86] or x64, ARM, ARM64, s390x  -->
    <!-- You can also change it from the Test menu; choose "Processor Architecture for AnyCPU Projects" -->
    <TargetPlatform>x86</TargetPlatform>

    <!-- Any TargetFramework moniker or omit the whole tag for auto-detection. -->
    <!-- net48, [net40], net6.0, net5.0, netcoreapp3.1, uap10.0 etc. -->
    <TargetFrameworkVersion>net40</TargetFrameworkVersion>

    <!-- Path to Test Adapters -->
    <TestAdaptersPaths>%SystemDrive%\Temp\foo;%SystemDrive%\Temp\bar</TestAdaptersPaths>

    <!-- TestSessionTimeout was introduced in Visual Studio 2017 version 15.5 -->
    <!-- Specify timeout in milliseconds. A valid value should be greater than 0 -->
    <TestSessionTimeout>10000</TestSessionTimeout>

    <!-- true or false -->
    <!-- Value that specifies the exit code when no tests are discovered -->
    <TreatNoTestsAsError>true</TreatNoTestsAsError>
  </RunConfiguration>

  <!-- Configurations for data collectors -->
  <DataCollectionRunSettings>
    <DataCollectors>
      <DataCollector friendlyName="Code Coverage" uri="datacollector://Microsoft/CodeCoverage/2.0" assemblyQualifiedName="Microsoft.VisualStudio.Coverage.DynamicCoverageDataCollector, Microsoft.VisualStudio.TraceCollector, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
        <Configuration>
          <CodeCoverage>
            <ModulePaths>
              <Exclude>
                <ModulePath>.*CPPUnitTestFramework.*</ModulePath>
              </Exclude>
            </ModulePaths>

            <!-- We recommend you do not change the following values: -->
            <UseVerifiableInstrumentation>True</UseVerifiableInstrumentation>
            <AllowLowIntegrityProcesses>True</AllowLowIntegrityProcesses>
            <CollectFromChildProcesses>True</CollectFromChildProcesses>
            <CollectAspDotNet>False</CollectAspDotNet>

          </CodeCoverage>
        </Configuration>
      </DataCollector>

      <DataCollector uri="datacollector://microsoft/VideoRecorder/1.0" assemblyQualifiedName="Microsoft.VisualStudio.TestTools.DataCollection.VideoRecorder.VideoRecorderDataCollector, Microsoft.VisualStudio.TestTools.DataCollection.VideoRecorder, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" friendlyName="Screen and Voice Recorder">
        <!--Video data collector was introduced in Visual Studio 2017 version 15.5 -->
        <Configuration>
          <!-- Set "sendRecordedMediaForPassedTestCase" to "false" to add video attachments to failed tests only -->
          <MediaRecorder sendRecordedMediaForPassedTestCase="true"  xmlns="">           ​
            <ScreenCaptureVideo bitRate="512" frameRate="2" quality="20" />​
          </MediaRecorder>​
        </Configuration>
      </DataCollector>

      <!-- Configuration for blame data collector -->
      <DataCollector friendlyName="blame" enabled="True">
      </DataCollector>

    </DataCollectors>
  </DataCollectionRunSettings>

  <!-- Parameters used by tests at run time -->
  <TestRunParameters>
    <Parameter name="webAppUrl" value="http://localhost" />
    <Parameter name="webAppUserName" value="Admin" />
    <Parameter name="webAppPassword" value="Password" />
  </TestRunParameters>

  <!-- Configuration for loggers -->
  <LoggerRunSettings>
    <Loggers>
      <Logger friendlyName="console" enabled="True">
        <Configuration>
            <Verbosity>quiet</Verbosity>
        </Configuration>
      </Logger>
      <Logger friendlyName="trx" enabled="True">
        <Configuration>
          <LogFileName>foo.trx</LogFileName>
        </Configuration>
      </Logger>
      <Logger friendlyName="html" enabled="True">
        <Configuration>
          <LogFileName>foo.html</LogFileName>
        </Configuration>
      </Logger>
      <Logger friendlyName="blame" enabled="True" />
    </Loggers>
  </LoggerRunSettings>

  <!-- Adapter Specific sections -->

  <!-- MSTest adapter -->
  <MSTest>
    <MapInconclusiveToFailed>True</MapInconclusiveToFailed>
    <CaptureTraceOutput>false</CaptureTraceOutput>
    <DeleteDeploymentDirectoryAfterTestRunIsComplete>False</DeleteDeploymentDirectoryAfterTestRunIsComplete>
    <DeploymentEnabled>False</DeploymentEnabled>
    <AssemblyResolution>
      <Directory path="D:\myfolder\bin\" includeSubDirectories="false"/>
    </AssemblyResolution>
  </MSTest>

</RunSettings>
```

## Specify environment variables in the *.runsettings* file

Environment variables can be set in the *.runsettings* file, which can directly interact with the test host. Specifying environment variables in the *.runsettings* file is necessary to support nontrivial projects that require setting environment variables like *DOTNET_ROOT*. These variables are set while spawning the test host process and they are available in the host.

### Example

The following code is a sample *.runsettings* file that passes environment variables:

```xml
<?xml version="1.0" encoding="utf-8"?>
<!-- File name extension must be .runsettings -->
<RunSettings>
  <RunConfiguration>
    <EnvironmentVariables>
      <!-- List of environment variables we want to set-->
      <DOTNET_ROOT>C:\ProgramFiles\dotnet</DOTNET_ROOT>
      <SDK_PATH>C:\Codebase\Sdk</SDK_PATH>
    </EnvironmentVariables>
  </RunConfiguration>
</RunSettings>
```

The **RunConfiguration** node should contain an **EnvironmentVariables** node. An environment variable can be specified as an element name and its value.

> [!NOTE]
> Because these environment variables should always be set when the test host is started, the tests should always run in a separate process. For this, the */InIsolation* flag will be set when there are environment variables so that the test host is always invoked.

## See also

- [Configure a test run](https://github.com/microsoft/vstest-docs/blob/master/docs/configure.md)
- [Customize code coverage analysis](../test/customizing-code-coverage-analysis.md)
- [Visual Studio test task (Azure Test Plans)](/azure/devops/pipelines/tasks/test/vstest?view=vsts&preserve-view=true)
