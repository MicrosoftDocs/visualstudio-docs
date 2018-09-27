---
title: "How to: Enable and Disable Automatic Code Analysis for Managed Code"
ms.date: 09/28/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# How to: Enable and disable automatic code analysis for managed code

You can configure code analysis to run after each build of a managed code project. You can set different code analysis properties for each build configuration, for example, debug and release.

## To enable or disable automatic code analysis

1. In **Solution Explorer**, right-click the project, and then choose **Properties**.

1. In the properties dialog box for the project, choose the **Code Analysis** tab.

1. Specify the build type in **Configuration** and the target platform in **Platform**.

1. To enable or disable automatic code analysis, select or clear the **Enable Code Analysis on Build** check box.

> [!NOTE]
> The **Enable Code Analysis on Build** check box only affects static code analysis. It doesn't affect [Roslyn code analyzers](roslyn-analyzers-overview.md), which always execute at build if you installed them as a NuGet package. If you want to clear analyzer errors from the **Error List**, you can suppress all the current violations by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues** on the menu bar. For more information, see [Suppress violations](use-roslyn-analyzers.md#suppress-violations).
