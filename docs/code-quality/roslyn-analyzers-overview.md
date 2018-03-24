---
title: "Roslyn analyzers in Visual Studio | Microsoft Docs"
ms.custom: 03/26/2018
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload:
  - "dotnet"
---
# Overview of .NET Compiler Platform analyzers for code analysis

Visual Studio 2017 includes a built-in set of analyzers that analyze your C# or Visual Basic code as you type. If rule violations are found, they are reported both in the code editor as a *squiggly*, and in the **Error List**. In addition to the built-in analyzers, you can install additional analyzers, either as a NuGet package, or as a Visual Studio extension.

The built-in analyzers also have associated *code fixes* that you can apply. For more information, see [Quick Actions](../ide/quick-actions.md).

![Analyzer violation in code editor](../code-quality/media/add-me.png)

## Roslyn analyzers vs. static code analysis

.NET Compiler Platform ("Roslyn") analyzers will eventually replace [static code analysis](../code-quality/code-analysis-for-managed-code-overview.md) for managed code. Many of the static code analysis rules have already been rewritten as Roslyn analyzers.

Like static code analysis rule violations, Roslyn analyzer violations also appear in the **Error List** (in addition to the code editor). Roslyn analyzers analyze code at build time, like static code analysis if it's enabled, but also as you type. If you enable [full solution analysis](../code-quality/how-to-enable-and-disable-full-solution-analysis-for-managed-code.md#to-toggle-full-solution-analysis), Roslyn analyzers also provide live analysis of code files that aren't open in the editor.

The menu option **Analyze** > **Run Code Analysis**, and the **Enable Code Analysis on Build** checkbox on a project's **Code Analysis** property page, only apply to static code analysis. They have no bearing on Roslyn analyzers.

## Install analyzers

Visual Studio 2017 includes a core set of Roslyn analyzers. These analyzers are always on. You can install additional analyzers either as NuGet packages, or as Visual Studio extensions in *VSIX* files.

### To install NuGet package analyzers

1. [Determine which analyzer package version](https://github.com/dotnet/roslyn-analyzers#recommended-version-of-analyzer-packages) to install, based on your version of Visual Studio.

1. Install the package in Visual Studio, using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.
   >
   > ![NuGet.org page showing Package Manager Console command](media/nuget-package-manager-command.png)

   The analyzer assemblies are installed and appear in **Solution Explorer** under **References** > **Analyzers**.

   ![Analyzers node in Solution Explorer](media/solution-explorer-analyzers-node.png)

### To install VSIX analyzers

1. In Visual Studio, select **Tools** > **Extensions and Updates**.

   The **Extensions and Updates** dialog box opens.

   > [!NOTE]
   > Alternatively, download the extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017).

1. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

1. In the search box, type "code analysis", and then select the **Microsoft Code Analysis 2017** extension. Select **Download**.

   The extension is downloaded.

1. Select **OK** to close the dialog box, and then close all instances of Visual Studio to launch the **VSIX Installer**.

   The **VSIX Installer** dialog box opens.

   ![VSIX installer for Microsoft Code Analysis](media/vsix-installer-code-analysis.png)

1. Select **Modify** to start the installation.

1. After a minute or two, the installation completes. Select **Close**.

1. Open Visual Studio again.

## NuGet package vs. extension

### Scope

If you install the analyzers as an extension, they apply at the solution level, to all instances of Visual Studio. If you install the analyzers as a NuGet package, which is the preferred method, the apply only to the project where the NuGet package was installed.

### Build errors

Extensions cannot affect build, so analyzer warnings and errors don't show up in the build report if you installed them as an extension. Additionally, if you build your project from the command line, you won't see any analyzer violations. To have rules enforced at build time, either through the command line or as part of a continuous integration (CI) build, install the analyzers as a NuGet package.

## Next steps

