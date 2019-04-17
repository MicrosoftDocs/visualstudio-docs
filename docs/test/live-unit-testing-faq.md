---
title: "Live Unit Testing FAQ"
ms.date: "10/03/2017"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio ALM"
  - "Live Unit Testing FAQ"
author: rpetrusha
ms.author: "ronpet"
ms.workload:
  - "dotnet"
---
# Live Unit Testing frequently asked questions

## Latest features

**Live Unit Testing is improved and enhanced regularly. How can I find information about the latest new features and enhancements?**

To learn about the new features and enhancements that have been made to Live Unit Testing, see [What's New in Live Unit Testing](live-unit-testing-whats-new.md).

## Supported frameworks and versions

**What test frameworks does Live Unit Testing support and what are the minimum supported versions?**

Live Unit Testing works with the three popular unit testing frameworks listed in the table that follows. The minimum supported version of their adapters and frameworks is also listed in the table. The unit testing frameworks are all available from NuGet.org.

|Test Framework  |Visual Studio Adapter minimum version  |Framework minimum version  |
|---------|---------|---------|
|xUnit.net |xunit.runner.visualstudio version 2.2.0-beta3-build1187 |xunit 1.9.2 |
|NUnit |NUnit3TestAdapter version 3.5.1 |NUnit version 3.5.0 |
|MSTest |MSTest.TestAdapter 1.1.4-preview |MSTest.TestFramework 1.0.5-preview |

If you have older MSTest based test projects that reference `Microsoft.VisualStudio.QualityTools.UnitTestFramework` and you don’t wish to move to the newer MSTest NuGet packages, upgrade to Visual Studio 2017 version 15.4 or later.

In some cases, you may need to explicitly restore the NuGet packages referenced by the projects in the solution in order for Live Unit Testing to work. You can restore the packages either by doing an explicit build of the solution (select **Build**, **Rebuild Solution** from the top-level Visual Studio menu), or by right-clicking on the solution and selecting **Restore NuGet Packages** before enabling Living Unit Testing.

## .NET Core support

**Does Live Unit Testing work with .NET Core?**

Yes. Live Unit Testing works with .NET Core and the .NET Framework. Support for .NET Core was added in Visual Studio 2017 version 15.3. Upgrade to this version of Visual Studio or later if you want Live Unit Testing support for .NET Core.

## Configuration

**Why doesn't Live Unit Testing work when I turn it on?**

The **Output** window (when the Live Unit Testing drop-down is selected) should tell you why Live Unit Testing is not working. Live Unit Testing may not work for one of the following reasons:

- If NuGet packages referenced by the projects in the solution have not been restored, Live Unit Testing will not work. Doing an explicit build of the solution or restoring NuGet packages in the solution before turning on Live Unit Testing should resolve this issue.

- If you are using MSTest-based tests in your projects, make sure that you remove the reference to `Microsoft.VisualStudio.QualityTools.UnitTestFramework`, and add references to the latest MSTest NuGet packages, `MSTest.TestAdapter` (a minimum version of 1.1.11 is required) and `MSTest.TestFramework` (a minimum version of 1.1.11 is required). For more information, see the "Supported test frameworks" section of the [Use Live Unit Testing in Visual Studio](live-unit-testing.md#supported-test-frameworks) article.

- At least one project in your solution should have either a NuGet reference or direct reference to the xUnit, NUnit, or MSTest test framework. This project should also reference a corresponding Visual Studio test adapters NuGet package. The Visual Studio test adapter can also be referenced through a *.runsettings* file. The *.runsettings* file must have an entry like the following example:

```xml
<RunSettings>
    <RunConfiguration>
          <TestAdaptersPaths>path-to-your-test-adapter</TestAdaptersPaths>
     </RunConfiguration>
</RunSettings>
```

## Incorrect coverage after upgrade

**Why does Live Unit Testing show incorrect coverage after you upgrade the test adapter referenced in your Visual Studio Projects to the supported version?**

- If multiple projects in the solution reference the NuGet test adapter package, each of them must be upgraded to the supported version.

- Make sure the MSBuild *.props* file imported from the test adapter package is correctly updated as well. Check the NuGet package version/path of the import, which can usually be found near the top of the project file, like the following:

   ```xml
    <Import Project="..\packages\xunit.runner.visualstudio.2.2.0\build\net20\xunit.runner.visualstudio.props" Condition="Exists('..\packages\xunit.runner.visualstudio.2.2.0\build\net20\xunit.runner.visualstudio.props')" />
   ```

## Customize builds

**Can I customize my Live Unit Testing builds?**

If your solution requires custom steps to build for instrumentation (Live Unit Testing) that are not required for the "regular" non-instrumented build, then you can add code to your project or *.targets* files that checks for the `BuildingForLiveUnitTesting` property and performs custom pre/post build steps. You can also choose to remove certain build steps (like publishing or generating packages) or to add build steps (like copying prerequisites) to a Live Unit Testing build based on this project property. Customizing your build based on this property does not alter your regular build in any way, and only impacts Live Unit Testing builds.

For example, there may be a target that produces NuGet packages during a regular build. You probably do not want NuGet packages to be generated after every edit you make. So you can disable that target in the Live Unit Testing build by doing something like the following:  

```xml
<Target Name="GenerateNuGetPackages" BeforeTargets="AfterBuild" Condition="!$(BuildingForLiveUnitTesting)">
    <Exec Command='"$(MSBuildThisFileDirectory)..\tools\GenPac" '/>
</Target>
```

## Error messages with &lt;OutputPath&gt; or &lt;OutDir&gt;

**Why do I get the following error when Live Unit Testing tries to build my solution: "...appears to unconditionally set `<OutputPath>` or `<OutDir>`. Live Unit Testing will not execute tests from the output assembly"?**

You can get this error if the build process for your solution unconditionally overrides `<OutputPath>` or `<OutDir>` so that it is not a subdirectory of `<BaseOutputPath>`. In such cases, Live Unit Testing will not work because it also overrides these values to ensure that build artifacts are dropped to a folder under `<BaseOutputPath>`. If you must override the location where you want your build artifacts to be dropped in a regular build, override the `<OutputPath>` conditionally based on `<BaseOutputPath>`.

For example, if your build overrides the `<OutputPath>` as shown below:

```xml 
<Project>
  <PropertyGroup>
    <OutputPath>$(SolutionDir)Artifacts\$(Configuration)\bin\$(MSBuildProjectName)</OutputPath>
  </PropertyGroup>
</Project>
```

then you can replace it with the following XML:

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

## Set the location of build artifacts

**I want the artifacts of a Live Unit Testing build to go to a specific location instead of the default location under the *.vs* folder. How can I change that?**

Set the `LiveUnitTesting_BuildRoot` user-level environment variable to the path where you want the Live Unit Testing build artifacts to be dropped. 

## Test Explorer vs. Live Unit Testing test runs

**How is running tests from Test Explorer window different from running tests in Live Unit Testing?**

There are several differences:

- Running or debugging tests from the **Test Explorer** window runs regular binaries, whereas Live Unit Testing runs instrumented binaries. If you want to debug instrumented binaries, adding a [Debugger.Launch](xref:System.Diagnostics.Debugger.Launch) method call in your test method causes the debugger to launch whenever that method is executed (including when it is executed by Live Unit Testing), and you can then attach and debug the instrumented binary. However, our hope is that instrumentation is transparent to you for most user scenarios, and that you do not need to debug instrumented binaries.

- Live Unit Testing does not create a new application domain to run tests, but tests run from the **Test Explorer** window do create a new application domain.

- Live Unit Testing runs tests in each test assembly sequentially, whereas if you run multiple tests from the **Test Explorer** window and you selected the **Run Tests in Parallel** button, they will run in parallel.

- Discovery and execution of tests in Live Unit Testing uses version 2 of `TestPlatform`, whereas the **Test Explorer** window uses version 1. You won't notice a difference in most cases, though.

- **Test Explorer** currently runs tests in a single-threaded apartment (STA) by default, whereas Live Unit Testing runs tests in a multithreaded apartment (MTA). To run MSTest tests in STA in Live Unit Testing, decorate the test method or the containing class with the `<STATestMethod>` or `<STATestClass>` attribute that can be found in the `MSTest.STAExtensions 1.0.3-beta` NuGet package. For NUnit, decorate the test method with the `<RequiresThread(ApartmentState.STA)>` attribute, and for xUnit, with the `<STAFact>` attribute.

## Exclude tests

**How do I exclude tests from participating in Live Unit Testing?**

See the "Include and exclude test projects and test methods" section of the [Use Live Unit Testing in Visual Studio](live-unit-testing.md#include-and-exclude-test-projects-and-test-methods) article for the user-specific setting. Including or excluding tests is useful when you want to run a specific set of tests for a particular edit session or to persist your own personal preferences.

For solution-specific settings, you can apply the <xref:System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute?displayProperty=fullName> attribute programmatically to exclude methods, properties, classes, or structures from being instrumented by Live Unit Testing. Additionally, you can also set the `<ExcludeFromCodeCoverage>` property to `true` in your project file to exclude the whole project from being instrumented. Live Unit Testing will still run the tests that have not been instrumented, but their coverage will not be visualized.

You can also check whether `Microsoft.CodeAnalysis.LiveUnitTesting.Runtime` is loaded in the current application domain and disable tests based on why. For example, you can do something like the following with xUnit:

```csharp
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

## Win32 PE headers

**Why are Win32 PE headers different in instrumented assemblies built by Live Unit testing?**

This issue is fixed and does not exist in Visual Studio 2017 version 15.3 and later.

For older versions of Visual Studio 2017, there is a known bug that may result in Live Unit Testing builds failing to embed the following Win32 PE Header data:

- File Version (specified by @System.Reflection.AssemblyFileVersionAttribute in code).

- Win32 Icon (specified by `/win32icon:` on the command line).

- Win32 Manifest (specified by `/win32manifest:` on the command line).

Tests that rely on these values may fail when executed by Live Unit testing.

## Continuous builds

**Why does Live Unit testing keep building my solution all the time even if I am not making any edits?**

Your solution can build even if you're not making edits if the build process of your solution generates source code that is part of the solution itself, and your build target files do not have appropriate inputs and outputs specified. Targets should be given a list of inputs and outputs so that MSBuild can perform the appropriate up-to-date checks and determine whether a new build is required.

Live Unit Testing starts a build whenever it detects that source files have changed. Because the build of your solution generates source files, Live Unit Testing will get into an infinite build loop. If, however, the inputs and outputs of the target are checked when Live Unit Testing starts the second build (after detecting the newly generated source files from the previous build), it will break out of the build loop because the inputs and outputs checks will indicate that everything is up-to-date.  

## Lightweight solution load

**How does Live Unit testing work with the lightweight solution load feature?**

Live Unit Testing currently doesn't work well with the lightweight solution load feature. It works only after at least one of the test projects is loaded. Until then, it won't work because Live Unit Testing is dependent on at least one of the test projects referencing a test adapter (MSTest, xUnit, or NUnit) being loaded.

> [!NOTE]
> Lightweight solution load is no longer available in Visual Studio 2017 version 15.5 and later. In Visual Studio 2017 version 15.5 and later, large solutions that contain managed code load much faster than previously, even without lightweight solution load.

## New process coverage

**Why doesn't Live Unit Testing capture coverage from a new process created by a test?**

This is a known issue and should be fixed in a subsequent release.

## Including or excluding tests doesn't work

**Why does nothing happen after I include or exclude tests from the Live Test set?**

This issue is fixed and does not exist in Visual Studio 2017 version 15.3 and later.

For older versions of Visual Studio 2017, this is a known issue. To work around this issue, you will need to make an edit to any file after you have included or excluded tests.

## Editor icons

**Why do I not see any icons in the editor even though Live Unit Testing seems to be running the tests based on the messages in the Output window?**

You might not see icons in the editor if the assemblies that Live Unit Testing is operating on aren't instrumented for any reason. For example, Live Unit Testing is not compatible with projects that set `<UseHostCompilerIfAvailable>false</UseHostCompilerIfAvailable>`. In this case, your build process needs to be updated to either remove this setting or to change it to `true` for Live Unit Testing to work. 

## Capture logs

**How do I collect more detailed logs to file bug reports?**

You can do several things to collect more detailed logs:

- Go to **Tools** > **Options** > **Live Unit Testing** and change the logging option to **Verbose**. Verbose logging causes more detailed logs to be shown in the **Output** window.

- Set the `LiveUnitTesting_BuildLog` user environment variable to the name of the file you want to use to capture the MSBuild log. Detailed MSBuild log messages from Live Unit Testing builds can then be retrieved from that file.

- Set the `LiveUnitTesting_TestPlatformLog` user environment variable to `1` to capture the Test Platform log. Detailed Test Platform log messages from Live Unit Testing runs can then be retrieved from `[Solution Root]\.vs\[Solution Name]\log\[VisualStudio Process ID]`.

- Create a user-level environment variable named `VS_UTE_DIAGNOSTICS` and set it to 1 (or any value) and restart Visual Studio. Now you should see lots of logging in the **Output - Tests** tab in Visual Studio.

## See also

- [Live Unit Testing](live-unit-testing.md)
