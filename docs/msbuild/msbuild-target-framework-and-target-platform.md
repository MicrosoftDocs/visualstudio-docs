---
title: MSBuild Target Framework and Target Platform | Microsoft Docs
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: df6517c5-edd6-4cc4-97ad-b3cdfc78e799
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# MSBuild target framework and target platform

A project can be built to run on a *target framework*, which is a particular version of the .NET Framework, and a *target platform*, which is a particular software architecture.  For example, you can target an application to run on the .NET Framework 2.0 on a 32-bit platform that is compatible with the 80x86 processor family ("x86"). The combination of target framework and target platform is known as the *target context*.

> [!IMPORTANT]
> This article shows the old way to specify a target framework. SDK-style projects enable different TargetFrameworks like netstandard. For more info, see [Target frameworks](/dotnet/standard/frameworks).

## Target framework and profile

 A target framework is the particular version of the .NET Framework that your project is built to run on. Specification of a target framework is required because it enables compiler features and assembly references that are exclusive to that version of the framework.

 Currently, the following versions of the .NET Framework are available for use:

- The .NET Framework 2.0 (included in Visual Studio 2005)

- The .NET Framework 3.0 (included in Windows Vista)

- The .NET Framework 3.5 (included in Visual Studio 2008)

- The .NET Framework 4.5.2

- The .NET Framework 4.6 (included in Visual Studio 2015)

- The .NET Framework 4.6.1

- The .NET Framework 4.6.2

- The .NET Framework 4.7

- The .NET Framework 4.7.1

- The .NET Framework 4.7.2

- The .NET Framework 4.8

The versions of the .NET Framework differ from one another in the list of assemblies that each makes available to reference. For example, you cannot build Windows Presentation Foundation (WPF) applications unless your project targets the .NET Framework version 3.0 or above.

The target framework is specified in the `TargetFrameworkVersion` property in the project file. You can change the target framework for a project by using the project property pages in the Visual Studio integrated development environment (IDE). For more information, see [How to: Target a version of the .NET Framework](../ide/visual-studio-multi-targeting-overview.md). The available values for `TargetFrameworkVersion` are `v2.0`, `v3.0`, `v3.5`, `v4.5.2`, `v4.6`, `v4.6.1`, `v4.6.2`, `v4.7`, `v4.7.1`, `v4.7.2`, and `v4.8`.

```xml
<TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
```

 A *target profile* is a subset of a target framework. For example, the .NET Framework 4 Client profile does not include references to the MSBuild assemblies.

 > [!NOTE]
 > Target profiles apply only to [portable class libraries](/dotnet/standard/cross-platform/cross-platform-development-with-the-portable-class-library).

 The target profile is specified in the `TargetFrameworkProfile` property in a project file. You can change the target profile by using the target-framework control in the project property pages in the IDE.

```xml
<TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
<TargetFrameworkProfile>Client</TargetFrameworkProfile>
```

## Target platform

 A *platform* is combination of hardware and software that defines a particular runtime environment. For example,

- `x86` designates a 32-bit Windows operating system that is running on an Intel 80x86 processor or its equivalent.

- `x64` designates a 64-bit Windows operating system that is running on an Intel x64 processor or it equivalent.

- `Xbox` designates the Microsoft Xbox 360 platform.

A *target platform* is the particular platform that your project is built to run on. The target platform is specified in the `PlatformTarget` build property in a project file. You can change the target platform by using the project property pages or the **Configuration Manager** in the IDE.

```xml
<PropertyGroup>
   <PlatformTarget>x86</PlatformTarget>
</PropertyGroup>

```

A *target configuration* is a subset of a target platform. For example, the `x86` `Debug` configuration does not include most code optimizations. The target configuration is specified in the `Configuration` build property in a project file. You can change the target configuration by using the project property pages or the **Configuration Manager**.

```xml
<PropertyGroup>
   <PlatformTarget>x86</PlatformTarget>
   <Configuration>Debug</Configuration>
</PropertyGroup>

```

## See also

- [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
