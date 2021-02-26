---
title: Update to MSTestv2
description: Learn how to update from MSTestv1 to MSTestv2 
ms.custom: SEO-VS-2020
ms.date: 02/26/2021
ms.topic: conceptual
f1_keywords:
- vs.UnitTest.Migrate
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.workload:
- multiple
---

# Upgrade from MSTestv1 to MSTestV2

## How to upgrade.

For some, upgrading your test projects may be as simple as retargeting the MSTest version referenced in you csproj from the MSTestV1 to MSTestV2. Not all features in MSTestV1 were brought forward into MSTestV2 so some changes may be required. See [MSTestV1 features that are not supported in MSTestV2](#MSTestV1-features-that-are-not-supported-in-MSTestV2)

Old style csproj example:

Before targeting MSTestv1
```xml
    <Reference Include="Microsoft.VisualStudio.QualityTools.UnitTestFramework, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <Private>False</Private>
    </Reference>
```

After targeting MSTestv2
```xml
    <Reference Include="Microsoft.VisualStudio.TestPlatform.TestFramework, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL">
      <HintPath>..\packages\MSTest.TestFramework.2.1.2\lib\net45\Microsoft.VisualStudio.TestPlatform.TestFramework.dll</HintPath>
    </Reference>
```

> [!NOTE]
> Test projects that are Coded UI tests or Web Load Tests are not compatible with MSTestv2. These project types have been deprecated. Read more on [Coded UI Test deprecation](https://devblogs.microsoft.com/devops/changes-to-coded-ui-test-in-visual-studio-2019/) and [Web Load Test deprecation](https://devblogs.microsoft.com/devops/cloud-based-load-testing-service-eol/).

## Why Upgrade to MSTestV2?

In 2016 we released the next step in evolving the MSTest framework with MSTestv2. You can read more about this change in the announcement [blog post](https://devblogs.microsoft.com/devops/taking-the-mstest-framework-forward-with-mstest-v2/).

1. MSTestV2 sets the direction for how we intend to evolve the MSTest framework. [Read more.](https://blogs.msdn.microsoft.com/devops/2016/06/17/taking-the-mstest-framework-forward-with-mstest-v2/).
2. MSTest V2 is [open source](https://github.com/microsoft/testfx).
3. Uniform app-platform support – this is a converged implementation that offers uniform app-platform support across .NET Framework, .NET Core and ASP.NET Core, and UWP [more...].
4. The implementation is fully cross platform (Windows, Linux, Mac) [more...].
5. MSTest V2 support targeting .NET Framework 4.5.0+, .NET Core 1.0+ (Universal Windows Apps 10+, DNX Core 5+), and ASP.NET Core 1.0+
6. Provides a uniform, single end-user extensibility mechanism. [more...].
7. Delivered as a NuGet package [more...].
8. Provides a uniform DataRow support, for all MSTest based test projects [more...].
9. Provides the ability to place the TestCategory attribute at the level of a class or assembly [more...].
10. Test methods from base classes defined in another assembly are now discovered and run from the derived Test class. This brings in a consistent behavior with derived test class types. If this behavior is not required for compat reasons it can be changed back using the following runsettings:
<RunSettings>    
 <MSTest> 
   <EnableBaseClassTestMethodsFromOtherAssemblies>false</EnableBaseClassTestMethodsFromOtherAssemblies> 
 </MSTest> 
</RunSettings>
11. The TestCleanup method on a TestClass is invoked even if its corresponding TestInitialize method fails. See #250 for details.
12. The time taken by AssemblyInitialize and ClassInitialize are not considered as part of a tests duration thereby limiting their impact on a test timing out.
13. Test which are not runnable can be configured to be marked as failed via MapNotRunnableToFailed tag which is part of the adapter node in the runsettings.

```xml
<RunSettings>    
 <MSTest> 
   <MapNotRunnableToFailed>true</MapNotRunnableToFailed> 
 </MSTest> 
</RunSettings>
```

## MSTestV1 features that are not supported in MSTestV2

1.	Tests cannot be included into an "Ordered Test".
2.	The adapter does not support being configured via a .testsettings file. Use the new [runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file) for test run configuration.
3.	The adapter does not support test lists specified as a .vsmdi file.
4.	The "Coded UI Test Project", and the "Web Performance and Load Test Project" types are not supported per the deprecation announcements.
5.	Association with a testcase item in TFS is not supported.

## See also

- [Unit test your code](../test/unit-test-your-code.md)
- [Debug unit tests with Test Explorer](../test/debug-unit-tests-with-test-explorer.md)