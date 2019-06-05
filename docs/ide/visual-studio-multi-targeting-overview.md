---
title: Target the .NET Framework
ms.date: 02/06/2018
ms.topic: conceptual
helpviewer_keywords:
  - "targeting .NET Framework [Visual Studio]"
  - "multi-targeting [Visual Studio]"
  - "multitargeting [Visual Studio]"
  - "framework targeting [Visual Studio]"
  - ".NET framework targeting [Visual Studio]"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# Visual Studio multi-targeting overview

In Visual Studio, you can specify the version or profile of the .NET Framework that you want your project to target. For an application to run on another computer, the Framework version that the application targets must be compatible with the Framework version that is installed on the computer.

You can also create a solution that contains projects that target different versions of the framework. Framework targeting helps guarantee that the application uses only functionality that is available in the specified version of the framework.

> [!TIP]
> You can also target applications for different platforms. For more information, see [Multitargeting](../msbuild/msbuild-multitargeting-overview.md).

## Framework targeting features

Framework targeting includes the following features:

- When you open a project that targets an earlier version of the .NET Framework, Visual Studio can automatically upgrade it or leave the target as-is.

- When you create a project, you can specify the version of the .NET Framework that you want to target.

- You can change the version of the .NET Framework that an existing project targets.

- You can target a different version of the .NET Framework in each of several projects in the same solution.

- When you change the version of the .NET Framework that a project targets, [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] makes any required changes to references and configuration files.

When you work on a project that targets an earlier version of the .NET Framework, Visual Studio dynamically changes the development environment, as follows:

- It filters items in the **Add New Item** dialog box, the **Add New Reference** dialog box, and the **Add Service Reference** dialog box to omit choices that are not available in the targeted version.

- It filters custom controls in the **Toolbox** to remove those that are not available in the targeted version and to show the only the most up-to-date controls when multiple controls are available.

- It filters **IntelliSense** to omit language features that are not available in the targeted version.

- It filters properties in the **Properties** window to omit those that are not available in the targeted version.

- It filters menu options to omit options that are not available in the targeted version.

- For builds, it uses the version of the compiler and the compiler options that are appropriate for the targeted version.

> [!NOTE]
> Framework targeting does not guarantee that your application will run correctly. You must test your application to make sure it runs against the targeted version. You cannot target framework versions that are earlier than the .NET Framework 2.0.

## Select a target framework version

When you create a project, select the target .NET Framework version after you select a project template. The list of available frameworks includes the installed framework versions that are applicable to the selected template type. For template types that don't require .NET Framework, for example .NET Core templates, the **Framework** drop-down list is hidden.

::: moniker range="vs-2017"

![Framework drop-down in VS 2017](media/vside-newproject-framework.png)

::: moniker-end

::: moniker range=">=vs-2019"

![Framework dropdown in VS 2019](media/vs-2019/configure-new-project-framework.png)

::: moniker-end

In an existing project, you can change the target .NET Framework version in the project properties dialog box. For more information, see [How to: Target a version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).

## Resolve system and user assembly references

To target a .NET Framework version, you must first install the appropriate assembly references. You can download developer packs for different versions of the .NET Framework on the [.NET downloads](https://www.microsoft.com/net/download/windows) page.

The **Add Reference** dialog box disables system assemblies that do not pertain to the target .NET Framework version so that they cannot be added to a project inadvertently. (System assemblies are *.dll* files that are included in a .NET Framework version.) References that belong to a framework version that is later than the targeted version will not resolve, and controls that depend on such a reference cannot be added. If you want to enable such a reference, reset the .NET Framework target of the project to one that includes the reference.  For more information, see [How to: Target a version of the .NET Framework](../ide/how-to-target-a-version-of-the-dotnet-framework.md).

For more information about assembly references, see [Resolve assemblies at design time](../msbuild/resolving-assemblies-at-design-time.md).

## Enable LINQ

When you target the .NET Framework 3.5 or later, a reference to **System.Core** and a project-level import for <xref:System.Linq> (in Visual Basic only) are added automatically. If you want to use LINQ features, you must also turn `Option Infer` on (in Visual Basic only). The reference and import are removed automatically if you change the target to an earlier .NET Framework version. For more information, see [Work with LINQ](/dotnet/csharp/tutorials/working-with-linq).

## See also

- [Multitargeting (MSBuild)](../msbuild/msbuild-multitargeting-overview.md)
- [How to: Modify the target framework and platform toolset (C++)](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset)