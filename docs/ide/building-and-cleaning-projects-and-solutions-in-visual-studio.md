---
title: "Building and Cleaning Projects and Solutions in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.BuildProjectPicker"
  - "vs.batchbuild"
helpviewer_keywords: 
  - "Clean Solution command"
  - "builds [Visual Studio], managing"
  - "solution build configurations, starting"
  - "Build Solution command"
  - "project build configurations, starting"
  - "build configurations, starting"
  - "project build configurations, dependencies"
  - "Rebuild Solution command"
  - "solution build configurations, build order"
  - "builds [Visual Studio], preparing"
ms.assetid: 710891fd-379e-42c2-a84b-44a7af694ca0
caps.latest.revision: 35
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Building and Cleaning Projects and Solutions in Visual Studio
By using the procedures in this topic, you can build, rebuild, or clean all or some of the projects or project items in a solution. For a step-by-step tutorial, see [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md).  
  
> [!NOTE]
>  The UI in your edition of Visual Studio might differ from what this topic describes, depending on your active settings. To change your settings, open the **Tools** menu, and then choose **Import and Export Settings**. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To build, rebuild, or clean an entire solution  
  
1.  In **Solution Explorer**, choose or open the solution.  
  
2.  On the menu bar, choose **Build**, and then choose one of the following commands:  
  
    -   Choose **Build** or **Build Solution** to compile only those project files and components that have changed since the most recent build.  
  
        > [!NOTE]
        >  The **Build** command becomes **Build Solution** when a solution includes more than one project.  
  
    -   Choose **Rebuild Solution** to "clean" the solution and then build all project files and components.  
  
    -   Choose **Clean Solution** to delete any intermediate and output files. With only the project and component files left, new instances of the intermediate and output files can then be built.  
  
### To build or rebuild a single project  
  
1.  In **Solution Explorer**, choose or open the project.  
  
2.  On the menu bar, choose **Build**, and then choose either **Build***ProjectName* or **Rebuild***ProjectName*.  
  
    -   Choose **Build***ProjectName* to build only those project components that have changed since the most recent build.  
  
    -   Choose **Rebuild***ProjectName* to "clean" the project and then build the project files and all project components.  
  
### To build only the startup project and its dependencies  
  
1.  On the menu bar, choose **Tools**, **Options**.  
  
2.  In the **Options** dialog box, expand the **Projects and Solutions** node, and then choose the **Build and Run** page.  
  
     The **Build and Run, Projects and Solutions, Options** dialog box opens.  
  
3.  Select the  **Only build startup projects and dependencies on Run** check box.  
  
     When this check box is selected, only the current startup project and its dependencies are built when you perform either of the following steps:  
  
    -   On the menu bar, choose **Debug**, **Start** (F5).  
  
    -   On the menu bar, choose **Build**, **Build Solution** (CTRL+SHIFT+B).  
  
     When this check box is cleared, all projects, their dependencies, and the solution files are built when you run either of the preceding commands. By default, this check box is cleared.  
  
### To build only the selected Visual C++ project  
  
1.  Choose a [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] project, and then, on the menu bar, choose **Build**, **Project Only**, and one of the following commands:  
  
    -   **Build Only** *ProjectName*  
  
    -   **Rebuild Only** *ProjectName*  
  
    -   **Clean Only** *ProjectName*  
  
    -   **Link Only** *ProjectName*  
  
     These commands apply only to the [!INCLUDE[vcprvc](../code-quality/includes/vcprvc_md.md)] project that you chose, without building, rebuilding, cleaning, or linking any project dependencies or solution files. Depending on your version of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], the **Project Only** submenu might contain more commands.  
  
### To compile multiple C++ project items  
  
1.  In **Solution Explorer**, choose multiple files that have can be compiled actions, open the shortcut menu for one of those files, and then choose **Compile**.  
  
     If the files have dependencies, the files will be compiled in dependency order. The compile operation will fail if the files require a precompiled header that isn’t available when you compile. The compile operation uses the current active solution configuration.  
  
### To stop a build  
  
1.  Perform either of the following steps:  
  
    -   On the menu bar, choose **Build**, **Cancel**.  
  
    -   Choose the Ctrl + Break keys.  
  
## See Also  
 [How to: View, Save, and Configure Build Log Files](../ide/how-to-view-save-and-configure-build-log-files.md)   
 [Obtaining Build Logs](../msbuild/obtaining-build-logs-with-msbuild.md)   
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)   
 [Understanding Build Configurations](../ide/understanding-build-configurations.md)   
 [Debug and Release Project Configurations](http://msdn.microsoft.com/en-us/0440b300-0614-4511-901a-105b771b236e)   
 [C/C++ Building Reference](/visual-cpp/build/reference/c-cpp-building-reference)   
 [Devenv Command Line Switches](../ide/reference/devenv-command-line-switches.md)   
 [Solutions and Projects](../ide/solutions-and-projects-in-visual-studio.md)