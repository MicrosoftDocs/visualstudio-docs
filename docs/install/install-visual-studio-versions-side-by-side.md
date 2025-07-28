---
title: Install Visual Studio Versions Side-by-Side
description: Learn how to install Visual Studio on a computer that has an earlier or later version of Visual Studio already installed.
ms.custom: vs-acquisition
ms.date: 08/01/2025

ms.subservice: installation
ms.topic: conceptual
helpviewer_keywords:
- side-by-side installations [Visual Studio]
- Help [Visual Studio], installing
- install multiple versions of Visual Studio
author: anandmeg
ms.author: meghaanand
manager: mijacobs
#customer intent: As a developer, I want to learn how to install different versions of Visual Studio on the same system to support different projects.
---
# Install Visual Studio versions side-by-side

You can install Visual Studio on a computer that has an earlier or later [major version](/visualstudio/productinfo/release-rhythm#determining-your-product-edition-version-and-channel) of Visual Studio already installed.

::: moniker range="vs-2019"

Before you install versions side-by-side, review the following conditions:

- Suppose that you use Visual Studio 2019 to open a solution that was created in Visual Studio 2017. You can later open and modify the solution in the earlier version unless you implement features that are specific to Visual Studio 2019.

- Suppose that you use Visual Studio 2019 to open a solution that was created in Visual Studio 2017 or an earlier version. You might need to modify your projects and files to be compatible with Visual Studio 2019. For more information, see [Port, migrate, and upgrade Visual Studio Projects](/visualstudio/releases/2019/port-migrate-and-upgrade-visual-studio-projects).

::: moniker-end

::: moniker range=">=vs-2022"

Before you install versions side-by-side, review the following conditions:

- Suppose that you use Visual Studio 2022 to open a solution that was created in Visual Studio 2017 or Visual Studio 2019. You can later open and modify the solution again in the earlier version unless you implement features that are specific to Visual Studio 2022.

- Suppose that you use Visual Studio 2022 to open a solution that was created in Visual Studio 2019 or an earlier version. You might need to modify your projects and files to be compatible with Visual Studio 2022. For more information, see [Port, migrate, and upgrade Visual Studio Projects](/visualstudio/releases/2022/port-migrate-and-upgrade-visual-studio-projects).

::: moniker-end

- If you uninstall a version of Visual Studio on a computer that has more than one version installed, the file associations for Visual Studio are removed for all versions.

- Visual Studio doesn't automatically upgrade extensions because not all extensions are compatible. You must reinstall the extensions from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or the software publisher.

## Install different editions of the same major Visual Studio version side-by-side

::: moniker range="vs-2019"

Each installation of Visual Studio must have a unique combination of major version, edition, and [update channel](/visualstudio/install/update-visual-studio?view=vs-2019&preserve-view=true#configure-source-location-of-updates). For example, you can install Visual Studio 2019 Enterprise Preview ([preview channel](/visualstudio/productinfo/release-rhythm)) alongside Visual Studio 2019 Enterprise (release channel) alongside Visual Studio 2017 Professional (release channel) alongside Visual Studio 2017 Professional (custom layout channel).

When you upgrade from one minor version of Visual Studio to the next, by default, the Visual Studio Installer updates your current installation to the latest version in that channel. For example, if Microsoft releases version 16.11.24 to the [Visual Studio 2019 release channel](/visualstudio/productinfo/release-rhythm), the installer tries to replace your current installation of Visual Studio 2019 from the release channel with this latest version on the same channel.

### Manual installation

You can manually use another bootstrapper to install a new instance of Visual Studio, or you can select one of the options from the Visual Studio Installer's **Available** tab.  

1. To use another bootstrapper, you can download and run one of the bootstrapper files for Visual Studio 2019 from the [Visual Studio 2019 releases](/visualstudio/releases/2019/history#installing-an-earlier-release) page for the edition that you want to install side-by-side with your existing installation of Visual Studio. If you are in an organization, your IT Administrator might create a layout and provided a link to the bootstrapper in that layout.

1. Using the installer's **Available** tab presumes that you already have some other version of Visual Studio installed. First find the **Visual Studio Installer** on your computer and launch it. After it updates itself, select the **Available** tab and install one of the offered products.

::: moniker-end

::: moniker range=">=vs-2022"

Each installation of Visual Studio must have a unique combination of major version, edition, and [update channel](/visualstudio/install/update-visual-studio?view=vs-2022&preserve-view=true#configure-source-location-of-updates-1). For example, you can install Visual Studio 2022 Enterprise Preview ([preview channel](/visualstudio/productinfo/release-rhythm)) alongside Visual Studio 2022 Enterprise (release channel) alongside Visual Studio 2019 Professional (release channel) alongside Visual Studio 2019 Professional (custom layout channel).

When you upgrade from one minor version of Visual Studio to the next, by default, the Visual Studio Installer updates your current installation to the latest version in that channel. For example, if Microsoft releases version 17.3.9 to the [Visual Studio 2022 release channel](/visualstudio/productinfo/release-rhythm), the installer tries to replace your current installation of Visual Studio 2022 from the release channel with this latest version on the same channel.

### Manual installation

You can manually use another bootstrapper to install a new instance of Visual Studio, or you can select one of the options from the Visual Studio Installer's **Available** tab.

1. To use another bootstrapper, you can download and run one of the bootstrapper files for Visual Studio 2022 from either the [Visual Studio downloads page](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) or the [Visual Studio 2022 releases](/visualstudio/releases/2022/release-history#release-dates-and-build-numbers) page for the minor version that you want to install side-by-side with your existing version of Visual Studio.

1. Using the installer's **Available** tab presumes that you already have some other version of Visual Studio installed. First find the **Visual Studio Installer** on your computer and launch it. After it updates itself, select the **Available** tab and install one of the offered products.

::: moniker-end

   :::image type="content" source="media/available-tab.png" alt-text="Screenshot showing the Visual Studio Installer's Available tab.":::

Then follow the steps to select the components you need for your installation. For more information, see [Install Visual Studio](install-visual-studio.md#step-4---choose-workloads).

> [!TIP]
> IT Administrators who want to suppress visibility of the Visual Studio Installer's **Available** tab or otherwise customize the availability of layout offerings on the **Available** tab can configure client registry and policies. For more information, see [configure policies for enterprise deployments of Visual Studio](/visualstudio/install/configure-policies-for-enterprise-deployments).

### Programmatic installation

You can also programmatically use either a bootstrapper or the installer to start a new installation of Visual Studio. Open a Command Prompt window as administrator and run one of the following commands. Specify a new folder path for the installation location. Replace the *.exe* file name with the appropriate bootstrapper name for the edition of Visual Studio that you're installing.

To install by using the bootstrapper:

```cmd
vs_Enterprise.exe --installPath "C:\Program Files (x86)\Microsoft Visual Studio\<AddNewPath>"
```

To install using the installer that is already present on the client machine:

```cmd
"C:\Program Files (x86)\Microsoft Visual Studio\Installer\setup.exe" --installPath "C:\Program Files (x86)\Microsoft Visual Studio\<AddNewPath>"
```

You can't initiate the installer programmatically from the same directory that the installer resides in.

## .NET Framework versions and side-by-side installations

Visual Basic, Visual C#, and Visual F# projects use the **Target Framework** option in the **Project Designer** to specify the version of the .NET Framework that they use. For a C++ project, you can manually change the target framework by modifying the *.vcxproj* file. For more information, see the [Version compatibility in the .NET Framework](/dotnet/framework/migration-guide/version-compatibility) page.

When you create a project, you can specify which version of the .NET Framework the project targets in the **.NET Framework** list in the **New Project** dialog box.

For language-specific information, see the appropriate article in the following table.

| Language     | Article |
|:-------------|:--------|
| Visual Basic | [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md) |
| Visual C#    | [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md) |
| Visual F#    | [Develop with Visual F# in Visual Studio](../ide/fsharp-visual-studio.md) |
| C++          | [How to: Modify the target framework and platform toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset/) |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## Related content

- [Install Visual Studio](install-visual-studio.md)
- [Building C/C++ isolated applications and side-by-side assemblies](/cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies/)
