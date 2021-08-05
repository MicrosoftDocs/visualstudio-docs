---
title: TaskExtension Base Class | Microsoft Docs
description: Learn about the parameters that the Microsoft.Build.Tasks.TaskExtension base class adds to the tasks that inherit from it.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, tool task base class
- tool task base class [MSBuild]
ms.assetid: 08bb8059-b7e2-4565-89ba-d9034d4f0e16
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# TaskExtension base class

Many tasks inherit from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. This inheritance chain adds several parameters to the tasks that derive from them. These parameters are listed in this document.

## Parameters

 The following table describes the parameters of the base classes.

|Parameter|Description|
|---------------|-----------------|
|<xref:Microsoft.Build.Utilities.Task.BuildEngine%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.|
|<xref:Microsoft.Build.Utilities.Task.BuildEngine2%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine2> parameter.<br /><br /> Specifies the build engine interface available to tasks. The build engine automatically sets this parameter to allow tasks to call back into it.<br /><br /> This is a convenience property so that task authors inheriting from this class do not have to cast the value from `IBuildEngine` to `IBuildEngine2`.|
|<xref:Microsoft.Build.Utilities.Task.BuildEngine3%2A>|Optional <xref:Microsoft.Build.Framework.IBuildEngine3> parameter.<br /><br /> Specifies the build engine interface provided by the host.|
|<xref:Microsoft.Build.Utilities.Task.HostObject%2A>|Optional <xref:Microsoft.Build.Framework.ITaskHost> parameter.<br /><br /> Specifies the host object instance (can be null). The build engine sets this property if the host IDE has associated a host object with this particular task.|
|<xref:Microsoft.Build.Tasks.TaskExtension.Log%2A>|Optional <xref:Microsoft.Build.Utilities.TaskLoggingHelper> read-only parameter.<br /><br /> Gets a `TaskLoggingHelperExtension` object that contains task logging methods.|

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
