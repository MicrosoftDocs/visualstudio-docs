---
title: Install Roslyn analyzers in Visual Studio
ms.date: 03/26/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
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
# Install .NET Compiler Platform analyzers

Visual Studio 2017 includes a core set of .NET Compiler Platform (*Roslyn*) analyzers. These analyzers are always on. You can install additional analyzers either as NuGet packages, or as Visual Studio extensions in *VSIX* files.

## To install NuGet analyzer packages

1. [Determine which analyzer package version](#analyzer-package-versions) to install, based on your version of Visual Studio.

1. Install the package in Visual Studio, using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.
   >
   > ![NuGet.org page showing Package Manager Console command](media/nuget-package-manager-command.png)

   The analyzer assemblies are installed and appear in **Solution Explorer** under **References** > **Analyzers**.

   ![Analyzers node in Solution Explorer](media/solution-explorer-analyzers-node.png)

### Analyzer package versions

Use the following guidelines to determine the version of analyzer packages to install for a given version of Visual Studio.

|Visual Studio version|Analyzer package version|
|-|-|
|Visual Studio 2017 version 15.5 and later|2.6.1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.6.1|
|Visual Studio 2017 version 15.3 to 15.4|2.3.0-beta1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.3.0-beta1|
|Visual Studio 2017 version 15.0 to 15.2|2.0.0-beta2, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.0.0-beta2|
|Visual Studio 2015 update 2 and 3|Version 1.2.0-beta2, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.2.0-beta2|
|Visual Studio 2015 Update 1|Version 1.1.0, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.1.|
|Visual Studio 2015 RTW|Version 1.0.1, for example https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.0.1|

On Visual Studio 2017 version 15.5 and later, you can also install a custom [Microsoft code analysis VSIX extension](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017) that contains all of the analyzers for managed projects.

## To install VSIX analyzers

1. In Visual Studio, select **Tools** > **Extensions and Updates**.

   The **Extensions and Updates** dialog box opens.

   > [!NOTE]
   > Alternatively, download the extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017).

1. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

1. In the search box, type "code analysis", and look for the **Microsoft Code Analysis 2017** extension.

   ![Microsoft Code Analysis extension](media/extensions-and-updates-code-analysis.png)

1. Select **Download**.

   The extension is downloaded.

1. Select **OK** to close the dialog box, and then close all instances of Visual Studio to launch the **VSIX Installer**.

   The **VSIX Installer** dialog box opens.

   ![VSIX installer for Microsoft Code Analysis](media/vsix-installer-code-analysis.png)

1. Select **Modify** to start the installation.

1. After a minute or two, the installation completes. Select **Close**.

1. Open Visual Studio again.

If you want to check whether the extension is installed, select **Tools** > **Extensions and Updates**. In the **Extensions and Updates** dialog box, select the **Installed** category on the left, and then search for the extension by name.

## Next steps

- [Use Roslyn analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## See also

- [Overview of Roslyn analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)