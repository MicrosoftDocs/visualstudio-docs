---
title: Enable or disable code analysis
ms.date: 10/25/2018
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# How to: Enable and disable automatic code analysis for managed code

You can configure code analysis to run after each build of a managed code project. For non-.NET Core/.NET Standard projects, you can also have different settings for each build configuration, for example, debug and release.

To enable or disable automatic code analysis:

1. In **Solution Explorer**, right-click the project, and then choose **Properties**.

2. In the properties dialog box for the project, choose the **Code Analysis** tab.

   > [!TIP]
   > Legacy analysis is not available for newer project types such as .NET Core and .NET Standard apps. These projects use [.NET Compiler Platform-based code analyzers](roslyn-analyzers-overview.md) to analyze code, both live and at build time. To suppress warnings from code analyzers, see the note at the end of this article.

3. Specify the build type in **Configuration** and the target platform in **Platform**. (Non-.NET Core/.NET Standard projects only.)

::: moniker range="vs-2017"

4. To enable or disable automatic code analysis, select or clear the **Enable Code Analysis on Build** check box.

::: moniker-end

::: moniker range=">=vs-2019"

4. To enable or disable automatic code analysis, select or clear the **Run on build** check box.

::: moniker-end

> [!NOTE]
> Enabling code analysis on build only affects legacy analysis. It doesn't affect [.NET Compiler Platform-based code analyzers](roslyn-analyzers-overview.md), which always execute at build if you installed them as a NuGet package. If you want to clear analyzer errors from the Error List, you can suppress all the current violations by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar. For more information, see [Suppress violations](use-roslyn-analyzers.md#suppress-violations).
