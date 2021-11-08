---
title: MSBuild Response Files | Microsoft Docs
description: Learn about MSBuild response or .rsp files, text files that contain MSBuild.exe command-line switches.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- response files, MSBuild
- MSBuild, response files
- MSBuild, .rsp files
- .rsp files
ms.assetid: 9f53987b-20ee-470a-ab62-fce997bb5e15
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# MSBuild response files

Response (*.rsp*) files are text files that contain *MSBuild.exe* command-line switches. Each switch can be on a separate line or all switches can be on one line. Comment lines are prefaced with a **#** symbol. The **@** switch is used to pass another response file to *MSBuild.exe*.

## MSBuild.rsp

The autoresponse file is a special *.rsp* file that *MSBuild.exe* automatically uses when building a project. This file, *MSBuild.rsp*, must be in the same directory as *MSBuild.exe*, otherwise it will not be found. You can edit this file to specify default command-line switches to *MSBuild.exe*. For example, if you use the same logger every time you build a project, you can add the **-logger** switch to *MSBuild.rsp*, and *MSBuild.exe* will use the logger every time a project is built.

## Directory.Build.rsp

In version 15.6 and above, MSBuild will search parent directories of the project for a file named *Directory.Build.rsp*.  This can be helpful in a source code repository to provide default arguments during command-line builds.  It can also be used to specify the command-line arguments of hosted builds.

## See also

- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Command-line reference](../msbuild/msbuild-command-line-reference.md)
