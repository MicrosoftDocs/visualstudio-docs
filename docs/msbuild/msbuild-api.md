---
title: Build and inspect projects with the MSBuild API
description: Explore the public API surface provided in MSBuild that you can use to enable your program to perform builds and inspect projects.
ms.date: 7/1/2025
ms.topic: overview
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Use the MSBuild API

MSBuild provides a public API surface so that your program can perform builds and inspect projects. Recent versions of the MSBuild APIs can be found in the following NuGet packages:

| Package name | Description |
| ------------ | ----------- |
| [Microsoft.Build](https://www.nuget.org/packages/Microsoft.Build) | Contains the Microsoft.Build assembly which is used to create, edit, and evaluate MSBuild projects.|
| [Microsoft.Build.Framework](https://www.nuget.org/packages/Microsoft.Build.Framework)| Contains the common MSBuild framework assembly used by other MSBuild assemblies. |
| [Microsoft.Build.Runtime](https://www.nuget.org/packages/Microsoft.Build.Runtime) | Delivers a complete executable copy of MSBuild. Reference this package only if your application needs to load projects or execute in-process builds without requiring installation of MSBuild. Successfully evaluating projects using this package requires aggregating additional components (like the compilers) into an application directory. |
| [Microsoft.Build.Tasks.Core](https://www.nuget.org/packages/Microsoft.Build.Tasks.Core) | Contains the Microsoft.Build.Tasks assembly which implements the commonly used tasks of MSBuild. |
| [Microsoft.Build.Utilities.Core](https://www.nuget.org/packages/Microsoft.Build.Utilities.Core) | Contains the Microsoft.Build.Utilities assembly which is used to implement custom MSBuild tasks. |

In addition, NuGet also hosts a legacy assembly, [Microsoft.Build.Engine](https://www.nuget.org/packages/Microsoft.Build.Engine), which is deprecated.

There are several different versions of the MSBuild API, and for versions 15 and 16, there are two distinct forms of the assemblies in the NuGet packages, one compiled with the .NET Framework, and another compiled with .NET Core, which is a subset of the .NET Framework API surface.  The .NET Core version of MSBuild is used when you invoke the `dotnet` command, and when using MSBuild on Mac and Linux systems.

Documentation for the MSBuild API can be found by using the [.NET API Browser](/dotnet/api), or by browsing the namespaces in the following list.

| Namespace | Applies To | Description |
|-----------| -----------| ----------- |
| [Microsoft.Build.Construction](/dotnet/api/Microsoft.Build.Construction?view=msbuild-16&preserve-view=true) | All |  Contains types that the MSBuild object model uses to construct project roots with unevaluated values. Each project root corresponds to a project or targets file. |
| [Microsoft.Build.Definition](/dotnet/api/Microsoft.Build.Definition?view=msbuild-16&preserve-view=true) | All | Contains the `ProjectOptions` class, which supports project construction. |
| [Microsoft.Build.Evaluation](/dotnet/api/Microsoft.Build.Evaluation?view=msbuild-16&preserve-view=true) | All | Contains types that the MSBuild object model uses to evaluate projects. Each project is associated with one or more project roots. |
| [Microsoft.Build.Evaluation.Context](/dotnet/api/Microsoft.Build.Evaluation.Context?view=msbuild-16&preserve-view=true) | All | Contains the `EvaluationContext` class, used to store evaluation state across calls. |
| [Microsoft.Build.Exceptions](/dotnet/api/Microsoft.Build.Exceptions?view=msbuild-16&preserve-view=true) | All | Contains exception types that may be thrown during the build process. |
| [Microsoft.Build.Execution](/dotnet/api/Microsoft.Build.Execution?view=msbuild-16&preserve-view=true) | All | Contains types that the MSBuild object model uses to build projects. |
| [Microsoft.Build.Framework](/dotnet/api/Microsoft.Build.Framework?view=msbuild-16&preserve-view=true) | All | Contains the types that define how tasks and loggers interact with the MSBuild engine.|
| [Microsoft.Build.Framework.Profiler](/dotnet/api/Microsoft.Build.Framework.Profiler?view=msbuild-16&preserve-view=true) | All | Contains the types that support performance profiling. |
| [Microsoft.Build.Framework.XamlTypes](/dotnet/api/Microsoft.Build.Framework.XamlTypes?view=msbuild-16&preserve-view=true) | .NET Framework only | Contains classes used to represent XAML types parsed from files, rules, and other sources. |
| [Microsoft.Build.Globbing](/dotnet/api/Microsoft.Build.Globbing?view=msbuild-16&preserve-view=true) | All | Contains classes that support wildcard processing. |
| [Microsoft.Build.Globbing.Extensions](/dotnet/api/Microsoft.Build.Globbing.Extensions?view=msbuild-16&preserve-view=true) | All | Contains types that support extensions to wildcard processing. |
| [Microsoft.Build.Graph](/dotnet/api/Microsoft.Build.Graph?view=msbuild-16&preserve-view=true) | All | Contains types that support the `-graph` MSBuild switch. |
| [Microsoft.Build.Logging](/dotnet/api/Microsoft.Build.Logging?view=msbuild-16&preserve-view=true) | All | Contains types used for logging the progress of a build. |
| [Microsoft.Build.ObjectModelRemoting](/dotnet/api/Microsoft.Build.ObjectModelRemoting?view=msbuild-16&preserve-view=true) | All | Contains types that support remoting in MSBuild. |
| [Microsoft.Build.Tasks](/dotnet/api/Microsoft.Build.Tasks?view=msbuild-16&preserve-view=true) | All | Contains the implementation of all tasks shipping with MSBuild. |
| [Microsoft.Build.Tasks.Deployment.Bootstrapper](/dotnet/api/Microsoft.Build.Tasks.Deployment.Bootstrapper?view=msbuild-16&preserve-view=true) | .NET Framework only | Contains classes used internally by MSBuild. |
| [Microsoft.Build.Tasks.Deployment.ManifestUtilities](/dotnet/api/Microsoft.Build.Tasks.Deployment.ManifestUtilities?view=msbuild-16&preserve-view=true) | .NET Framework only | Contains classes that MSBuild uses.|
| [Microsoft.Build.Tasks.Hosting](/dotnet/api/Microsoft.Build.Tasks.Hosting?view=msbuild-16&preserve-view=true) | All | Contains classes used internally by MSBuild. |
| [Microsoft.Build.Tasks.Xaml](/dotnet/api/Microsoft.Build.Tasks.Xaml?view=msbuild-16&preserve-view=true) | .NET Framework only | Contains classes related to XAML build tasks. |
| [Microsoft.Build.Utilities](/dotnet/api/Microsoft.Build.Utilities?view=msbuild-16&preserve-view=true) | All | Contains helper classes that you can use to create your own MSBuild loggers and tasks.|

In the previous table, All in the Applies To column means the types in the namespace are available in both the .NET Framework and the .NET Core versions of the MSBuild API.

## MSBuild Locator

MSBuild Locator is an API that you can use to find MSBuild on a machine. It can be helpful in tools development, when you want to find installed versions of MSBuild.

The NuGetPackage is at [Microsoft.Build.Locator](https://www.nuget.org/packages/Microsoft.Build.Locator/) and the reference documentation is at [Microsoft](/dotnet/api/microsoft.build.locator).

For more information about MSBuildLocator, see [Find and use MSBuild versions](./find-and-use-msbuild-versions.md).

## Related content

- [MSBuild](msbuild.md)
