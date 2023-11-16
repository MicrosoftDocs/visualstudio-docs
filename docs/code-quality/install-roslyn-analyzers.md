---
title: Install third party analyzers
ms.date: 08/27/2020
description: Learn how to install third-party analyzers in Visual Studio. See how to install analyzers in .vsix files and NuGet analyzer packages.
ms.topic: conceptual
helpviewer_keywords:
- code analysis, managed code
- analyzers
- Roslyn analyzers
author: mikadumont
ms.author: midumont
manager: jmartens
ms.technology: vs-ide-code-analysis
---
# Install third-party analyzers

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Visual Studio includes a core set of .NET Compiler Platform (*Roslyn*) analyzers. These analyzers are always on. You can install additional analyzers either as NuGet packages, or as Visual Studio extensions in *VSIX* files.

## To install NuGet analyzer packages

1. Find the analyzer package you want to install on www.nuget.org.

   For example, you may want to install [StyleCop.Analyzers](https://www.nuget.org/packages/stylecop.analyzers/) to look for style issues in your codebase.

2. Install the package in Visual Studio, using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The www.nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.

   The analyzer assemblies are installed and appear in **Solution Explorer** under **References** > **Analyzers**.

## To install VSIX analyzers

1. In Visual Studio, select **Extensions** > **Manage Extensions**.

   The **Manage Extensions** dialog box opens.

   > [!NOTE]
   > Alternatively, you can find and download the analyzer extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com).

2. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

3. In the search box, type the name of the analyzer extension you want to install.

4. Select **Download**.

   The extension is downloaded.

5. Select **OK** to close the dialog box, and then close all instances of Visual Studio to launch the **VSIX Installer**.

   The **VSIX Installer** dialog box opens.

   ![VSIX installer for Microsoft Code Analysis](media/vsix-installer-code-analysis.png)

6. Select **Modify** to start the installation.

7. After a minute or two, the installation completes. Select **Close**.

8. Open Visual Studio again.

If you want to check whether the extension is installed, select **Extensions** > **Manage Extensions**. In the **Manage Extensions** dialog box, select the **Installed** category on the left, and then search for the extension by name.

## Next steps

> [!div class="nextstepaction"]
> [Use code analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## Related content

- [Overview of code analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Install .NET analyzers](../code-quality/install-net-analyzers.md)
