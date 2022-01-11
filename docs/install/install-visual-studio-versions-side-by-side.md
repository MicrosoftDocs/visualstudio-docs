---
title: Install Visual Studio versions side-by-side
description: Learn how to install Visual Studio on a computer that has an earlier or later version of Visual Studio already installed.
ms.custom: "vs-acquisition, SEO-VS-2020"
ms.date: 03/29/2021
ms.prod: visual-studio-windows
ms.technology: vs-installation
ms.topic: conceptual
helpviewer_keywords:
- side-by-side installations [Visual Studio]
- Help [Visual Studio], installing
- install multiple versions of Visual Studio
author: anandmeg
ms.author: meghaanand
manager: jmartens
---
# Install Visual Studio versions side-by-side

You can install Visual Studio on a computer that has an earlier or later version of Visual Studio already installed.

::: moniker range="vs-2017"

Before you install versions side-by-side, review the following conditions:

* If you use Visual Studio 2017 to open a solution that was created in Visual Studio 2015, you can later open and modify the solution again in the earlier version as long as you haven't implemented any features that are specific to Visual Studio 2017.

* If you try to use Visual Studio 2017 to open a solution that was created in Visual Studio 2015 or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2017. For more information, see the [Port, migrate, and upgrade Visual Studio Projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md?view=vs-2017&preserve-view=true) page.

::: moniker-end

::: moniker range="vs-2019"

Before you install versions side-by-side, review the following conditions:

* If you use Visual Studio 2019 to open a solution that was created in Visual Studio 2017, you can later open and modify the solution again in the earlier version as long as you haven't implemented any features that are specific to Visual Studio 2019.

* If you try to use Visual Studio 2019 to open a solution that was created in Visual Studio 2017 or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2019. For more information, see the [Port, migrate, and upgrade Visual Studio Projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md) page.

::: moniker-end

::: moniker range=">=vs-2022"

Before you install versions side-by-side, review the following conditions:

* If you use Visual Studio 2022 to open a solution that was created in Visual Studio 2017 or Visual Studio 2019, you can later open and modify the solution again in the earlier version as long as you haven't implemented any features that are specific to Visual Studio 2022.

* If you try to use Visual Studio 2022 to open a solution that was created in Visual Studio 2019 or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2022. For more information, see the [Port, migrate, and upgrade Visual Studio Projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md) page.

::: moniker-end

* If you uninstall a version of Visual Studio on a computer that has more than one version installed, the file associations for Visual Studio are removed for all versions.

* Visual Studio doesn't automatically upgrade extensions because not all extensions are compatible. You must reinstall the extensions from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or the software publisher.

## Install minor Visual Studio versions side-by-side

When upgrading from one minor version of Visual Studio to the next, the Visual Studio installer will, by default, update your current install to the latest version in that channel. For example, suppose 16.9.4 was just released. The installer will try to replace your current install of 16.9.3 (or lower) with 16.9.4, since both versions are part of the [Visual Studio 2019 release channel](/visualstudio/productinfo/release-rhythm). Replacing the older release with the newer release during update helps ensure older versions of Visual Studio aren't taking up room on your machine. However, in some specific cases, it might be helpful to install different minor release versions of Visual Studio side-by-side. For example, you may want to have both 16.9.3 and 16.9.4 on the same machine.

::: moniker range="vs-2017"

