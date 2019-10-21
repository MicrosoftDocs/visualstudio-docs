---
title: Install FxCop analyzers
ms.date: 08/03/2018
ms.topic: conceptual
helpviewer_keywords:
  - "fxcop analyzers"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "dotnet"
---
# Install FxCop analyzers in Visual Studio

Microsoft created a set of analyzers, called [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers), that contains the most important "FxCop" rules from legacy analysis. These analyzers check your code for security, performance, and design issues, among others.

You can install these FxCop analyzers either as a NuGet package or as a VSIX extension to Visual Studio. To learn about the pros and cons of each, see [NuGet package vs. VSIX extension](roslyn-analyzers-overview.md#nuget-package-versus-vsix-extension).

## NuGet package

::: moniker range=">=vs-2019"

In Visual Studio 2019 version 16.3 and later, you can install the [Microsoft.CodeAnalysis.FxCopAnalyzers](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers) NuGet package directly from the project's Code Analysis properties page:

1. Right-click on the project node in **Solution Explorer**, select **Properties**, and then select the **Code Analysis** tab.

   ![Install FxCop analyzers package from properties page in Visual Studio](media/install-fxcop-properties-page.png)

2. Select **Install**.

   Visual Studio installs the latest version of the Microsoft.CodeAnalyzers.FxCopAnalyzers package. The assemblies appear in **Solution Explorer** under **References** > **Analyzers**.

   ![Analyzers node in Solution Explorer](media/solution-explorer-analyzers-node.png)

If you're using an older version of Visual Studio 2019, install the package using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

::: moniker-end

::: moniker range="vs-2017"

1. [Determine which analyzer package version](#fxcopanalyzers-package-versions) to install, based on your version of Visual Studio.

2. Install the package in Visual Studio using either the [Package Manager Console](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console) or the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

   > [!NOTE]
   > The nuget.org page for each analyzer package shows you the command to paste into the **Package Manager Console**. There's even a handy button to copy the text to the clipboard.
   >
   > ![NuGet.org page showing Package Manager Console command](media/nuget-package-manager-command.png)

   The analyzer assemblies are installed, and they appear in **Solution Explorer** under **References** > **Analyzers**.

::: moniker-end

### Custom installation

For custom installation, for example to specify a different version of the package, select the ellipsis (...) button on the project's Code Analysis properties page. This button opens the NuGet package manager with "Microsoft.CodeAnalysis.FxCopAnalyzers" as the search string.

![Install custom FxCop analyzers package from properties page in Visual Studio](media/install-fxcop-properties-page-ellipsis.png)

> [!TIP]
> Determine [which analyzer package version](#fxcopanalyzers-package-versions) to install, based on your version of Visual Studio. You can also install the package from the [Package Manager UI](/nuget/quickstart/install-and-use-a-package-in-visual-studio#package-manager-console).

### FxCopAnalyzers package versions

Use the following guidelines to determine which version of the FxCop analyzers package to install for your version of Visual Studio:

| Visual Studio version | FxCop analyzer package version |
| - | - |
| Visual Studio 2019 (all versions)<br />Visual Studio 2017 version 15.8 and later | [latest](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/) |
| Visual Studio 2017 version 15.5 to 15.7 | [2.6.3](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.6.3) |
| Visual Studio 2017 version 15.3 to 15.4 | [2.3.0-beta1](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.3.0-beta1) |
| Visual Studio 2017 version 15.0 to 15.2 | [2.0.0-beta2](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/2.0.0-beta2) |
| Visual Studio 2015 update 2 and 3 | [1.2.0-beta2](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.2.0-beta2) |
| Visual Studio 2015 Update 1 | [1.1.0](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.1.0) |
| Visual Studio 2015 RTW | [1.0.1](https://www.nuget.org/packages/Microsoft.CodeAnalysis.FxCopAnalyzers/1.0.1) |

## VSIX

::: moniker range="vs-2017"

On Visual Studio 2017 version 15.5 and later, you can install the [Microsoft Code Analysis 2017](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017) extension that contains all of the FxCop analyzers for managed projects.

1. In Visual Studio, select **Tools** > **Extensions and Updates**.

   The **Extensions and Updates** dialog box opens.

   > [!NOTE]
   > Alternatively, download the extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2017).

2. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

3. In the search box, type "code analysis", and look for the **Microsoft Code Analysis 2017** extension.

   ![Microsoft Code Analysis 2017 extension](media/extensions-and-updates-code-analysis.png)

::: moniker-end

::: moniker range=">=vs-2019"

The [Microsoft Code Analysis 2019](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2019) extension contains all of the FxCop analyzers for managed projects. To install this extension:

1. In Visual Studio, select **Extensions** > **Manage Extensions**.

   The **Manage Extensions** dialog box opens.

   > [!NOTE]
   > Alternatively, download the extension directly from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=VisualStudioPlatformTeam.MicrosoftCodeAnalysis2019).

2. Expand **Online** in the left pane, and then select **Visual Studio Marketplace**.

3. In the search box, type "code analysis", and look for the **Microsoft Code Analysis 2019** extension.

   ![Microsoft Code Analysis 2019 extension](media/manage-extensions-code-analysis.png)

::: moniker-end

4. Select **Download**.

   The extension is downloaded.

5. Select **OK** to close the dialog box, and then close all instances of Visual Studio to launch the **VSIX Installer**.

   The **VSIX Installer** dialog box opens.

   ::: moniker range="vs-2017"

   ![VSIX installer for Microsoft Code Analysis](media/vsix-installer-code-analysis.png)

   ::: moniker-end

6. Select **Modify** to start the installation.

   After a minute or two, the installation completes.

7. Select **Close**, then open Visual Studio again.

::: moniker range="vs-2017"

If you want to check whether the extension is installed, select **Tools** > **Extensions and Updates**. In the **Extensions and Updates** dialog box, select the **Installed** category on the left, and then search for the extension by name.

::: moniker-end

::: moniker range=">=vs-2019"

If you want to check whether the extension is installed, select **Extensions** > **Manage Extensions**. In the **Manage Extensions** dialog box, select the **Installed** category on the left, and then search for the extension by name.

::: moniker-end

## See also

- [Overview of code analyzers in Visual Studio](../code-quality/roslyn-analyzers-overview.md)
- [Use code analyzers in Visual Studio](../code-quality/use-roslyn-analyzers.md)
- [Migrate from legacy analysis to code analyzers](../code-quality/fxcop-analyzers.yml)
