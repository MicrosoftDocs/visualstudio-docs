---
title: "Live Unit Testing FAQ | Microsoft Docs"
ms.date: "2017-03-13"
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM"
  - "Live Unit Testing FAQ"
ms.assetid: 61baf3bb-646f-4c5a-b7c0-a6bdff68f21c
author: "rpetrusha"
ms.author: "ronpet"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Live Unit Testing Frequently Asked Questions

## Does Live Unit Testing work with .NET Core?  

**Answer:**

Yes. Live Unit Testing works with .NET Core and .NET Frameworks. Support for .NET Core was added recently in Visual Studio 2017 version 15.2. 

## Why doesn't Live Unit Testing work when I turn it on? 

**Answer:** 

The **Output Window** (when the Live Unit Testing drop-down is selected) should tell you why Live Unit Testing is not working. Live Unit testing may not work for one of the following reasons: 

- If NuGet packages referenced by the projects in the solution have not been restored, Live Unit Testing will not work. Doing an explicit build of the solution or restoring NuGet packages in the solution before turning Live Unit Testing on should resolve this issue. 

- If you are using MSTest-based tests in your projects, make sure that you remove the reference to `Microsoft.VisualStudio.QualityTools.UnitTestFramework`, and add references to the latest MSTest NuGet packages, `MSTest.TestAdapter` (a minimum version of 1.1.17 is required) and `MSTest.TestFramework` (a minimum version of 1.1.17 is required). For more information, see the "Supported test frameworks" section of the [Use Live Unit Testing in Visual Studio 2017 Enterprise Edition](live-unit-testing.md#supported-test-frameworks) topic.
 
- At least one project in your solution should have either a NuGet reference or direct reference to the xUnit, NUnit or MSTest test framework. This project should also reference a corresponding Visual Studio test adapters NuGet package. The Visual Studio test adapter can also be referenced through a `.runsettings` file. The `.runsettings` file must have an entry like the one below: 

   ```xml
    <RunSettings> 
       <RunConfiguration>
          <TestAdaptersPaths>path-to-your-test-adapter</TestAdaptersPaths>
       </RunConfiguration> 
    </RunSettings> 
   ``` 

## Why does Live Unit Testing show incorrect coverage after you upgrade the test adapter referenced in your Visual Studio Projects to the supported version?

**Answer:**

- If multiple projects in the solution reference the NuGet test adapter package, each of them must be upgraded to the supported version.

- Make sure the MSBuild .props file imported from the test adapter package is correctly updated as well. Check the NuGet package version/path of the import, which can usually be found near the top of the project file, like the following:

   ```xml
    <Import Project="..\packages\xunit.runner.visualstudio.2.2.0\build\net20\xunit.runner.visualstudio.props" Condition="Exists('..\packages\xunit.runner.visualstudio.2.2.0\build\net20\xunit.runner.visualstudio.props')" />
   ```

## Can I customize my Live Unit Testing builds? 

**Answer:**

If your solution requires custom steps to build for instrumentation (Live Unit Testing) that are not required for the "regular" non-instrumented build, then you can add code to your project or .targets files that checks for the `BuildingForLiveUnitTesting` property and performs custom pre/post build steps. You can also choose to remove certain build steps (like publishing or generating packages) or to add build steps (like copying prerequisites) to a Live Unit Testing build based on this project property. This will not alter your regular build in any way and will only impact Live Unit Testing builds. 

For example, there may be a target that produces NuGet packages during a regular build. You probably do not want NuGet packages to be generated after every edit you make. So you can disable that target in the Live Unit Testing build by doing something like the following:   

```xml
<Target Name="GenerateNuGetPackages" BeforeTargets="AfterBuild" Condition="'$(BuildingForLiveUnitTesting)' != 'true'"> 
    <Exec Command='"$(MSBuildThisFileDirectory)..\tools\GenPac" '/> 
</Target> 
```

## Error messages with &lt;OutputPath&gt; or &lt;OutDir&gt;

**Why do I get the following error when Live Unit Testing tries to build my solution: "...appears to unconditionally set `<OutputPath>` or `<OutDir>`. Live Unit Testing will not execute tests from the output assembly"?**

**Answer:**

This can happen if the build process for your solution unconditionally overrides `<OutputPath>` or `<OutDir>` so that it is not a subdirectory of `<BaseOutputPath>`. In such cases, Live Unit Testing will not work because it also overrides these to ensure that build artifacts are dropped to a folder under `<BaseOutputPath>`. If you must override the location where you want your build artifacts to be dropped in a regular build, override the `<OutputPath>` conditionally based on `<BaseOutputPath>`. 

For example, if your build overrides the `<OutputPath>` as shown below: 

```xml 
<Project> 
  <PropertyGroup> 
    <OutputPath>$(SolutionDir)Artifacts\$(Configuration)\bin\$(MSBuildProjectName)</OutputPath> 
  </PropertyGroup> 
</Project> 
```

then you can replace it with the following: 

```xml 
<Project> 
  <PropertyGroup> 
    <BaseOutputPath Condition="'$(BaseOutputPath)' == ''">$(SolutionDir)Artifacts\$(Configuration)\bin\$(MSBuildProjectName)\</BaseOutputPath> 
    <OutputPath Condition="'$(OutputPath)' == ''">$(BaseOutputPath)</OutputPath> 
  </PropertyGroup> 
</Project> 
```
 
This ensures that `<OutputPath>` lies within the `<BaseOutputPath>` folder. 
 
Do not override `<OutDir>` directly in your build process; override `<OutputPath>` instead to drop build artifacts to a specific location.
  
## Setting the location of Live Unit Testing build artifacts

**I want the artifacts of a Live Unit Testing build to go to a specific location instead of the default location under the `.vs` folder. How can I change that?**
 
**Answer:**

Set the `LiveUnitTesting_BuildRoot` user-level environment variable to the path where you want the Live Unit Testing build artifacts to be dropped.  

## How is running tests from Test Explorer window different from running tests in Live Unit Testing? 

**Answer:**

There are several differences: 

- Running or debugging tests from the Test Explorer window runs regular binaries, whereas Live Unit Testing runs instrumented binaries. If you want to debug instrumented binaries, adding a [Debugger.Launch](xref:System.Diagnostics.Debugger.Launch) method call in your test method causes the debugger to launch whenever that method is executed (including when it is executed by Live Unit Testing), and you can then attach and debug the instrumented binary. However, our hope is that instrumentation is transparent to you for most user scenarios, and that you do not need to debug instrumented binaries. 

- Live Unit Testing does not create a new application domain to run tests, but tests run from the Test Explorer window do create a new application domain. 

- Live Unit Testing runs tests in each test assembly sequentially, whereas if you run multiple tests from the Test Explorer window and you selected the **Run Tests in Parallel** button, they will run in parallel. 

- Discovery and execution of tests in Live Unit Testing uses version 2 of `TestPlatform`, whereas the Test Explorer window uses version 1. You should not notice a difference in most cases, though.  

- Test Explorer currently runs tests in a single-threaded apartment (STA) by default, whereas Live Unit Testing runs tests in a multithreaded apartment (MTA). To run MSTest tests in STA in Live Unit Testing, decorate the test method or the containing class with the `<STATestMethod>` or `<STATestClass>` attribute that can be found in the `MSTest.STAExtensions 1.0.3-beta` NuGet package. For NUnit, decorate the test method with the `<RequiresThread(ApartmentState.STA)>` attribute, and for xUnit, with the `<STAFact>` attribute.
 
## How do I exclude tests from participating in Live Unit Testing?

**Answer:**

See the "Including and excluding test projects and test methods" section of the [Use Live Unit Testing in Visual Studio 2017 Enterprise Edition](live-unit-testing.md#including-and-excluding-test-projects-and-test-methods) topic for the user-specific setting. This is extremely useful when you want to run a specific set of tests for a particular edit session or to persist your own personal preferences.
  
For solution-specific settings, you can apply the <xref:System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute?displayProperty=fullName> attribute programmatically to exclude methods, properties, classes, or structures from being instrumented by Live Unit Testing. Additionally, you can also set the `<ExcludeFromCodeCoverage>` property to `true` in your project file to exclude the whole project from being instrumented. Live Unit Testing will still run the tests that have not been instrumented, but their coverage will not be visualized.

You can also check whether `Microsoft.CodeAnalysis.LiveUnitTesting.Runtime` is loaded in the current application domain and disable tests based on that. For example, you can do something like the following with xUnit:

```cs
[ExcludeFromCodeCoverage]
public class SkipLiveFactAttribute : FactAttribute
{
   private static bool s_lutRuntimeLoaded = AppDomain.CurrentDomain.GetAssemblies().Any(a => a.GetName().Name == 
                                            "Microsoft.CodeAnalysis.LiveUnitTesting.Runtime");
   public override string Skip => s_lutRuntimeLoaded ? "Test excluded from Live Unit Testing" : "";
}

public class Class1
{
   [SkipLiveFact]
   public void F()
   {
      Assert.True(true);
   }
}
```

## Why are Win32 PE headers different in instrumented assemblies built by Live Unit testing? 

**Answer:**

There is a known bug that may result in Live Unit Testing builds failing to embed the following Win32 PE Header data: 

- File Version (specified by @System.Reflection.AssemblyFileVersionAttribute in code). 

- Win32 Icon (specified by `/win32icon:` on the command line). 

- Win32 Manifest (specified by `/win32manifest:` on the command line). 

Tests that rely on these values may fail when executed by Live Unit testing.

## Why does Live Unit testing keep building my solution all the time even if I am not making any edits? 

**Answer:**

This can happen if the build process of your solution generates source code that is part of the solution itself, and your build target files do not have appropriate inputs and outputs specified. Targets should be given a list of inputs and outputs so that MSBuild can perform the appropriate up-to-date checks and determine whether a new build is required. 

Live Unit Testing starts a build whenever it detects that source files have changed. Because the build of your solution generates source files, Live Unit Testing will get into an infinite build loop. If, however, the inputs and outputs of the target are checked when Live Unit Testing starts the second build (after detecting the newly generated source files from the previous build), it will break out of the loop because the inputs and outputs checks will indicate that everything is up-to-date.   

## How does Live Unit testing work with the Lightweight Solution Load feature? 

**Answer:**

Live Unit Testing currently doesn't work well with the Lightweight Solution load feature if all projects in the solution are not yet loaded. You may get incorrect coverage information in such scenarios.
 
## Why does Live Unit Testing does not capture coverage from a new process created by a test?
 
**Answer:**

This is a known issue which we were not able to fix in Visual Studio 2017 release. It should be fixed in a subsequent update of Visual Studio 2017. 

## Why does nothing happen after I include or exclude tests from the Live Test set? 

**Answer:**

This is a known issue. To work around this, you will need to make an edit to any file after you have included or excluded tests.  

## Live Unit Testing and editor icons 

**Why do I not see any icons in the editor even though Live Unit Testing seems to be running the tests based on the messages in the output window?** 

**Answer:**

This happens if the assemblies that Live Unit Testing is operating on are not instrumented for any reason. For example, Live Unit Testing is not compatible with projects that set `<UseHostCompilerIfAvailable>false</UseHostCompilerIfAvailable>`. In this case, your build process will need to be updated to either remove this setting or to change it to `true` for Live Unit Testing to work.  

## How do I collect more detailed logs to file bug reports? 

**Answer:**

You can do several things to collect more detailed logs: 

- Go to **Tools**, **Options**, **Live Unit Testing** and change the logging option to **Verbose**. This causes more detailed logs to be shown in the output window. 

- Set the `LiveUnitTesting_BuildLog` user environment variable to the name of the file you want to use to capture the MSBuild log. Detailed MSBuild log messages from Live Unit Testing builds can then be retrieved from that file.

- Set the `LiveUnitTesting_TestPlatformLog` user environment variable to `1` to capture the Test Platform log. Detailed Test Platform log messages from Live Unit Testing runs can then be retrieved from `[Solution Root]\.vs\[Solution Name]\log\[VisualStudio Process ID]`.

- Create a user-level environment variable named `VS_UTE_DIAGNOSTICS` and set it to 1 (or any value) and restart Visual Studio. Now you should see lots of logging in the **Output - Tests** tab in Visual Studio. 
 
## See also

[Live Unit Testing](live-unit-testing.md)
 