1. Download the latest bootstrapper for Visual Studio 2017 version 15.9 from the [Visual Studio previous versions](https://visualstudio.microsoft.com/vs/older-downloads/) page for the version that you would like to install side-by-side with your existing version of Visual Studio.

1. Open the command prompt in administrator mode. To do this, open the Windows Start menu, type "cmd", right-click on the Command Prompt search result, and select **Run as administrator**. In the command prompt, change the directory to the folder where your Visual Studio bootstrapper file is located.

1. Run the following command, specifying a new folder path for the installation location and replacing the .exe file name with the appropriate bootstrapper name for the version of Visual Studio you are installing. The .exe file name should match or be similar to one of the following files:

   * vs_enterprise.exe for Visual Studio Enterprise
   * vs_professional.exe for Visual Studio Professional

1. Follow the installer dialogs to select the components you need for your installation. For more information, see [Install Visual Studio](install-visual-studio.md#step-4---choose-workloads).

::: moniker-end

::: moniker range="vs-2019"

1. Download the Visual Studio 2019 bootstrapper file from either the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads) or the [Visual Studio 2019 Releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page for the minor version that you would like to install side-by-side with your existing version of Visual Studio.

1. Open the command prompt in administrator mode. To do this, open the Windows Start menu, type "cmd", right-click on the Command Prompt search result, and select **Run as administrator**. In the command prompt, change the directory to the folder where your Visual Studio bootstrapper file is located.

1. Run the following command, specifying a new folder path for the installation location and replacing the .exe file name with the appropriate bootstrapper name for the version of Visual Studio you are installing. The .exe file name should match or be similar to one of the following files:

   * vs_enterprise.exe for Visual Studio Enterprise
   * vs_professional.exe for Visual Studio Professional
   * vs_community.exe for Visual Studio Community

   ```shell
   vs_Enterprise.exe --installPath "C:\Program Files (x86)\Microsoft Visual Studio\<AddNewPath>"
   ```

1. Follow the installer dialogs to select the components you need for your installation. For more information, see [Install Visual Studio](install-visual-studio.md#step-4---choose-workloads).

::: moniker-end

::: moniker range=">=vs-2022"

1. Download the Visual Studio 2022 bootstrapper file from either the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads) or the [Visual Studio 2022 Releases](/visualstudio/releases/2022/release-notes) page for the minor version that you would like to install side-by-side with your existing version of Visual Studio.

1. Open the command prompt in administrator mode. To do this, open the Windows Start menu, type "cmd", right-click on the Command Prompt search result, and select **Run as administrator**. In the command prompt, change the directory to the folder where your Visual Studio bootstrapper file is located.

1. Run the following command, specifying a new folder path for the installation location and replacing the .exe file name with the appropriate bootstrapper name for the version of Visual Studio you are installing. The .exe file name should match or be similar to one of the following files:

   * vs_enterprise.exe for Visual Studio Enterprise
   * vs_professional.exe for Visual Studio Professional
   * vs_community.exe for Visual Studio Community

   ```shell
   vs_Enterprise.exe --installPath "C:\Program Files\Microsoft Visual Studio\<AddNewPath>"
   ```

1. Follow the installer dialogs to select the components you need for your installation. For more information, see [Install Visual Studio](install-visual-studio.md#step-4---choose-workloads).
   
::: moniker-end

## .NET Framework versions and side-by-side installations

Visual Basic, Visual C#, and Visual F# projects use the **Target Framework** option in the **Project Designer** to specify which version of the .NET Framework that a project uses. For a C++ project, you can manually change the target framework by modifying the .vcxproj file. For more information, see the [Version compatibility in the .NET Framework](/dotnet/framework/migration-guide/version-compatibility) page.

When you create a project, you can specify which version of the .NET Framework the project targets in the **.NET Framework** list in the **New Project** dialog box.

For language-specific information, see the appropriate topic in the following table.

::: moniker range="vs-2017"

| Language     | Topic                                                                                                                                                   |
|--------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|
| Visual Basic | [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md?view=vs-2017&preserve-view=true) |
| Visual C#    | [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md?view=vs-2017&preserve-view=true)                 |
| Visual F#    | [Develop with Visual F# in Visual Studio](../ide/fsharp-visual-studio.md?view=vs-2017&preserve-view=true)                                               |
| C++          | [How to: Modify the target framework and platform toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset/)                         |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md?view=vs-2017&preserve-view=true)
* [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md?view=vs-2017&preserve-view=true)
* [Building C/C++ isolated applications and side-by-side assemblies](/cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies/)

::: moniker-end

::: moniker range=">= vs-2019"

| Language     | Topic                                                                                                                           |
|--------------|---------------------------------------------------------------------------------------------------------------------------------|
| Visual Basic | [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)         |
| Visual C#    | [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)                         |
| Visual F#    | [Develop with Visual F# in Visual Studio](../ide/fsharp-visual-studio.md)                                                       |
| C++          | [How to: Modify the target framework and platform toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset/) |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md)
* [Building C/C++ isolated applications and side-by-side assemblies](/cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies/)

::: moniker-end
