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

You can configure (static) code analysis to run after each build of a managed code project. You can set different code analysis properties for each build configuration, for example, debug and release.

This article applies only to legacy analysis and not live code analysis using [Roslyn code analyzers](roslyn-analyzers-overview.md).

## To enable or disable automatic code analysis

1. In **Solution Explorer**, right-click the project, and then choose **Properties**.

1. In the properties dialog box for the project, choose the **Code Analysis** tab.

   > [!TIP]
   > Newer project types such as .NET Core and .NET Standard applications don't have a **Code Analysis** tab. Static code analysis is not available for these project types, but you can still get live code analysis using [Roslyn code analyzers](roslyn-analyzers-overview.md). To suppress warnings from Roslyn code analyzers, see the note at the end of this article.

1. Specify the build type in **Configuration** and the target platform in **Platform**.

1. To enable or disable automatic code analysis, select or clear the **Enable Code Analysis on Build** check box.

> [!NOTE]
> The **Enable Code Analysis on Build** check box only affects legacy analysis. It doesn't affect [Roslyn code analyzers](roslyn-analyzers-overview.md), which always execute at build if you installed them as a NuGet package. If you want to clear analyzer errors from the **Error List**, you can suppress all the current violations by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar. For more information, see [Suppress violations](use-roslyn-analyzers.md#suppress-violations).
