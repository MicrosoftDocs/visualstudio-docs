---
title: BscMake Task
description: Learn about BscMake, which wrapped the Microsoft Browse Information Maintenance Utility tool bscmake.exe. The Visual Studio IDE no longer uses BscMake.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vc.task.bscmake
- VC.Project.VCBscMakeTool.PreserveSBR
dev_langs:
- C++
helpviewer_keywords:
- MSBuild (C++), tasks
- BscMake task (MSBuild (C++))
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# BscMake task

> [!IMPORTANT]
> BscMake is no longer used by the Visual Studio IDE. Since Visual Studio 2008, browse information is stored automatically in an *.sdf* file in the *Solution* folder.

[!INCLUDE [C++-specific task](./includes/cpp-task.md)]

 Wraps the Microsoft Browse Information Maintenance Utility tool (*bscmake.exe*).  The *bscmake.exe* tool builds a browse information file (*.bsc*) from source browser files (*.sbr*) that are created during compilation. Use the **Object Browser** to view a *.bsc* file. For more information, see [BSCMAKE reference](/cpp/build/reference/bscmake-reference).

## Parameters

 The following table describes the parameters of the **BscMake** task. Most task parameters correspond to a command-line option.

|Parameter|Description|
|---------------|-----------------|
|**AdditionalOptions**|Optional **String** parameter.<br /><br /> A list of options as specified on the command line. For example, /\<option1> /\<option2> /\<option#>. Use this parameter to specify options that are not represented by any other **BscMake** task parameter.<br /><br /> For more information, see the options in [BSCMAKE options](/cpp/build/reference/bscmake-options).|
|**OutputFile**|Optional **String** parameter.<br /><br /> Specifies a file name that overrides the default output file name.<br /><br /> For more information, see the **/o** option in [BSCMAKE options](/cpp/build/reference/bscmake-options).|
|**PreserveSBR**|Optional **Boolean** parameter.<br /><br /> If `true`, forces a nonincremental build. A full, nonincremental build occurs regardless of whether a *.bsc* file exists, and prevents *.sbr* files from being truncated.<br /><br /> For more information, see the **/n** option in [BSCMAKE options](/cpp/build/reference/bscmake-options).|
|**Sources**|Optional **ITaskItem[]** parameter.<br /><br /> Defines an array of MSBuild source file items that can be consumed and emitted by tasks.|
|**SuppressStartupBanner**|Optional **Boolean** parameter.<br /><br /> If `true`, prevents the display of the copyright and version number message when the task starts.<br /><br /> For more information, see the **/NOLOGO** option in [BSCMAKE options](/cpp/build/reference/bscmake-options).|
|**TrackerLogDirectory**|Optional **String** parameter.<br /><br /> Specifies the directory for the tracker log.|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
