---
title: Code analysis for managed code
ms.date: 06/12/2019
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, managed code"
  - "managed code, code analysis"
author: mikadumont
ms.author: midumont
manager: jillfra
ms.workload:
  - "dotnet"
---
# Overview of code analysis for managed code in Visual Studio

Visual Studio can perform code analysis of managed code in two ways: with [legacy analysis](../code-quality/walkthrough-analyzing-managed-code-for-code-defects.md), also known as FxCop static analysis of managed assemblies, and with the more modern .NET Compiler Platform-based [code analyzers](../code-quality/roslyn-analyzers-overview.md). This topic covers legacy analysis. To learn more about .NET Compiler Platform-based code analysis, see [Overview of .NET Compiler Platform-based analyzers](../code-quality/roslyn-analyzers-overview.md).

Code analysis for managed code analyzes managed assemblies and reports information about the assemblies, such as violations of the programming and design rules set forth in the [.NET Design Guidelines](/dotnet/standard/design-guidelines/).

The analysis tool represents the checks it performs during an analysis as warning messages. Warning messages identify any relevant programming and design issues and, when it is possible, supply information about how to fix the problem.

> [!NOTE]
> Legacy analysis (static code analysis) is not supported for .NET Core and .NET Standard projects in Visual Studio. If you run code analysis on a .NET Core or .NET Standard project as part of msbuild, you'll see an error similar to **error : CA0055 : Could not identify platform for \<your.dll>**. To analyze code in .NET Core or .NET Standard projects, use [code analyzers](../code-quality/roslyn-analyzers-overview.md) instead.

## IDE (integrated development environment) integration

You can run code analysis on your project manually or automatically.

To run code analysis each time that you build a project, select the option on the project's **Code Analysis** property page. For more information, see [How to: Enable and Disable Automatic Code Analysis](../code-quality/how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md).

To run code analysis manually on a project, from the menu bar choose **Analyze** > **Run Code Analysis** > **Run Code Analysis on \<project>**.

## Rule sets

Code analysis rules for managed code are grouped into [rule sets](../code-quality/using-rule-sets-to-group-code-analysis-rules.md). You can use one of the Microsoft standard rule sets, or you can [create a custom rule set](../code-quality/how-to-create-a-custom-rule-set.md) to fulfill a specific need.

## Suppress warnings

Frequently, it is useful to indicate that a warning is non-applicable. This informs the developer, and other people who might review the code later, that a warning was investigated and then either suppressed or ignored.

In-source suppression of warnings is implemented through custom attributes. To suppress a warning, add the attribute `SuppressMessage` to the source code as shown in the following example:

```csharp
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1039:ListsAreStrongTyped")]
Public class MyClass
{
   // code
}
```

For more information, see [Suppress warnings](../code-quality/in-source-suppression-overview.md).

::: moniker range="vs-2017"

> [!NOTE]
> If you migrate a project to Visual Studio 2017, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by choosing **Analyze** > **Run Code Analysis and Suppress Active Issues**.
>
> ![Run code analysis and suppress issues in Visual Studio](media/suppress-active-issues.png)

::: moniker-end

::: moniker range=">=vs-2019"

> [!NOTE]
> If you migrate a project to Visual Studio 2019, you might suddenly be faced with a large number of code analysis warnings. If you aren't ready to fix the warnings, you can suppress all of them by choosing **Analyze** > **Build and Suppress Active Issues**.

::: moniker-end

## Run code analysis as part of check-in policy

As an organization, you might want to require that all check-ins satisfy certain policies. In particular, you want to make sure that you follow these policies:

- There are no build errors in code being checked in.

- Code analysis is run as part of the most recent build.

You can accomplish this by specifying check-in policies. For more information, see [Enhancing Code Quality with Project Check-in Policies](../code-quality/how-to-create-or-update-standard-code-analysis-check-in-policies.md).

## Team build integration

You can use the integrated features of the build system to run the analysis tool as part of the build process. For more information, see [Azure Pipelines](/azure/devops/pipelines/index?view=vsts).

## See also

- [Overview of .NET Compiler Platform-based analyzers](../code-quality/roslyn-analyzers-overview.md)
- [Using Rule Sets to Group Code Analysis Rules](../code-quality/using-rule-sets-to-group-code-analysis-rules.md)
- [How to: Enable and Disable Automatic Code Analysis](../code-quality/how-to-enable-and-disable-automatic-code-analysis-for-managed-code.md)
