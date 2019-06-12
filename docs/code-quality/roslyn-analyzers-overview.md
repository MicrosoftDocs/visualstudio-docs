---
title: Code analysis using Roslyn analyzers
ms.date: 03/26/2018
ms.topic: overview
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "dotnet"
---
# Overview of .NET Compiler Platform analyzers

.NET Compiler Platform ("Roslyn") analyzers analyze your code for style, quality and maintainability, design, and other issues. Visual Studio includes a built-in set of analyzers that analyze your C# or Visual Basic code as you type. You configure preferences for these built-in analyzers on the [text editor Options](../ide/code-styles-and-code-cleanup.md) page or in an [.editorconfig file](../ide/editorconfig-code-style-settings-reference.md). You can install additional analyzers as a Visual Studio extension or a NuGet package.

If rule violations are found by an analyzer, they are reported in the code editor (as a *squiggly* under the offending code) and in the **Error List** window.

Many analyzer rules, or *diagnostics*, have one or more associated *code fixes* that you can apply to correct the problem. The analyzer diagnostics that are built into Visual Studio each have an associated code fix. Code fixes are shown in the light bulb icon menu along with other types of [Quick Actions](../ide/quick-actions.md). For information about these code fixes, see [Common Quick Actions](../ide/common-quick-actions.md).

![Analyzer violation and Quick Action code fix](../code-quality/media/built-in-analyzer-code-fix.png)

## Roslyn analyzers vs. static code analysis

.NET Compiler Platform ("Roslyn") analyzers will eventually replace [static code analysis](../code-quality/code-analysis-for-managed-code-overview.md) for managed code. Many of the static code analysis rules have already been rewritten as Roslyn analyzer diagnostics.

Like static code analysis rule violations, Roslyn analyzer violations appear in **Error List**. In addition, Roslyn analyzer violations also show up in the code editor as *squigglies* under the offending code. The color of the squiggly depends on the [severity setting](../code-quality/use-roslyn-analyzers.md#rule-severity) of the rule. The following screenshot shows three violations&mdash;one red, one green, and one gray:

![Squigglies in the code editor](media/diagnostics-severity-colors.png)

Roslyn analyzers analyze code at build time, like static code analysis if it's enabled, but also live as you type. If you enable [full solution analysis](../code-quality/how-to-enable-and-disable-full-solution-analysis-for-managed-code.md#to-toggle-full-solution-analysis), Roslyn analyzers also provide design-time analysis of code files that aren't open in the editor.

> [!TIP]
> Build-time errors and warnings from Roslyn analyzers are shown only if the analyzers are installed as a NuGet package.

Not only do Roslyn analyzers report the same types of problems that static code analysis does, but they make it easy for you to fix one, or all, occurrences of the violation in your file or project. These actions are called *code fixes*. Code fixes are IDE-specific; in Visual Studio, they are implemented as [Quick Actions](../ide/quick-actions.md). Not all analyzer diagnostics have an associated code fix.

> [!NOTE]
> The following UI options apply only to static code analysis:
>
> - The **Analyze** > **Run Code Analysis** menu option.
> - The **Enable Code Analysis on Build** and **Suppress results from generated code** checkboxes on the **Code Analysis** tab of a project's property pages (these options have no effect on Roslyn analyzers).

To differentiate between violations from Roslyn analyzers and static code analysis in the **Error List**, look at the **Tool** column. If the Tool value matches one of the analyzer assemblies in **Solution Explorer**, for example **Microsoft.CodeQuality.Analyzers**, the violation comes from a Roslyn analyzer. Otherwise, the violation originates from static code analysis.

![Tool column in Error List](media/code-analysis-tool-in-error-list.png)

> [!TIP]
> The **RunCodeAnalysis** msbuild property in a project file applies only to static code analysis. If you install analyzers, set **RunCodeAnalysis** to **false** in your project file to prevent static code analysis from running after build.
>
> ```xml
> <RunCodeAnalysis>false</RunCodeAnalysis>
> ```

## NuGet package versus VSIX extension

.NET Compiler Platform analyzers can be installed per-project via a NuGet package, or Visual Studio-wide as a Visual Studio extension. There are some key behavior differences between these two methods of [installing analyzers](../code-quality/install-roslyn-analyzers.md).

### Scope

If you install analyzers as a Visual Studio extension, they apply at the solution level, to all instances of Visual Studio. If you install the analyzers as a NuGet package, which is the preferred method, they apply only to the project where the NuGet package was installed. In team environments, analyzers installed as NuGet packages are in scope for *all developers* that work on that project.

### Build errors

To have rules enforced at build time, including through the command line or as part of a continuous integration (CI) build, install the analyzers as a NuGet package. Analyzer warnings and errors don't show up in the build report if you install the analyzers as an extension.

The following screenshot shows the command-line build output from building a project that contains an analyzer rule violation:

![MSBuild output with rule violation](media/command-line-build-analyzers.png)

### Rule severity

You cannot set the severity of rules from analyzers that were installed as a Visual Studio extension. To configure [rule severity](../code-quality/use-roslyn-analyzers.md#rule-severity), install the analyzers as a NuGet package.

### Three categories of analyzers
- Microsoft's recommended analyzers: [FxCop Analyzers](../code-quality/fxcop-analyzers.yml)
- Visual Studio IDE analyzers: [EditorConfig](../ide/code-styles-and-code-cleanup.md)
- Third party analyzers: [StyleCop](https://www.nuget.org/packages/StyleCop.Analyzers/), [Roslynator](https://www.nuget.org/packages/Roslynator/), [XUnit Analyzers](https://www.nuget.org/packages/xunit.analyzers/), [Sonar Analyzer](https://www.nuget.org/packages/SonarAnalyzer.CSharp/)

## Next steps

> [!div class="nextstepaction"]
> [Install Roslyn analyzers in Visual Studio](../code-quality/install-roslyn-analyzers.md)

> [!div class="nextstepaction"]
> [Use Roslyn analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## See also

- [Analyzers FAQ](analyzers-faq.md)
- [Write your own Roslyn analyzer](../extensibility/getting-started-with-roslyn-analyzers.md)
- [.NET Compiler Platform SDK](/dotnet/csharp/roslyn-sdk/)