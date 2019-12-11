---
title: FxCop code analysis and FxCop analyzers
ms.date: 09/06/2018
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis FAQ"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Frequently asked questions about FxCop and FxCop analyzers

It can be a little confusing to understand the differences between legacy FxCop and FxCop analyzers. This article aims to address some of questions you might have.

## What's the difference between legacy FxCop and FxCop analyzers?

Legacy FxCop runs post-build analysis on a compiled assembly. It runs as a separate executable called **FxCopCmd.exe**. FxCopCmd.exe loads the compiled assembly, runs code analysis, and then reports the results (or *diagnostics*).

FxCop analyzers are based on the .NET Compiler Platform ("Roslyn"). You [install them as a NuGet package](install-fxcop-analyzers.md#nuget-package) that's referenced by the project or solution. FxCop analyzers run source-code based analysis during compiler execution. FxCop analyzers are hosted within the compiler process, either **csc.exe** or **vbc.exe**, and run analysis when the project is built. Analyzer results are reported along with compiler results.

> [!NOTE]
> You can also [install FxCop analyzers as a Visual Studio extension](install-fxcop-analyzers.md#vsix). In this case, the analyzers execute as you type in the code editor, but they don't execute at build time. If you want to run FxCop analyzers as part of continuous integration (CI), install them as a NuGet package instead.

## Does the Run Code Analysis command run FxCop analyzers?

No. When you select **Analyze** > **Run Code Analysis**, it executes legacy analysis. **Run Code Analysis** has no effect on Roslyn-based analyzers, including the Roslyn-based FxCop analyzers.

## Does the RunCodeAnalysis msbuild project property run analyzers?

No. The **RunCodeAnalysis** property in a project file (for example, *.csproj*) is only used to execute legacy FxCop. It runs a post-build msbuild task that invokes **FxCopCmd.exe**. This is equivalent to selecting **Analyze** > **Run Code Analysis** in Visual Studio.

## So how do I run FxCop analyzers then?

To run FxCop analyzers, first [install the NuGet package](install-fxcop-analyzers.md) for them. Then build your project or solution from Visual Studio or using msbuild. The warnings and errors that the FxCop analyzers generate will appear in the **Error List** or the command window.

## I get warning CA0507 even after I've installed the FxCop analyzers NuGet package

If you've installed FxCop analyzers but continue to get warning CA0507 **""Run Code Analysis" has been deprecated in favor of FxCop analyzers, which run during build"**, you may need to set the **RunCodeAnalysis** msbuild property in your [project file](../ide/solutions-and-projects-in-visual-studio.md#project-file) to **false**. Otherwise, legacy analysis will execute after each build.

```xml
<RunCodeAnalysis>false</RunCodeAnalysis>
```

## Which rules have been ported to FxCop analyzers?

For information about which legacy analysis rules have been ported to [FxCop analyzers](install-fxcop-analyzers.md), see [Fxcop rule port status](fxcop-rule-port-status.md).

## Code analysis warnings are treated as errors

If your project uses the build option to treat warnings as errors, FxCop analyzer warnings may appear as errors. To prevent code analysis warnings from being treated as errors, follow the steps at [Code analysis FAQ](../code-quality/analyzers-faq.md#treat-warnings-as-errors).

## See also

- [Overview of .NET Compiler Platform analyzers](roslyn-analyzers-overview.md)
- [Get started with analyzers](fxcop-analyzers.yml)
- [Install FxCop analyzers](install-fxcop-analyzers.md)
