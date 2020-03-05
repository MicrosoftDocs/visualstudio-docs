---
title: "Configure unit tests by using a .runsettings file | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: f7e9e4a2-5d01-4f78-b408-5be3892bd162
caps.latest.revision: 28
ms.author: jillfra
manager: jillfra
---
# Configure unit tests by using a .runsettings file
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Unit tests in Visual Studio can be configured by using a *.runsettings file. (The file name doesn’t matter, provided you use the extension ‘.runsettings.’) For example, you can change the .NET Framework on which the tests will be run, the directory where test results are delivered, and the data collected during a test run.

 If you don’t want to do any special configuration, you don’t need a *.runsettings file. The most frequent use is to customize [Code Coverage](../test/customizing-code-coverage-analysis.md).

> [!NOTE]
> **.runsettings and .testsettings**
>
> There are two types of file for configuring tests. *.runsettings are used for unit tests. And \*.testsettings for [lab environment tests](https://msdn.microsoft.com/library/0c15317e-80c6-4317-aed3-82b8e15e3901), web performance and load tests, and for customizing some types of diagnostic data adapters such as IntelliTrace and event log adapters.
>
> In previous editions of Visual Studio up to 2010, unit tests were also customized by using *.testsettings files. You can still do that, but the tests will run more slowly than if you use the equivalent configurations in a \*.runsettings file.

## Customizing tests with a .runsettings file

1. Add an XML file to your Visual Studio solution and rename it to test.runsettings. (The filename doesn’t matter, but the extension must be .runsettings.)

2. Replace the file content with the [example](#example).

    Edit it to your own needs.

3. On the **Test** menu, choose **Test Settings**, **Select Test Settings File**.

   You can create more than one \*.runsettings file in your solution, and enable or disable them at different times by using the **Test Settings** menu.

   ![Enabling a run settings file](../test/media/runsettings-1.png "RunSettings-1")

## <a name="example"></a> Copy this example .runsettings file
 Here is a typical *.runsettings file. Each element of the file is optional, because every value has a default.

```xml
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <!-- Configurations that affect the Test Framework -->
  <RunConfiguration>
    <MaxCpuCount>1</MaxCpuCount>
    <!-- Path relative to solution directory -->
    <ResultsDirectory>.\TestResults</ResultsDirectory>

    <!-- [x86] | x64
      - You can also change it from menu Test, Test Settings, Default Processor Architecture -->
    <TargetPlatform>x86</TargetPlatform>

    <!-- Framework35 | [Framework40] | Framework45 -->
    <TargetFrameworkVersion>Framework40</TargetFrameworkVersion>

    <!-- Path to Test Adapters -->
    <TestAdaptersPaths>%SystemDrive%\Temp\foo;%SystemDrive%\Temp\bar</TestAdaptersPaths>
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

    </DataCollectors>
  </DataCollectionRunSettings>

  <!-- Parameters used by tests at runtime -->
  <TestRunParameters>
    <Parameter name="webAppUrl" value="http://localhost" />
    <Parameter name="webAppUserName" value="Admin" />
    <Parameter name="webAppPassword" value="Password" />
  </TestRunParameters>

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

 The .runsettings file is also used to configure [Code Coverage](../test/customizing-code-coverage-analysis.md).

 The remainder of this topic describes the file content.

## Edit your .runsettings file
 The .runsettings file has the following elements.

### Test run configuration

|Node|Default|Values|
|----------|-------------|------------|
|`ResultsDirectory`||The directory where test results will be placed.|
|`TargetFrameworkVersion`|Framework40|Framework35, Framework40, Framework45<br /><br /> This specifies which version of the unit test framework is used to discover and execute the tests. It can be different from the version of the .NET platform that you specify in the build properties of the unit test project.|
|`TargetPlatform`|x86|x86, x64|
|`TreatTestAdapterErrorsAsWarnings`|false|false, true|
|`TestAdaptersPaths`||One or multiple paths to the directory where the TestAdapters are located|
|`MaxCpuCount`|1|This controls the degree of parallel test execution when running unit tests, using available cores on the machine.  The test execution engine starts as a distinct process on each available core and gives each core a container with tests to run, like an assembly, DLL, or relevant artifact.  The test container is the scheduling unit.  In each container, the tests are run according to the test framework.  If there are many containers, then as processes finish executing the tests in a container, they are given the next available container.<br /><br /> MaxCpuCount can be:<br /><br /> n, where 1 <= n <= number of cores: up to n processes will be launched<br /><br /> n, where n = any other value:  the number of processes launched will be up to as many as available cores on the machine|

### Diagnostic Data Adapters (Data Collectors)
 The `DataCollectors` element specifies settings of diagnostic data adapters. Diagnostic data adapters are used to gather additional information about the environment and the application under test. Each adapter has default settings, and you only have to provide settings if you don’t want to use the defaults.

#### Code coverage adapter
 The code coverage data collector creates a log of which parts of the application code have been exercised in the test. For more information about customizing the settings for code coverage, see [Customizing Code Coverage Analysis](../test/customizing-code-coverage-analysis.md).

#### Other diagnostic data adapters
 The code coverage adapter is currently the only adapter that can be customized by using the run settings file.

 To customize any other type of diagnostic data adapter, you must use a test settings file. For more information, see [Specifying Test Settings for Visual Studio Tests](https://msdn.microsoft.com/library/0c15317e-80c6-4317-aed3-82b8e15e3901).

#### TestRunParameters
 TestRunParameters provides a way to define variables and values that are available to the tests at runtime.

### MSTest Run Settings
 These settings are specific to the test adapter that runs test methods that have the `[TestMethod]` attribute.

|Configuration|Default|Values|
|-------------------|-------------|------------|
|ForcedLegacyMode|false|In Visual Studio 2012, the MSTest adapter has been optimized to make it faster and more scalable. Some behavior, such as the order in which tests are run, might not be exactly as it was in previous editions of Visual Studio. Set this value `true` to use the older test adapter.<br /><br /> For example, you might use this if you have an app.config file specified   for a unit test.<br /><br /> We recommend that you consider refactoring your tests to allow you to use the newer adapter.|
|IgnoreTestImpact|false|The test impact feature prioritizes tests that are affected by recent changes, when run in MSTest or from Microsoft Test Manager. This setting deactivates the feature. For more   information, see [How to: Collect Data to Check Which Tests Should be Run After Code Changes](https://msdn.microsoft.com/library/2f921ea1-9bb0-4870-a30f-0521fc22cb47).|
|SettingsFile||You can specify a test settings file to use with the MS Test adapter here. You can also specify a test settings file using the menu **Test**, **Test Settings**, **Select Test Settings File**.<br /><br /> If you specify this value, you must also set the **ForcedlegacyMode** to **true**.<br /><br /> `<RunSettings>   <MSTest>     <SettingsFile>my.testsettings</SettingsFile>      <ForcedLegacyMode>true</ForcedLegacyMode>    </MSTest> </RunSettings>`|
|KeepExecutorAliveAfterLegacyRun|false|After a test run is completed, MSTest is shut down. Any process that is launched as part of the test will also be killed at this time. If you want to keep the test executor alive, turn this configuration to true.<br /><br /> For example, you could use this to keep the browser running between coded UI tests.|
|DeploymentEnabled|true|If you set this to false, deployment items that you have specified in your test method will not be copied to the deployment directory.|
|CaptureTraceOutput|true|You can write to the debug trace from your Test method using Trace.WriteLine. Using this configuration, you can turn off these debug traces.|
|DeleteDeploymentDirectoryAfterTestRunIsComplete|true|You can retain the Deployment Directory after a test run by setting this value to false.|
|MapInconclusiveToFailed|false|If a test returns with an inconclusive status, it is usually mapped to Skipped status in Test Explorer. If you want Inconclusive tests to be showed as Failed, use this configuration.|
|InProcMode|false|If you want your tests to be run in the same process as the MS Test adapter, set this value to true. This setting provides a minor performance gain. But if a test exits with an exception, the other tests will not continue.|
|AssemblyResolution|false|You can specify paths to additional assemblies when finding and running unit tests.  For example, use these paths for dependency assemblies that don't reside in the same directory as the test assembly.  To specify a path, use a "Directory Path" element.  Paths can contain environment variables.<br /><br /> `<AssemblyResolution>  <Directory Path>"D:\myfolder\bin\" includeSubDirectories="false"/> </AssemblyResolution>`|

## See Also
 [Customizing Code Coverage Analysis](../test/customizing-code-coverage-analysis.md)
 [Specifying Test Settings for Visual Studio Tests](https://msdn.microsoft.com/library/0c15317e-80c6-4317-aed3-82b8e15e3901)
