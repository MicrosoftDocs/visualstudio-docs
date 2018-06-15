---
title: Roslyn analyzers in Visual Studio
ms.date: 03/26/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: overview
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "dotnet"
---
# Overview of .NET Compiler Platform analyzers

Visual Studio 2017 includes a built-in set of .NET Compiler Platform analyzers that analyze your C# or Visual Basic code as you type. You can install additional analyzers as a Visual Studio extension, or on a per-project basis as a NuGet package. Analyzers look at code style, code quality and maintainability, code design, and other issues.

If rule violations are found by an analyzer, they are reported both in the code editor as a *squiggly* under the offending code, and in the **Error List**.

Many analyzer rules, or *diagnostics*, have one or more associated *code fixes* that you can apply to correct the problem. The analyzer diagnostics that are built into Visual Studio each have an associated code fix. Code fixes are shown in the light bulb icon menu, along with other types of *Quick Actions*. For information about these code fixes, see [Common Quick Actions](../ide/common-quick-actions.md).

![Analyzer violation and Quick Action code fix](../code-quality/media/built-in-analyzer-code-fix.png)

## Roslyn analyzers vs. static code analysis

.NET Compiler Platform ("Roslyn") analyzers will eventually replace [static code analysis](../code-quality/code-analysis-for-managed-code-overview.md) for managed code. Many of the static code analysis rules have already been rewritten as Roslyn analyzer diagnostics.

Like static code analysis rule violations, Roslyn analyzer violations appear in the **Error List**. In addition, Roslyn analyzer violations also show up in the code editor as *squigglies* under the offending code. The color of the squiggly depends on the [severity setting](../code-quality/use-roslyn-analyzers.md#rule-severity) of the rule. The following screenshot shows three violations&mdash;one red, one green, and one gray:

![Squigglies in the code editor](media/diagnostics-severity-colors.png)

Roslyn analyzers analyze code at build time, like static code analysis if it's enabled, but also live as you type! Roslyn analyzers can also provide design-time analysis of code files that aren't open in the editor if you enable [full solution analysis](../code-quality/how-to-enable-and-disable-full-solution-analysis-for-managed-code.md#to-toggle-full-solution-analysis).

> [!NOTE]
> Build-time errors and warnings from Roslyn analyzers are shown only if the analyzers are installed as a NuGet package.

Not only do Roslyn analyzers report the same types of problems that static code analysis does, but they make it easy for you to fix one, or all, occurrences of the violation in your file or project. These actions are called *code fixes*. Code fixes are IDE-specific; in Visual Studio, they are implemented as [Quick Actions](../ide/quick-actions.md). Not all analyzer diagnostics have an associated code fix.

> [!NOTE]
> The menu option **Analyze** > **Run Code Analysis** applies only to static code analysis. Additionally, on a project's **Code Analysis** property page, the **Enable Code Analysis on Build** and **Suppress results from generated code** checkboxes apply only to static code analysis. They have no effect on Roslyn analyzers.

To differentiate between violations from Roslyn analyzers and static code analysis in the **Error List**, look at the **Tool** column. If the Tool value matches one of the analyzer assemblies in **Solution Explorer**, for example **Microsoft.CodeQuality.Analyzers**, the violation comes from a Roslyn analyzer. Otherwise, the violation originates from static code analysis.

![Tool column in Error List](media/code-analysis-tool-in-error-list.png)

## NuGet package vs. extension

.NET Compiler Platform analyzers can be installed per-project via a NuGet package, or Visual Studio-wide as a Visual Studio extension. There are some key behavior differences between these two methods of [installing analyzers](../code-quality/install-roslyn-analyzers.md).

### Scope

If you install analyzers as a Visual Studio extension, they apply at the solution level, to all instances of Visual Studio. If you install the analyzers as a NuGet package, which is the preferred method, they apply only to the project where the NuGet package was installed. In team environments, analyzers installed as NuGet packages are in scope for *all developers* that work on that project.

### Build errors

To have rules enforced at build time, including through the command line or as part of a continuous integration (CI) build, install the analyzers as a NuGet package. Analyzer warnings and errors don't show up in the build report if you install the analyzers as an extension.

The following screenshot shows the command-line build output from building a project that contains an analyzer rule violation:

![MSBuild output with rule violation](media/command-line-build-analyzers.png)

### Rule severity

You cannot set the severity of rules from analyzers that were installed as a Visual Studio extension. To configure [rule severity](../code-quality/use-roslyn-analyzers.md#rule-severity), install the analyzers as a NuGet package.

## Next steps

- [Install Roslyn analyzers in Visual Studio](../code-quality/install-roslyn-analyzers.md)
- [Use Roslyn analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## See also

- [Quick Actions in Visual Studio](../ide/quick-actions.md)
- [Write your own Roslyn analyzer](../extensibility/getting-started-with-roslyn-analyzers.md)
- [.NET Compiler Platform SDK](/dotnet/csharp/roslyn-sdk/)