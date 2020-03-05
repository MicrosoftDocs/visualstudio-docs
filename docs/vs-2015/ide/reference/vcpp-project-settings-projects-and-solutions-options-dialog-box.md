---
title: "VC++ Project Settings, Projects and Solutions, Options Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
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
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# VC++ Project Settings, Projects and Solutions, Options Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This dialog box lets you define [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] project settings related to build logging and supporting file types.

### To access this dialog box

1. On the **Tools** menu, click **Options**.

2. Select **Projects and Solutions**, and then select **VC++ Project Settings**.

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
 Lists environment variables in the build log file. This option specifies to echo all environment variables, during builds of [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] projects, into the build log file.

 **No**
 Exclude environment variables from the build log file.

## Solution Explorer Mode
 **Show only files in project**
 Configures **Solution Explorer** to only display files in the project.

 **Show all files**
 Configures **Solution Explorer** to show files in the project and files on disk in the project folder.

## See Also
 [Building C/C++ Programs](https://msdn.microsoft.com/library/fa6ed4ff-334a-4d99-b5e2-a1f83d2b3008)
 [C/C++ Building Reference](https://msdn.microsoft.com/library/100b4ccf-572c-4d1f-970c-fa0bc0cc0d2d)
