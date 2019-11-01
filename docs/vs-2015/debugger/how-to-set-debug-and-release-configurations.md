---
title: "How to: Set Debug and Release Configurations | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.builds"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "configurations, release"
  - "build configurations, release"
  - "projects [Visual Studio], release configurations"
  - "debugging [Visual Studio], release configurations"
  - "release builds, changing settings"
  - "debug builds"
  - "debug builds, switching to release build"
  - "debug builds, changing configuration settings"
  - "debugging [Visual Studio], debug configurations"
  - "projects [Visual Studio], debug configurations"
  - "build configurations, debug"
  - "debug configurations"
  - "release builds, switching to debug build"
  - "Visual Basic projects, debug and release builds"
ms.assetid: 57b6bbb7-f2af-48f7-8773-127d75034ed2
caps.latest.revision: 48
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Set Debug and Release Configurations
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio projects have separate release and debug configurations for your program. As the names imply, you build the debug version for debugging and the release version for the final release distribution.  
  
 The debug configuration of your program is compiled with full symbolic debug information and no optimization. Optimization complicates debugging, because the relationship between source code and generated instructions is more complex.  
  
 The release configuration of your program contains no symbolic debug information and is fully optimized. Debug information can be generated in PDB Files, depending on the compiler options that are used. Creating PDB files can be very useful if you later have to debug your release version.  
  
 For more information about build configurations, see [Understanding Build Configurations](../ide/understanding-build-configurations.md).  
  
 You can change the build configuration from the **Build** menu, from the toolbar, or in the project’s property pages. Project property pages are language-specific. The procedure below shows how to change the build configuration from the menu and the toolbar. For more information about how to change the build configuration in projects in different languages, see the Related Topics section below.  
  
### To change the build configuration  
  
1. From the Build menu: click **Build / Configuration Manager**, then select **Debug** or **Release**.  
  
2. On the toolbar, choose either **Debug** or **Release** from the **Solution Configurations** list box.  
  
     ![toolbar build configuration](../debugger/media/toolbarbuildconfiguration.png "ToolbarBuildConfiguration")  
  
     This toolbar is not available in Express editions. You can use the **Build Solution F6** and **Start Debugging F5** menu items to choose the configuration.  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [How to: Create and Edit Configurations](../ide/how-to-create-and-edit-configurations.md)   
 [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e)
