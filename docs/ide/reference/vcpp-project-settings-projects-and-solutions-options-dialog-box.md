---
title: C++ Project Settings options
description: Learn how to use the VC++ Project Settings page in the Projects and Solutions section to define C++ build and project settings related to logging, performance, and supporting file types.
ms.date: 08/02/2017
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
ms.custom: "ide-ref"
author:tylermsft
ms.author: twhitney
manager: markl
---
# VC++ Project Settings, Projects and Solutions, Options Dialog Box

This dialog box lets you define C++ build and project settings related to logging, performance, and supporting file types.

## To access this dialog box

1. On the **Tools** menu, click **Options**.

2. Select **Projects and Solutions**, and then select **VC++ Project Settings**.

## Build Logging

 **Yes**

  Turns on generation of the build log file. This option generates BuildLog.htm, which can be found in the project's intermediate files directory. Every fresh build overwrites the previous BuildLog.htm file.

 **No**

  Turns off generation of the build log file.

## Show Environment in Log

 **Yes**

Lists environment variables in the build log file. This option specifies to echo all environment variables, during builds of C++ projects, into the build log file.

 **No**

Exclude environment variables from the build log file.

## Build Timing

 **Yes**

  Turns on build timing. If selected, the time it takes for the build to complete is posted to the Output window. For more information, see [Output Window](../../ide/reference/output-window.md).

 **No**

Turns off build timing.

## Maximum concurrent C++ compilations

Specifies the maximum number of CPU cores to use for parallel C++ compilation.

## Extensions to Include

Specifies the file name extensions of files that can be ported into your project.

## Extensions to Hide

Specifies the file name extensions of files that will not be displayed in **Solution Explorer** when **Show All Files** is enabled.

## Build Customization Search Path

Specifies the list of directories that contain .rules files, which help you define build rules for your projects.

## Solution Explorer Mode

**Show only files in project**

Configures **Solution Explorer** to only display files in the project.

**Show all files**

Configures **Solution Explorer** to show files in the project and files on disk in the project folder.

## Enable Project Caching

**Yes**

Enables Visual Studio to cache project data so that when you open the project the next time, it can load that cached data rather than recomputing it from the project files. Using cached data can speed up the project load time significantly.

**No**

Do not use cached project data. Parse the project files each time the project loads.

## See also

- [Building C/C++ Programs](/cpp/build/projects-and-build-systems-cpp)
- [C/C++ Building Reference](/cpp/build/reference/c-cpp-building-reference)