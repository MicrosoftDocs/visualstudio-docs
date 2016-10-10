---
title: "How to: Upgrade Visual C++ Projects to Visual Studio 2015"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9a283ebb-f6d8-49c0-a73e-323979ff56a2
caps.latest.revision: 22
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Upgrade Visual C++ Projects to Visual Studio 2015
When you first open a Visual C++ project that was created in an earlier version of Visual Studio, you might be prompted to update the project. The message asks whether you want to upgrade to the most recent version of the Visual C++ compiler and libraries. The options for upgrading depend on the version of Visual Studio that was used to create the project.  
  
 You can use Visual Studio 2013 to open, edit, and build Windows 8 projects that were created in Visual Studio 2012, but to create a new Windows 8 project, you must use Visual Studio 2012. (To create a Windows 8.1 project, you must use Visual Studio 2013.)  
  
 To create a Windows 10 project, you must use Visual Studio 2015.  
  
 If you aren't prompted to update the project, you may not have to do anything to upgrade the project.  
  
-   If the project (.vcproj) was created in a version of Visual Studio that's older than Visual Studio 2010, you must update the project.  
  
-   If the project (.vcxproj) was created in Visual Studio 2010,  Visual Studio 2012, or Visual Studio 2013 you have two options:  
  
    -   You can skip the update. Visual Studio 2015 will load the project without making any changes if it has access to the Visual C++ tools in Visual Studio 2010 with SP1,  Visual Studio 2012, or Visual Studio 2013. You can provide this access by installing the version of Visual Studio that the project was created with on the same machine that has Visual Studio 2015. For more information, see [Installing Visual Studio Versions Side-by-Side](../VS_Installing/Installing-Visual-Studio-Versions-Side-by-Side.md).  
  
    -   You can update the project by allowing Visual Studio to make the changes that are described later in this topic. If you have more than one Visual C++ project in your solution, you must update all of them.  
  
        > [!NOTE]
        >  If you decline the update when you're first prompted, you can update the project later by choosing **Update VC++ project** on the **Project** menu. If the command doesn't appear, then an update isn't required.  
  
## Upgrading a Visual C++ Project  
 If you allow Visual Studio 2015 to automatically update the project, these changes are made:  
  
-   Changes the project so that it uses the Visual Studio 2015 compiler and libraries (PlatformToolset = VisualStudio v140).  
  
-   For C++/CLI projects, changes the TargetFrameworkVersion to the .NET Framework 4.5.2.  
  
## Continuing to Work with a Custom PlatformToolset  
 If you want to continue to work with a custom PlatformToolset in Visual Studio 2015, the toolset must be located under %ProgramFiles%\MSBuild\Microsoft.Cpp\v4.0\Platforms\Win32\PlatformToolsets\ on an x86 machine, or under %ProgramFiles (x86)%\MSBuild\Microsoft.Cpp\v4.0\Platforms\Win32\PlatformToolsets\ on an x64 machine. For information about how to create a custom PlatformToolset, see [C++ Native Multi-Targeting](http://go.microsoft.com/fwlink/?LinkId=248587) on the Visual C++ Team blog.  
  
## See Also  
 [Visual C++ Porting and Upgrading Guide](../Topic/Visual%20C++%20Porting%20and%20Upgrading%20Guide.md)   
 [Porting, Migrating, and Upgrading Visual Studio Projects](../VS_Porting/Porting--Migrating--and-Upgrading-Visual-Studio-Projects.md)