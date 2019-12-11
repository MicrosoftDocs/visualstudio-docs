---
title: "Install Visual Studio Versions Side-by-Side | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
helpviewer_keywords:
  - "side-by-side installations [Visual Studio]"
  - "Help [Visual Studio], installing"
  - "install multiple versions of Visual Studio"
ms.assetid: 4d00f240-4910-4699-aaf3-cda6461f0c29
caps.latest.revision: 48
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Install Visual Studio Versions Side-by-Side
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can install this version of Visual Studio on a computer that already has an earlier version installed. If you encounter an installation failure, you can use the [log collection tool](https://go.microsoft.com/fwlink/?LinkId=262077) to collect information about the failures so you can debug the issues yourself.

> [!NOTE]
> We recommend that you install [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] versions in the order in which they were released. For example, install Visual Studio 2013 before you install Visual Studio 2015.

 Before you install versions side by side, review the following conditions:

- If you use Visual Studio 2015 to open a solution that was created in [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)], you can later open and modify the solution again in the older version as long as you haven't implemented any features that are specific to Visual Studio 2015.

- If you try to use Visual Studio 2015 to open a solution that was created in [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)] or an earlier version, you might need to modify your projects and files to be compatible with Visual Studio 2015. For more information, see the [Port, Migrate, and Upgrade Visual Studio Projects](/visualstudio/porting/port-migrate-and-upgrade-visual-studio-projects?view=vs-2015) page.

- If you uninstall a version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] on a computer that has more than one version installed, the file associations for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] are removed for all versions. You can remap these file associations by using the **Restore File Associations** button on the **Environment**, **General** page of the [Options](../ide/reference/general-environment-options-dialog-box.md) dialog box.

- Visual Studio doesn't automatically upgrade extensions because not all extensions are compatible. You must reinstall the extensions from the [Visual Studio Marketplace](https://go.microsoft.com/fwlink/?LinkId=178891) or the software publisher.

## .NET Framework Versions and Side-by-Side Installations

- Visual Basic, Visual C#, and Visual F# projects use the **Target Framework** option in the **Project Designer** to specify which version of the .NET Framework a project uses. For a C++ project, you can manually change the target framework by modifying the .vcxproj file. For more information, see [Version Compatibility](https://msdn.microsoft.com/library/2f25e522-456a-48c3-8a53-e5f39275649f).

     When you create a project, you can specify which version of the .NET Framework the project targets in the **.NET Framework** list in the **New Project** dialog box.

     For language-specific information, see the appropriate topic in the following table.

    |Language|Topic|
    |--------------|-----------|
    |[!INCLUDE[vbprvb](../includes/vbprvb-md.md)]|[Application Page, Project Designer (Visual Basic)](../ide/reference/application-page-project-designer-visual-basic.md)|
    |Visual C#|[Application Page, Project Designer (C#)](../ide/reference/application-page-project-designer-csharp.md)|
    |Visual F#|[Configuring Projects](https://msdn.microsoft.com/library/a1489abb-6294-4f8f-b71f-2cb126393526)|
    |C++|[How to: Modify the Target Framework and Platform Toolset](https://msdn.microsoft.com/library/031b1d54-e6e1-4da7-9868-3e75a87d9ffe)|
    |[!INCLUDE[jsprjscript](../includes/jsprjscript-md.md)]|[Running a JScript Application on a Previous Version of the Common Language Runtime](https://msdn.microsoft.com/bbea51b5-ac03-4e6c-b9a6-f487ef63eda5)|

## See Also

- [Install Visual Studio](../install/install-visual-studio-2015.md)
- [Port, Migrate, and Upgrade Visual Studio Projects](/visualstudio/porting/port-migrate-and-upgrade-visual-studio-projects?view=vs-2015)
- [Building C/C++ Isolated Applications and Side-by-side Assemblies](https://msdn.microsoft.com/library/9465904e-76f7-48bd-bb3f-c55d8f1699b6)
- [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3)