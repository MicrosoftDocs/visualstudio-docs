---
title: "VC++ Project Settings, Projects and Solutions, Options Dialog Box | Microsoft Docs"
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
  - "VS.ToolsOptionsPages.Projects.VCBuild"
helpviewer_keywords: 
  - "builds [Visual Studio], logs"
  - "build process [C++]"
  - "files [Visual Studio], built by C/C++ compiler"
  - "file extensions, built by C or C++ compiler"
  - "cl.exe compiler, file extensions"
  - "extensions, files built by C or C++ compiler"
  - "BuildLog.htm"
ms.assetid: 56420efd-6a95-464e-b890-e2b38c48d66a
caps.latest.revision: 15
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
# VC++ Project Settings, Projects and Solutions, Options Dialog Box
This dialog box lets you define [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] project settings related to build logging and supporting file types.  
  
### To access this dialog box  
  
1.  On the **Tools** menu, click **Options**.  
  
2.  Select **Projects and Solutions**, and then select **VC++ Project Settings**.  
  
## Build Customization Search Path  
 Specifies the list of directories that contain .rules files, which help you define build rules for your projects.  
  
## Build Logging  
 **Yes**  
 Turns on generation of the build log file. This option generates BuildLog.htm, which can be found in the project's intermediate files directory. Every fresh build overwrites the previous BuildLog.htm file.  
  
 **No**  
 Turns off generation of the build log file.  
  
## Build Timing  
 **Yes**  
 Turns on build timing. If selected, the time it takes for the build to complete is posted to the Output window. For more information, see [Output Window](../../ide/reference/output-window.md).  
  
 **No**  
 Turns off build timing.  
  
## Extensions to Hide  
 Specifies the file name extensions of files that will not be displayed in **Solution Explorer** when **Show All Files** is enabled.  
  
## Extensions to Include  
 Specifies the file name extensions of files that can be ported into your project.  
  
## Maximum concurrent C++ compilations  
 Specifies the maximum number of CPU cores to use for parallel C++ compilation.  
  
## Show Environment in Log  
 **Yes**  
 Lists environment variables in the build log file. This option specifies to echo all environment variables, during builds of [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] projects, into the build log file.  
  
 **No**  
 Exclude environment variables from the build log file.  
  
## Solution Explorer Mode  
 **Show only files in project**  
 Configures **Solution Explorer** to only display files in the project.  
  
 **Show all files**  
 Configures **Solution Explorer** to show files in the project and files on disk in the project folder.  
  
## See Also  
 [Building C/C++ Programs](/visual-cpp/build/building-c-cpp-programs)   
 [C/C++ Building Reference](/visual-cpp/build/reference/c-cpp-building-reference)