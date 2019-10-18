---
title: "Project and Solution File Types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "File Properties.CopyToOutputDirectory"
  - "File Properties.CustomToolNamespace"
  - "File Properties.FileName"
  - "File Properties.FullPath"
  - "File Properties.BuildAction"
  - "File Properties.CustomTool"
  - "FileProperties"
helpviewer_keywords:
  - "suo files"
  - "file types, Visual Studio"
  - "file extensions"
  - "solutions, solution files"
  - "solution files"
  - ".sln files"
  - "Visual Studio, file types and extensions"
  - "extensions, file types"
  - "sln files"
  - ".suo files"
  - "file extensions, Visual Studio"
  - "file types"
ms.assetid: 0ba5007b-465d-4efa-b1e4-f0ee68527649
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: jillfra
---
# Project and Solution File Types
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

[!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] supports many file types. In a particular installation, the installed components determine which file types are supported. This topic lists solution and project file types that are supported in some typical installations. For information about other file types, search by using the file name extensions for each type.

## Solution Files (.sln and .suo)
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] uses two file types (.sln and .suo) to store settings specific to solutions. These files, known collectively as solution files, provide Solution Explorer with the information it needs to display a graphical interface for managing your files. They allow you to concentrate on your projects and final goals rather than on the environment itself each time you return to your development tasks.

|Extension|Name|Description|
|---------------|----------|-----------------|
|.sln|[!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] Solution|Organizes projects, project items and solution items into the solution.|
|.suo|Solution User Options|Keeps track of user-level customizations you have made Visual Studio, such as breakpoints.|

## Project Files
 [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] uses a variety of file formats to store information specific to projects. For more information, see the following Help topics:

 [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)]
 [File Types Created for Visual C++ Projects](https://msdn.microsoft.com/library/2b0ee2e0-ae81-4185-9bb9-11da3c99a283)

 [Creating and Managing Visual C++ Projects](https://msdn.microsoft.com/library/11003cd8-9046-4630-a189-a32bf3b88047)

 [Unicode](https://msdn.microsoft.com/library/1002004b-4113-4380-bf63-e1570934b793)

## See Also
 [Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)
