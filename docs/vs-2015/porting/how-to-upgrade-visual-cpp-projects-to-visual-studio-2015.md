---
title: "How to: Upgrade Visual C++ Projects to Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "projects [C++], upgrading"
ms.assetid: 9a283ebb-f6d8-49c0-a73e-323979ff56a2
caps.latest.revision: 26
author: "mikeblome"
ms.author: "mblome"
manager: jillfra
---
# How to: Upgrade Visual C++ Projects to Visual Studio 2015
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the lastest documentation for Visual Studio 2017, see [Visual C++ Porting and Upgrading Guide](https://docs.microsoft.com/cpp/porting/visual-cpp-porting-and-upgrading-guide).

When you first open a Visual C++ project that was created in an earlier version of Visual Studio, you might be prompted to update the project. The message asks whether you want to upgrade to the most recent version of the Visual C++ compiler and libraries. The options for upgrading depend on the version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that was used to create the project.

 You can use [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)] to open, edit, and build [!INCLUDE[win8](../includes/win8-md.md)] projects that were created in [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], but to create a new [!INCLUDE[win8](../includes/win8-md.md)] project, you must use [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)]. (To create a [!INCLUDE[win81](../includes/win81-md.md)] project, you must use [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)].)

 To create a Windows 10 project, you must use [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)].

 If you aren't prompted to update the project, you may not have to do anything to upgrade the project.

- If the project (.vcproj) was created in a version of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that's older than [!INCLUDE[vs2010](../includes/vs2010-md.md)], you must update the project.

- If the project (.vcxproj) was created in [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)],  [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], or [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)] you have two options:

  - You can skip the update. [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)] will load the project without making any changes if it has access to the Visual C++ tools in [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] with SP1,  [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], or [!INCLUDE[vs_dev12](../includes/vs-dev12-md.md)]. You can provide this access by installing the version of Visual Studio that the project was created with on the same machine that has [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)]. For more information, see [Installing Visual Studio Versions Side-by-Side](../install/install-visual-studio-versions-side-by-side.md).

  - You can update the project by allowing [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to make the changes that are described later in this topic. If you have more than one Visual C++ project in your solution, you must update all of them.

    > [!NOTE]
    > If you decline the update when you're first prompted, you can update the project later by choosing **Update VC++ project** on the **Project** menu. If the command doesn't appear, then an update isn't required.

## Upgrading a Visual C++ Project
 If you allow [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)] to automatically update the project, these changes are made:

- Changes the project so that it uses the [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)] compiler and libraries (PlatformToolset = VisualStudio v140).

- For [!INCLUDE[cppcli](../includes/cppcli-md.md)] projects, changes the TargetFrameworkVersion to the .NET Framework 4.5.2.

## Continuing to Work with a Custom PlatformToolset
 If you want to continue to work with a custom PlatformToolset in [!INCLUDE[vs_dev14](../includes/vs-dev14-md.md)], the toolset must be located under %ProgramFiles%\MSBuild\Microsoft.Cpp\v4.0\Platforms\Win32\PlatformToolsets\ on an x86 machine, or under %ProgramFiles (x86)%\MSBuild\Microsoft.Cpp\v4.0\Platforms\Win32\PlatformToolsets\ on an x64 machine. For information about how to create a custom PlatformToolset, see [C++ Native Multi-Targeting](https://go.microsoft.com/fwlink/?LinkId=248587) on the Visual C++ Team blog.

## See Also
 [Visual C++ Porting and Upgrading Guide](https://msdn.microsoft.com/library/f5fbcc3d-aa72-41a6-ad9a-a706af2166fb)
 [Porting, Migrating, and Upgrading Visual Studio Projects](../porting/porting-migrating-and-upgrading-visual-studio-projects.md)
