---
title: "Install Visual Studio versions side-by-side"
ms.date: 03/05/2019
ms.prod: "visual-studio-windows"
ms.technology: "vs-installation"
ms.topic: conceptual
helpviewer_keywords:
  - "side-by-side installations [Visual Studio]"
  - "Help [Visual Studio], installing"
  - "install multiple versions of Visual Studio"
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Install Visual Studio versions side-by-side

You can install Visual Studio on a computer that has an earlier or later version of Visual Studio already installed.

::: moniker range="vs-2017"

Before you install versions side-by-side, review the following conditions:

* If you use Visual Studio 2017 to open a solution that was created in Visual Studio 2015, you can later open and modify the solution again in the earlier version as long as you haven't implemented any features that are specific to Visual Studio 2017.

* If you try to use Visual Studio 2017 to open a solution that was created in Visual Studio 2015 or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2017. For more information, see the [Port, migrate, and upgrade Visual Studio Projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md?view=vs-2017) page.

::: moniker-end

::: moniker range=">= vs-2019"

Before you install versions side-by-side, review the following conditions:

* If you use Visual Studio 2019 to open a solution that was created in Visual Studio 2017, you can later open and modify the solution again in the earlier version as long as you haven't implemented any features that are specific to Visual Studio 2019.

* If you try to use Visual Studio 2019 to open a solution that was created in Visual Studio 2017 or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2019. For more information, see the [Port, migrate, and upgrade Visual Studio Projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md) page.

::: moniker-end

* If you uninstall a version of Visual Studio on a computer that has more than one version installed, the file associations for Visual Studio are removed for all versions.

* Visual Studio doesn't automatically upgrade extensions because not all extensions are compatible. You must reinstall the extensions from the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or the software publisher.

## .NET Framework versions and side-by-side installations

Visual Basic, Visual C#, and Visual F# projects use the **Target Framework** option in the **Project Designer** to specify which version of the .NET Framework that a project uses. For a C++ project, you can manually change the target framework by modifying the .vcxproj file. For more information, see the [Version compatibility in the .NET Framework](/dotnet/framework/migration-guide/version-compatibility) page.

When you create a project, you can specify which version of the .NET Framework the project targets in the **.NET Framework** list in the **New Project** dialog box.

For language-specific information, see the appropriate topic in the following table.

::: moniker range="vs-2017"

| Language | Topic |
|--------------|-----------|
| Visual Basic | [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md?view=vs-2017) |
| Visual C# | [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md?view=vs-2017) |
| Visual F# | [Develop with Visual F# in Visual Studio](../ide/fsharp-visual-studio.md?view=vs-2017) |
|C++ | [How to: Modify the target framework and platform toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset/) |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md?view=vs-2017)
* [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md?view=vs-2017)
* [Building C/C++ isolated applications and side-by-side assemblies](/cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies/)

::: moniker-end

::: moniker range=">= vs-2019"

| Language | Topic |
|--------------|-----------|
| Visual Basic | [Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md) |
| Visual C# | [Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md) |
| Visual F# | [Develop with Visual F# in Visual Studio](../ide/fsharp-visual-studio.md) |
| C++ | [How to: Modify the target framework and platform toolset](/cpp/build/how-to-modify-the-target-framework-and-platform-toolset/) |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md)
* [Building C/C++ isolated applications and side-by-side assemblies](/cpp/build/building-c-cpp-isolated-applications-and-side-by-side-assemblies/)

::: moniker-end