---
title: Install Roslyn analyzers
ms.date: 08/03/2018
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

1. Find the analyzer package you want to install on www.nuget.org.

1. Install the package in Visual Studio, using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The www.nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.
   >
   > ![NuGet.org page showing Package Manager Console command](media/nuget-install-command.png)

   The analyzer assemblies are installed and appear in **Solution Explorer** under **References** > **Analyzers**.

## To install VSIX analyzers

1. In Visual Studio, select **Tools** > **Extensions and Updates**.

   The **Extensions and Updates** dialog box opens.

   > [!NOTE]
   > Alternatively, you can find and download the analyzer extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com).

1. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

1. In the search box, type the name of the analyzer extension you want to install.

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

> [!div class="nextstepaction"]
> [Use Roslyn analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## See also

- [Overview of Roslyn analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Install FxCop analyzers](../code-quality/install-fxcop-analyzers.md)