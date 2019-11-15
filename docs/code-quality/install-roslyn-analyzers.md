---
title: Install Roslyn analyzers
ms.date: 08/03/2018
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, managed code"
  - "analyzers"
  - "Roslyn analyzers"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Install .NET Compiler Platform code analyzers

Visual Studio includes a core set of .NET Compiler Platform (*Roslyn*) analyzers. These analyzers are always on. You can install additional analyzers either as NuGet packages, or as Visual Studio extensions in *VSIX* files.

## To install NuGet analyzer packages

1. Find the analyzer package you want to install on www.nuget.org.

   For example, you may want to [install the Microsoft FxCop analyzers](install-fxcop-analyzers.md#nuget-package) to check your code for security and performance issues, among others. Or, install [StyleCop.Analyzers](https://www.nuget.org/packages/stylecop.analyzers/) to look for style issues in your codebase.

2. Install the package in Visual Studio, using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The www.nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.

   The analyzer assemblies are installed and appear in **Solution Explorer** under **References** > **Analyzers**.

## To install VSIX analyzers

::: moniker range="vs-2017"

1. In Visual Studio, select **Tools** > **Extensions and Updates**.

   The **Extensions and Updates** dialog box opens.

   > [!NOTE]
   > Alternatively, you can find and download the analyzer extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com).

::: moniker-end

::: moniker range=">=vs-2019"

1. In Visual Studio, select **Extensions** > **Manage Extensions**.

   The **Manage Extensions** dialog box opens.

   > [!NOTE]
   > Alternatively, you can find and download the analyzer extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com).

::: moniker-end

2. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

3. In the search box, type the name of the analyzer extension you want to install. For example, you may want to [install the Microsoft FxCop analyzers](install-fxcop-analyzers.md#vsix) to check your code for security and performance issues, among others.

4. Select **Download**.

   The extension is downloaded.

5. Select **OK** to close the dialog box, and then close all instances of Visual Studio to launch the **VSIX Installer**.

   The **VSIX Installer** dialog box opens.

   ![VSIX installer for Microsoft Code Analysis](media/vsix-installer-code-analysis.png)

6. Select **Modify** to start the installation.

7. After a minute or two, the installation completes. Select **Close**.

8. Open Visual Studio again.

::: moniker range="vs-2017"

If you want to check whether the extension is installed, select **Tools** > **Extensions and Updates**. In the **Extensions and Updates** dialog box, select the **Installed** category on the left, and then search for the extension by name.

::: moniker-end

::: moniker range=">=vs-2019"

If you want to check whether the extension is installed, select **Extensions** > **Manage Extensions**. In the **Manage Extensions** dialog box, select the **Installed** category on the left, and then search for the extension by name.

::: moniker-end

## Next steps

> [!div class="nextstepaction"]
> [Use code analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)

## See also

- [Overview of code analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Install FxCop analyzers](../code-quality/install-fxcop-analyzers.md)
