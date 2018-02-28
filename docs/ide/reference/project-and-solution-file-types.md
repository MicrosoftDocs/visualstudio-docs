---
title: "Project and Solution File Types | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "File Properties.CopyToOutputDirectory"
  - "File Properties.CustomToolNamespace"
  - "File Properties.FileName"
  - "File Properties.FullPath"
  - "File Properties.BuildAction"
  - "File Properties.CustomTool"
  - "FileProperties"
helpviewer_keywords: 
  - ".sln files"
  - ".suo files"
  - "file types [Visual Studio]"
  - "file extensions [Visual Studio]"
  - "solution files [Visual Studio]"
  - "sln files"
  - "suo files"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Project and solution file types

Visual Studio supports many file types. In a particular installation, the installed components determine which file types are supported. This topic lists solution and project file types that are supported in some typical installations.

## Solution files (.sln and .suo)

Visual Studio uses two file types (.sln and .suo) to store settings for solutions. These files, known collectively as solution files, provide Solution Explorer with the information it needs to display a graphical interface for managing your files.

|Extension|Name|Description|
|---------------|----------|-----------------|
|.sln|Visual Studio Solution|Organizes projects, project items and solution items into the solution.|
|.suo|Solution User Options|Keeps track of user-level customizations you have made to Visual Studio, such as breakpoints.|

## Project files

Projects can contain many different file types. For example, C# code files have a **.cs** extension, and C++ files have a **.cpp** extension. Resources are stored in **.resx** files, and XAML in **.xaml** files. [App.config](../../ide/managing-application-settings-dotnet.md) files contain application information that should not be included in the application code&mdash;for example connection strings.

For more information about file types in C++ projects, see [File Types Created for Visual C++ Projects](/cpp/ide/file-types-created-for-visual-cpp-projects) and [Unicode in Microsoft Foundation Class Library](/cpp/mfc/unicode-in-mfc)

## See also

[Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)