---
title: "Options Dialog Box,  Projects and Solutions, Build and Run | Microsoft Docs"
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
  - "VS.ToolsOptionsPages.Projects.Build_and_Run"
  - "VS.ToolsOptionsPag.Projects.Build_and_Run"
helpviewer_keywords: 
  - "builds [Visual Studio], setting up"
  - "run actions"
  - "debugger, run options"
ms.assetid: c884976e-c0df-4c6d-8e3a-856ea2bd547c
caps.latest.revision: 20
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Options Dialog Box,  Projects and Solutions, Build and Run
In this dialog box, you can specify the maximum number of Visual C++ or Visual C# projects that can build at the same time, certain default build behaviors, and some build log settings. To open the **Options** dialog box, choose **Tools**, **Options** on the menu bar. To access this set of options, expand **Projects and Solutions**, and then choose **Build and Run**.  
  
## UIElement List  
 **maximum number of parallel project builds**  
 Specifies the maximum number of Visual C++ and Visual C# projects that can build at the same time. To optimize the build process, the maximum number of parallel project builds is automatically set to the number of CPUs of your computer. The maximum is 32.  
  
 **Only build startup projects and dependencies on Run**  
 Only the startup project and its dependencies are built if this check box is selected when you choose the F5 key; choose **Debug**, **Start** on the menu bar; or choose **Build**, **Build** on the menu bar. All projects, dependencies, and solution files are built if this check box is cleared when you choose the F5 key; choose **Debug**, **Start** on the menu bar; or choose **Build**, **Build** on the menu bar. By default, this option is cleared.  
  
 **On Run, when projects are out of date**  
 > [!NOTE]
>  This list applies to [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] projects only.  
  
 By default, a message appears if a project configuration is out of date when you choose the F5 key or choose **Debug**, **Start** on the menu bar. You can specify whether to build the project anyway and whether the message appears. Use this option to specify whether the message appears and what the build behavior should be if the message doesn't appear.  
  
 **Always build**  
 The message box doesn't appear, and the project is built despite the out-of-date configuration. This option is set when you select the **Do not show this dialog again** box in the message and then choose the **Yes** button.  
  
 **Never build**  
 The message box doesn't appear, and the project isn't built. This option is set when you select the **Do not show this dialog again** box in the message and then choose the **No** button.  
  
 **Prompt to build**  
 Displays the message box every time that a project configuration is out of date.  
  
 **On Run, when build or deployment errors occur**  
 If build errors occur when you start a build from the **Build** menu, a message appears. You can specify whether to continue by starting the application and whether the message appears every time that build errors occur. Use this option to specify whether the message appears and what the behavior should be if the message doesn't appear.  
  
> [!NOTE]
>  This option applies to [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] projects only.  
  
 **Prompt to launch**  
 Displays a message box every time that build errors occur.  
  
 **Do not launch**  
 The message box doesn't appear, and the application isn't started. This option is set when you select the **Do not show this dialog again** check box in the message box and then choose the **No** button.  
  
 **Launch old version**  
 The message box doesn't appear, and the newly built version of the application isn't started. This option is set when you select the **Do not show this dialog again** check box in the message box and then choose the **Yes** button.  
  
 **For new solutions use the currently selected project as the startup project**  
 If this check box is selected, new solutions use the currently selected project as the startup project.  
  
 **MSBuild project build output verbosity**  
 Determines how much information appears in the **Output** window for the build.  
  
 **MSBuild project build log file verbosity**  
 > [!NOTE]
>  This option applies to Visual C++ projects only.  
  
 Determines how much information is written to the build log file, which is located at \\...\\*ProjectName*\Debug\\*ProjectName*.log.  
  
## See Also  
 [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)