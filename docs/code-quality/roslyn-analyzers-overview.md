---
title: Code analysis using .NET compiler platform (Roslyn) analyzers
description: Become familiar with source code analysis in Visual Studio. Learn about code fixes and the different types of analyzers and severity levels.
author: mikadumont
ms.author: midumont
manager: mijacobs
ms.subservice: code-analysis
ms.topic: conceptual
helpviewer_keywords:
- code analysis, managed code
- analyzers
- Roslyn analyzers
- code analyzers
ms.date: 04/04/2024

#customer intent: As a developer, I want to learn about code analysis using .NET compiler platform (Roslyn) analyzers so that I can understand how then work and use them properly.
---

# Code analysis using .NET compiler platform (Roslyn) analyzers

.NET compiler platform (Roslyn) analyzers inspect your C# or Visual Basic code for style, quality, maintainability, design, and other issues. This inspection or analysis happens during design time in all open files.

Analyzers are divided into the following groups:

- [Code style analyzers](/dotnet/fundamentals/code-analysis/code-style-rule-options?preserve-view=true&view=vs-2019#convention-categories)

   These analyzers are built into Visual Studio. The analyzer's diagnostic ID, or code format is IDExxxx, for example, IDE0001. You can configure preferences in the [text editor options page](../ide/code-styles-and-code-cleanup.md#net-code-styles-in-the-options-dialog-box) or in an [EditorConfig file](../ide/create-portable-custom-editor-options.md). Starting in .NET 5.0, code style analyzers are included with the .NET SDK and can be strictly enforced as build warnings or errors. For more information, see [Overview of .NET source code analysis](/dotnet/fundamentals/productivity/code-analysis).

- [Code quality analyzers](/dotnet/fundamentals/code-analysis/overview#code-quality-analysis)

   These analyzers are included with the .NET 5.0 and later SDK and enabled by default. The analyzer's diagnostic ID, or code format is CAxxxx, for example, CA1822. For more information, see [Overview of .NET code quality analysis](/dotnet/fundamentals/productivity/code-analysis).

- External analyzers

   Examples of external analyzers are [StyleCop](https://www.nuget.org/packages/StyleCop.Analyzers/), [Roslynator](https://www.nuget.org/packages/Roslynator.Analyzers/), [xUnit Analyzers](https://www.nuget.org/packages/xunit.analyzers/), and [Sonar Analyzer](https://www.nuget.org/packages/SonarAnalyzer.CSharp/). You can install these analyzers as either a NuGet package or a Visual Studio extension.

## Severity levels of analyzers

Each Roslyn analyzer rule, or *diagnostic*, has a default severity and suppression state that you can customize for your project.

Severity levels include: Error, Warning, Suggestion, Silent, None, and Default. For detailed information and behavior, see [Configure severity levels](../code-quality/use-roslyn-analyzers.md#configure-severity-levels).

## Rule violations

If an analyzer finds any analyzer rule violations, it reports them in the **Error List** window and in the code editor.

The following screenshot shows rule violations reported in the **Error List** window. The analyzer violations reported in the error list match the [severity level setting](../code-quality/use-roslyn-analyzers.md#configure-severity-levels) of the rule:

:::image type="content" source="media/code-analysis-error-list.png" alt-text="Screenshot that shows analyzer violations in the Error List window." lightbox="media/code-analysis-error-list.png":::

The analyzer rule violations also appear in the code editor as squiggle lines under the offending code. For example, the following screenshot shows three violations: one error (red squiggle line), one warning (green squiggle line), and one suggestion (three gray dots):

:::image type="content" source="media/diagnostics-severity-colors.png" alt-text="Screenshot that shows error, warning, and suggestion marks in the code editor.":::

## Code fixes

Many diagnostics have one or more associated *code fixes* that you can apply to correct the rule violation. Code fixes are shown in the light bulb icon menu along with other types of [Quick Actions](../ide/quick-actions.md). For more information about code fixes, see [Common Quick Actions](../ide/quick-actions.md).

:::image type="content" source="media/built-in-analyzer-code-fix.png" alt-text="Screenshot that shows an analyzer violation and Quick Action code fix in the code editor.":::

## Configure analyzer severity levels

You can configure the severity of analyzer rules in an [EditorConfig file](../code-quality/use-roslyn-analyzers.md#set-rule-severity-in-an-editorconfig-file) or from the [light bulb menu](../code-quality/use-roslyn-analyzers.md#set-rule-severity-from-the-light-bulb-menu).

You can also configure analyzers to inspect code at build time and as you type. You can configure the scope of live code analysis to execute for the current document only, all open documents, or the entire solution. For more information, see [Configure live code analysis for .NET](./configure-live-code-analysis-scope-managed-code.md).

> [!TIP]
> Build-time errors and warnings from code analyzers are shown only if the analyzers are installed as a NuGet package. The built-in analyzers (for example, IDE0067 and IDE0068) never run during build.

## Install external code analyzers

Visual Studio includes a core set of Roslyn analyzers, which are always active. If you need more code analyzers, you can install external analyzers for every project via a NuGet package. Some analyzers are also available as a Visual Studio *.vsix* extension, in which case they apply to any solution you open in Visual Studio. For information about installing these two different types of analyzers, see [Install code analyzers](../code-quality/install-roslyn-analyzers.md).

### Scope

If you install an analyzer as a NuGet package, the preferred method for external analyzers, it applies only to the project where the NuGet package is installed. Otherwise, if you install an analyzer as a Visual Studio extension, it applies at the solution level and to all instances of Visual Studio. In team environments, an analyzer you install as a NuGet package is in scope for all developers that work on that project.

> [!NOTE]
> First-party analyzers ship within the .NET SDK. It's preferable that you enable these analyzers from the .NET SDK instead of installing them as a `Microsoft.CodeAnalysis.NetAnalyzers` [NuGet package](https://www.nuget.org/packages/Microsoft.CodeAnalysis.NetAnalyzers). Enabling the analyzers from the .NET SDK ensures that you automatically get analyzer bug fixes and new analyzers as soon as you update the SDK. For more information about analyzers, see [Enable or install first-party .NET analyzers](install-net-analyzers.md).

### Build errors

To enforce the rules at build time, by using either a command-line or continuous integration (CI) builds, choose one of the following options:

- Create a .NET 5.0 or later project, which enables code analysis by default. To enable code analysis on projects that target earlier .NET versions, set the [EnableNETAnalyzers](/dotnet/core/project-sdk/msbuild-props#enablenetanalyzers) property to `true`.

- Install the analyzers as a NuGet package. If you install the analyzers as a Visual Studio extension, analyzer warnings and errors don't appear in the build report.

The following screenshot shows the command-line build output from building a project that contains an analyzer rule violation:

:::image type="content" source="media/command-line-build-analyzers.png" alt-text="Screenshot that shows an MSBuild output with a rule violation in a Developer Command Prompt.":::

### Rule severity

If you want to configure [analyzer rule severity](../code-quality/use-roslyn-analyzers.md#configure-severity-levels) for external analyzers, you must install the analyzer as a NuGet package. You can't configure rule severity from analyzers that were installed as a Visual Studio extension.

## Next steps

> [!div class="nextstepaction"]
> [Install code analyzers in Visual Studio](../code-quality/install-roslyn-analyzers.md)

> [!div class="nextstepaction"]
> [Use code analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## Related content

- [FAQ for code analysis in Visual Studio](analyzers-faq.yml)
- [Roslyn analyzers](../extensibility/getting-started-with-roslyn-analyzers.md)
- [.NET Compiler Platform SDK](/dotnet/csharp/roslyn-sdk/)
