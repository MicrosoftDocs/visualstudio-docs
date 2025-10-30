---
title: Update from MSTestV1 to MSTestV2 
ms.date: 12/04/2023
description: Upgrade an MSTestV1 test project to target MSTestV2 in the .csproj file, and review the MSTestV1 features that aren't available in MSTestV2.
ms.topic: upgrade-and-migration-article
f1_keywords:
- vs.UnitTest.Migrate
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Upgrade from MSTestV1 to MSTestV2

You can upgrade your test project by retargeting the MSTest version referenced in your *.csproj* from the MSTestV1 to MSTestV2. Not all features in MSTestV1 were brought forward into MSTestV2, so some changes may be required to resolve errors. See [MSTestV1 features that aren't supported in MSTestV2](#mstestv1-features-that-arent-supported-in-mstestv2) to understand what features no longer function. Some of these features might need to be removed from your tests.

1. Remove the assembly reference to Microsoft.VisualStudio.QualityTools.UnitTestFramework from your unit test project.
2. Add NuGet package references to MSTestV2 including the [MSTest.TestFramework](https://www.nuget.org/packages/MSTest.TestFramework) and the [MSTest.TestAdapter](https://www.nuget.org/packages/MSTest.TestAdapter/) packages on nuget.org. You can install packages in the NuGet Package Manager Console with the following commands:

    ```console
    PM> Install-Package MSTest.TestAdapter -Version 3.1.1
    PM> Install-Package MSTest.TestFramework -Version 3.1.1
    ```

### Old style csproj example

Sample *.csproj* targeting MSTestV1:

```xml
<Reference Include="Microsoft.VisualStudio.QualityTools.UnitTestFramework, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
  <Private>False</Private>
</Reference>
```

Sample *.csproj* now targeting MSTestV2:

```xml
<Reference Include="Microsoft.VisualStudio.TestPlatform.TestFramework, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
  <HintPath>..\packages\MSTest.TestFramework.2.1.2\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.dll</HintPath>
</Reference>
```

> [!NOTE]
> Test projects that are Coded UI tests or Web Load Tests aren't compatible with MSTestV2. These project types have been deprecated. Read more on [Coded UI Test deprecation](https://devblogs.microsoft.com/devops/changes-to-coded-ui-test-in-visual-studio-2019/) and [Web Load Test deprecation](https://devblogs.microsoft.com/devops/cloud-based-load-testing-service-eol/).

### SDK-style csproj (.NET Core and .NET 5 or later)

If your *.csproj* is the newer SDK-style *.csproj* you're most likely already using MSTestV2. You can find the NuGet packages for [MSTestV2](https://www.nuget.org/packages/MSTest.TestFramework) and the [MSTestV2 Adapter](https://www.nuget.org/packages/MSTest.TestAdapter/) on NuGet.

Example:

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.7.1" />
  <PackageReference Include="MSTest.TestAdapter" Version="3.1.1" />
  <PackageReference Include="MSTest.TestFramework" Version="3.1.1" />
</ItemGroup>
```

## Why Upgrade to MSTestV2?

In 2016, we released the next step in evolving the MSTest framework with MSTestV2. You can read more about this change in the announcement [blog post](https://devblogs.microsoft.com/devops/taking-the-mstest-framework-forward-with-mstest-v2/).

* MSTestV2 is more easily acquired and updated because it's delivered as a [NuGet Package](https://www.nuget.org/packages/MSTest.TestFramework/).
* MSTestV2 is [open source](https://github.com/microsoft/testfx).
* Uniform app-platform support – MSTestV2 is a converged implementation that offers uniform app-platform support across .NET Framework, .NET Core, ASP.NET Core, and UWP. [Read more](https://blogs.msdn.microsoft.com/devops/2016/09/01/announcing-mstest-v2-framework-support-for-net-core-1-0-rtm/).
* The implementation is fully cross platform (Windows, Linux, Mac). [Read more](https://blogs.msdn.microsoft.com/devops/2017/04/05/mstest-v2-is-open-source/).
* MSTestV2 supports targeting .NET Framework 4.5.0 and later, .NET Core 1.0 and later (Universal Windows Apps 10+), ASP.NET Core 1.0 and later, and .NET 5 and later.
* Provides a uniform, single end-user extensibility mechanism. [Read more](https://blogs.msdn.microsoft.com/devops/2017/07/18/extending-mstest-v2/).
* Provides a uniform `DataRow` support for all MSTest based test projects. [Read more](https://blogs.msdn.microsoft.com/devops/2017/02/25/mstest-v2-now-and-ahead/).
* Enables placing the `TestCategory` attribute at the level of a class or assembly. [Read more](https://blogs.msdn.microsoft.com/devops/2017/02/25/mstest-v2-now-and-ahead/).
* Test methods from base classes defined in another assembly are now discovered and run from the derived Test class. This change brings in a consistent behavior with derived test class types. If this behavior isn't required for compatibility reasons, it can be changed back using the following run settings:

    ```xml
    <RunSettings>    
    <MSTest> 
      <EnableBaseClassTestMethodsFromOtherAssemblies>false</EnableBaseClassTestMethodsFromOtherAssemblies> 
    </MSTest> 
    </RunSettings>
    ```

* Provides finer-grained control over parallel execution via [in-assembly parallel execution](https://github.com/Microsoft/testfx-docs/blob/main/RFCs/004-In-Assembly-Parallel-Execution.md) of tests. This feature enables running tests within an assembly in parallel.
* The `TestCleanup` method on a `TestClass` is invoked even if its corresponding `TestInitialize` method fails. [Issue details](https://github.com/Microsoft/testfx/issues/250).
* The time taken by `AssemblyInitialize` and `ClassInitialize` isn't counted towards the test duration. This change limits their impact on a test timing out.
* Tests that aren't runnable can be configured to be marked as failed via the `MapNotRunnableToFailed` tag, which is part of the adapter node in the `.runsettings` file.

    ```xml
    <RunSettings>    
    <MSTest> 
      <MapNotRunnableToFailed>true</MapNotRunnableToFailed> 
    </MSTest> 
    </RunSettings>
    ```

## MSTestV1 features that aren't supported in MSTestV2

* Tests can't be included into an "Ordered Test".
* Changes to the `.testsettings` file:
  * Can no longer be used to configure the adapter.
  * No longer support the `<LegacySettings>` section, meaning you can't use it to set attributes. For example, `DeploymentItem`. Use the new [*.runsettings* file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md) for test run configuration.
* The adapter doesn't support test lists specified as a *.vsmdi* file.
* The "Coded UI Test Project" and the "Web Performance and Load Test Project" types aren't supported. Read more on [Coded UI Test deprecation](https://devblogs.microsoft.com/devops/changes-to-coded-ui-test-in-visual-studio-2019/) and [Web Load Test deprecation](https://devblogs.microsoft.com/devops/cloud-based-load-testing-service-eol/).
* Association with a testcase item in TFS isn't supported.

## Related content

- [Configure test runs with `.runsettings`](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md)
- [Unit test your code](../test/unit-test-your-code.md)
- [Debug unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md)
