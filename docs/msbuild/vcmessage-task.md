---
title: VCMessage Task
description: Learn how MSBuild uses the VCMessage task to log warning and error messages during a build for C++ projects. 
ms.date: 06/27/2018
ms.topic: reference
f1_keywords:
- vc.task.vcmessage
dev_langs:
- C++
helpviewer_keywords:
- VCMessage task (MSBuild (C++))
- MSBuild (C++), VCMessage task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# VCMessage task

[!INCLUDE [C++-specific task](./includes/cpp-task.md)]

Logs warning and error messages during a build.

## Remarks

 This task helps implement MSBuild for C++ projects and is not intended to be called by the user. For more information, see <xref:Microsoft.Build.Utilities.TaskLoggingHelper>.

## Parameters

 The following table describes the parameters of the **VCMessage** task.

|Parameter|Description|
|---------------|-----------------|
|**Arguments**|Optional **String** parameter.<br /><br /> A semicolon-delimited list of messages to display.|
|**Code**|Required **String** parameter.<br /><br /> An error number that qualifies the message.|
|**Type**|Optional **String** parameter.<br /><br /> Specifies the kind of message to emit. Specify either "Warning" to emit a warning message, or "Error" to emit an error message.|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
