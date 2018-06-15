---
title: Code analysis for managed code in Visual Studio
ms.date: 03/26/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
f1_keywords:
  - "vs.projectpropertypages.codeanalysis"
helpviewer_keywords:
  - "code analysis, managed code"
  - "managed code, code analysis"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Overview of code analysis for managed code

Visual Studio 2017 analyzes managed code in two ways: with legacy *FxCop* static analysis of managed assemblies, and with .NET Compiler Platform *analyzers*. This topic covers FxCop static code analysis. To learn more about analyzing code by using .NET Compiler Platform analyzers, see [Overview of Roslyn analyzers](../code-quality/roslyn-analyzers-overview.md).

Code analysis for managed code analyzes managed assemblies and reports information about the assemblies, such as violations of the programming and design rules set forth in the Microsoft .NET Framework Design Guidelines.

The analysis tool represents the checks it performs during an analysis as warning messages. Warning messages identify any relevant programming and design issues and, when it is possible, supply information about how to fix the problem.

## IDE (integrated development environment) integration

You can run code analysis on your project manually or automatically.

To run code analysis each time that you build a project, select **Enable Code Analysis on Build** on the project's Property Page. For more information, see [How to: Enable and Disable Automatic Code Analysis](../code-quality/how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

To run code analysis manually on a project, from the menu bar choose **Analyze** > **Run Code Analysis** > **Run Code Analysis on \<project>**.

## Rule sets

Code analysis rules for managed code are grouped into [rule sets](../code-quality/using-rule-sets-to-group-code-analysis-rules.md). You can use one of the Microsoft standard rule sets, or you can [create a custom rule set](../code-quality/how-to-create-a-custom-rule-set.md) to fulfill a specific need.

## Suppress warnings

Frequently, it is useful to indicate that a warning is non-applicable. This informs the developer, and other people who might review the code later, that a warning was investigated and then either suppressed or ignored.

In-source suppression of warnings is implemented through custom attributes. To suppress a warning, add the attribute `SuppressMessage` to the source code as shown in the following example:

```csharp
[System.Diagnosis.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1039:ListsAreStrongTyped")]
Public class MyClass
{
   // code
}
```

For more information, see [Suppress warnings](../code-quality/in-source-suppression-overview.md).

> [!NOTE]
> If you migrate a project to Visual Studio 2017, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings and want to become productive right away, you can *baseline* the analysis state of your project. From the **Analyze** menu, select **Run Code Analysis and Suppress Active Issues**.

## Run code analysis as part of check-in policy

As an organization, you might want to require that all check-ins satisfy certain policies. In particular, you want to make sure that you follow these policies:

- There are no build errors in code being checked in.

- Code analysis is run as part of the most recent build.

You can accomplish this by specifying check-in policies. For more information, see [Enhancing Code Quality with Team Project Check-in Policies](../code-quality/enhancing-code-quality-with-team-project-check-in-policies.md).

## Team build integration

You can use the integrated features of the build system to run the analysis tool as part of the build process. For more information, see [Build and release (VSTS)](/vsts/build-release/index).

## See also

- [Overview of Roslyn analyzers](../code-quality/roslyn-analyzers-overview.md)
- [Using Rule Sets to Group Code Analysis Rules](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
- [How to: Enable and Disable Automatic Code Analysis](../code-quality/how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md)
